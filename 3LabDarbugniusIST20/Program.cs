namespace IIILabDarbugniusIST20
{
    internal class reiksmiuAtspausdinimas
    {
        //Sukuriami objektai, atspausdinami atsakymai ir suskaiciuojamas programos vygdimo laikas.
        static void Main(string[] args)
        {
            int ivestasSkaicius;
            //Ivedamas skaicius
            Console.WriteLine("Iveskite norima skaiciu kuris bus nauduojamas suskaiciuoti seka ir rasti faktoriala: ");
            ivestasSkaicius = Convert.ToInt32(Console.ReadLine());

            DateTime pradzia = DateTime.Now;
            Thread.Sleep(5000);
            DateTime pabaiga = DateTime.Now;

            sekosSkaiciavimas obj = new sekosSkaiciavimas(ivestasSkaicius);
            obj.sekosSkaiciavimoFunkcija();
            Console.WriteLine("Galutinis sekos skaicius: " + obj.sk2 + ", o ciklu kiekis: " + obj.kiekis);

            faktorialas obj2 = new faktorialas(ivestasSkaicius);
            obj2.faktorialoSkaiciavimas();
            Console.WriteLine(ivestasSkaicius + "! = " + obj2.galutineFaktorialoReiksme);

            TimeSpan laikoTarpsnis = (pabaiga - pradzia);
            Console.WriteLine("Praeito laiko tarpsnis matuojamas sekundemis: " + laikoTarpsnis.TotalSeconds + " s");
            Console.ReadLine();
        }
    }
}