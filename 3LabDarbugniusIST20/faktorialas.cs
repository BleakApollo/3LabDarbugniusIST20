using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIILabDarbugniusIST20
{
    internal class faktorialas : sekosSkaiciavimas
    {
        public int faktorialoSkaicius = 0;
        public double galutineFaktorialoReiksme = 1;
        //Konstruktorius kuris yra paveldimas
        public faktorialas(int ivestasSkaicius) : base(ivestasSkaicius)
        {
            faktorialoSkaicius = ivestasSkaicius;
        }

        public void faktorialoSkaiciavimas()
        {
            for (int x = 1; x <= faktorialoSkaicius; x++)
            {
                galutineFaktorialoReiksme = galutineFaktorialoReiksme * x;
            }
        }
    }
}