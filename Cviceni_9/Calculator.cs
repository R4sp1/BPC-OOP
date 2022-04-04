using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Cviceni_9
{
    class Calculator
    {
        private Stav _stav = Stav.PrvniCislo;
        public String Display { get; set; }     //co se má zobrazit.
        public String Pamet { get; set; }       //vzdy prazdne

        private string one = "";
        private Operace operation;
        private string two = "";
        private string answer = "";

        public void Tlacitko(String btn)
        {

            var cislo = "";

            switch (btn)
            {
                case "0":
                    cislo += "0";
                    break;
                case "1":
                    cislo += "1";
                    break;
                case "2":
                    cislo += "2";
                    break;
                case "3":
                    cislo += "3";
                    break;
                case "4":
                    cislo += "4";
                    break;
                case "5":
                    cislo += "5";
                    break;
                case "6":
                    cislo += "6";
                    break;
                case "7":
                    cislo += "7";
                    break;
                case "8":
                    cislo += "8";
                    break;
                case "9":
                    cislo += "9";
                    break;

                case "KC":
                    _stav = Stav.Operace;
                    operation = Operace.KajuvKoeficient;
                    answer = KajuvKoe();
                    Display = answer;
                    one = answer;
                    two = "";
                    answer = "";
                    break;

                case "+":
                    _stav = Stav.Operace;
                    operation = Operace.Plus;
                    break;
                case "-":
                    _stav = Stav.Operace;
                    operation = Operace.Minus;
                    break;
                case "*":
                    _stav = Stav.Operace;
                    operation = Operace.Nasobeni;
                    break;
                case "/":
                    _stav = Stav.Operace;
                    operation = Operace.Deleni;
                    break;

                case "=":
                    _stav = Stav.Vysledek;
                    answer = FindAnswer();
                    Display = answer;
                    one = answer;
                    two = "";
                    answer = "";
                    break;

                case "+-":
                    if (Display != "")
                    {
                        if (_stav == Stav.PrvniCislo)
                        {
                            var tmp = Convert.ToDouble(one) * -1;
                            one = "" + tmp;
                        }
                        if (_stav == Stav.DruheCislo)
                        {
                            var tmp = Convert.ToDouble(two) * -1;
                            two = "" + tmp;
                        }
                    }
                    break;

                case "CE"://actual
                    if (_stav == Stav.PrvniCislo)
                    {
                        one = "";
                        Display = one;
                    }
                    if (_stav == Stav.DruheCislo)
                    {
                        two = "";
                        Display = two;
                    }

                    break;
                case "C"://all
                    _stav = Stav.PrvniCislo;
                    Display = answer;
                    one = "";
                    two = "";
                    answer = "";
                    break;
                case "<="://one letter
                    if (_stav == Stav.PrvniCislo)
                    {
                        one = one.Substring(0, one.Length - 1);
                        Display = one;
                    }
                    if (_stav == Stav.DruheCislo)
                    {
                        two = one.Substring(0, two.Length - 1);
                        Display = two;
                    }

                    break;

                case "MS":
                    Pamet = Display;
                    break;

                case "MR":
                    if (_stav == Stav.PrvniCislo)
                    {
                        one = Pamet;
                    }
                    if (_stav == Stav.DruheCislo)
                    {
                        two = Pamet;
                    }

                    Display = Pamet;
                    break;

                case "MC":
                    Pamet = "";
                    break;

                default:
                    break;

            }

            switch (_stav)
            {
                case Stav.PrvniCislo:
                    one += cislo;
                    Display = one;
                    break;
                case Stav.DruheCislo:
                    two += cislo;
                    Display = two;
                    break;
                case Stav.Operace:
                    _stav = Stav.DruheCislo;
                    break;
                case Stav.Vysledek:
                    _stav = Stav.PrvniCislo;
                    break;
            }



        }

        private enum Operace
        {
            Plus,
            Minus,
            Nasobeni,
            Deleni,
            KajuvKoeficient
        };

        private enum Stav
        {
            PrvniCislo,
            Operace,
            DruheCislo,
            Vysledek
        };

        private string FindAnswer()
        {
            var o = Convert.ToDouble(one);
            var t = Convert.ToDouble(two);
            double ans = 0;

            switch (operation)
            {
                case Operace.Plus:
                    ans = o + t;
                    break;
                case Operace.Minus:
                    ans = o - t;
                    break;
                case Operace.Nasobeni:
                    ans = o * t;
                    break;
                case Operace.Deleni:
                    ans = o / t;
                    break;

            }

            return "" + ans;
        }

        private string KajuvKoe()
        {
            var o = Convert.ToDouble(one);
            double ans = 0;

            switch(operation)
            {
                case Operace.KajuvKoeficient:
                    ans = o * 0.265;
                    break;
            }


            return "" + ans;
        }

    }


}