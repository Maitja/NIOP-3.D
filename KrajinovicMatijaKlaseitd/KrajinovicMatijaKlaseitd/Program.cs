using System;
using KrajinovicMatijaKlaseitd.Klase;

namespace KrajinovicMatijaKlaseitd
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo avijon = new Vozilo();

            avijon.setBrojKotaca(6);
            avijon.setLeti(true);
            avijon.setPliva(false);
            avijon.setVozi(true);
            avijon.setVrsta("Cessna");
            avijon.setOznaka("1312");

            

            Vozilo kamijon = new Vozilo(8,false,false,true,"TAM","RI1987AR");

            Console.WriteLine("Vrsta : " + avijon.getVrsta() + "Oznaka :" + avijon.getOznaka() + "\nLeti : " + avijon.getleti() +
                "\nPliva : " + avijon.getPliva() + "\nVozi : " + avijon.getVozi() + "\nBroj kotaca : " + avijon.getBrojKotaca())
                ;

            Console.WriteLine(kamijon.ToString());


            Console.ReadLine();

        }
    }

}
