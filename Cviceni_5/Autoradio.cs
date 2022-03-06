using System;
using System.Collections.Generic;

namespace Cviceni_5
{
    class Autoradio
    {
        private double naladenyKmitocet;
        private bool radioZapnuto = false;
        private Dictionary<int,double> vsechnyKmitocty;
        private int total = 0;

        public void zapnoutRadio(bool zapVyp)
        {
            if (zapVyp)
            {
                radioZapnuto = true;
            }
            else
                radioZapnuto = false;
        }

        public void nastavPredvolbu(int cislo, double kmitocet)
        {
            if (total == 0)
            {
                vsechnyKmitocty = new Dictionary<int, double>();
                total++;
                vsechnyKmitocty.Add(cislo, kmitocet);
            }
            else
                vsechnyKmitocty.Add(cislo, kmitocet);
        }

        public void preladNaPredvolbu(int cislo)
        {
            if (vsechnyKmitocty.ContainsKey(cislo))
            {
                naladenyKmitocet = vsechnyKmitocty[cislo];
            }
            else
                throw new Exception("Spatne zaday kmitocet!");
        }

        public override string ToString()
        {
            if (radioZapnuto)
            {
                return String.Format($"Zapnuto: {radioZapnuto}, Naladeny kmitocet: {naladenyKmitocet}");
            }
            else
                return String.Format($"Zapnuto: {radioZapnuto}");
        }
    }
}