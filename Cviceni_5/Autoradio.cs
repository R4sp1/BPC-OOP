using System;
using System.Collections.Generic;

namespace Cviceni_5
{
    class Autoradio
    {
        private double naladenyKmitocet;
        private bool radioZapnuto = false;
        private Dictionary<int, double> vsechnyKmitocty;
        private int total = 0;

        public void prepinacRadio(bool radioState)
        {
            if (radioState)
            {
                radioZapnuto = true;
            }
            else
                radioZapnuto = false;
        }

        public void nastavPredvolbu(int num, double freq)
        {
            if (total == 0)
            {
                vsechnyKmitocty = new Dictionary<int, double>();
                total++;
                vsechnyKmitocty.Add(num, freq);
            }
            else
                vsechnyKmitocty.Add(num, freq);
        }

        public void preladNaPredvolbu(int num)
        {
            //if (vsechnyKmitocty.ContainsKey(num))
            try
            {
                naladenyKmitocet = vsechnyKmitocty[num];
            }
            catch(Exception e)
            {
                //throw new Exception($"Predvolba {num} neni nastavena!", e);
                //new ArgumentOutOfRangeException();
                Console.WriteLine(e);
            } 
        }

        public override string ToString()
        {
            if (radioZapnuto)
            {
                return String.Format($"Radio zapnuto\t Naladeny kmitocet: {naladenyKmitocet} fm");
            }
            else
                return String.Format($"Radio vypnuto!");
        }
    }
}