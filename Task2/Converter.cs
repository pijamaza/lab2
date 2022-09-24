using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Converter
    {
        private double usdtouah;
        private double uahtousd;
        private double eurotouah;
        private double uahtoeuro;
        private double rublstouah;
        private double uahtorubls;
        private double uah;

        public double Usdtouah
        {
            set
            {
                usdtouah = value;
            }
            get
            {
                return usdtouah;
            }
        }
        public double Eurotouah
        {
            set
            {
                eurotouah = value;
            }
            get
            {
                return eurotouah;
            }
        }
        public double Rublstouah
        {
            set
            {
                rublstouah = value;
            }
            get
            {
                return rublstouah;
            }
        }
        public double Uahtousd
        {
            set
            {
                uahtousd = value;
            }
            get
            {
                return uahtousd;
            }
        }
        public double Uahtoeuro
        {
            set
            {
                uahtoeuro = value;
            }
            get
            {
                return uahtoeuro;
            }
        }
        public double Uahtorubls
        {
            set
            {
                uahtorubls = value;
            }
            get
            {
                return uahtorubls;
            }
        }
        public double Uah
        {
            set
            {
                uah = value;
            }
            get
            {
                return uah;
            }
        }


    }
}
