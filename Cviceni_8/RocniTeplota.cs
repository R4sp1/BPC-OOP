using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cviceni_8
{

    public class RocniTeplota
    {

        private double rok;
        private List<double> mesicniTeploty;

        public RocniTeplota(double rok, List<double> mesicniTeploty)
        {
            this.rok = rok;
            this.mesicniTeploty = new List<double>();
            this.mesicniTeploty = mesicniTeploty;
        }
        public int pocet()
        {
            return mesicniTeploty.Count;
        }


        public double Rok
        {
            get { return rok; }
            set { rok = value; }
        }

        public List<double> MesicniTeploty
        {
            get => mesicniTeploty;
            set => mesicniTeploty = value;
        }

        private double maxTeplota;
        private double minTeplota;
        private double prumRocniTeplota;

        public double MaxTeplota
        {
            get
            {
                maxTeplota = MesicniTeploty[0];
                foreach (double teplota in MesicniTeploty)
                {
                    if (teplota > maxTeplota)
                    {
                        maxTeplota = teplota;
                    }
                }
                return maxTeplota;
            }
        }


        public double MinTeplota
        {
            get
            {
                minTeplota = MesicniTeploty[0];
                foreach (double teplota in MesicniTeploty)
                {
                    if (teplota < minTeplota)
                    {
                        minTeplota = teplota;
                    }
                }
                return minTeplota;
            }
        }

        public double PrumRocniTeplota
        {
            get
            {
                prumRocniTeplota = MesicniTeploty.Average();
                return prumRocniTeplota;
            }
        }
    }
}