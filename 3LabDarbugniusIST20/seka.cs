using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIILabDarbugniusIST20
{
    public class sekosSkaiciavimas
    {
        public double sekosSkaicius = 1;
        public double sk2 = 2;
        public int kiekis = 0;
        public int ivestasSkaiciusConstruct = 0;
        
        //Konstruktorius. 
        //beprasme eilute
        public sekosSkaiciavimas(int ivestasSkaicius)
        {
            sekosSkaicius = ivestasSkaicius;
        }

        // Atliekamas skaiciavimas
        public void sekosSkaiciavimoFunkcija()
        {
            while (sk2 <= Math.Pow(10, 15))
            {
                kiekis++;
                double skLaikinas = sekosSkaicius * sk2;
                sekosSkaicius = sk2;
                sk2 = skLaikinas;
                Console.WriteLine(sk2);
            }
        }
    }
}

