using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KrajinovicMatijaKraj.Vozilo;



namespace KrajinovicMatijaKraj
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozil Motocikl = new Vozil();
            Vozil Automobil = new Vozil();

            Console.Write("Broj Kotaca motocikla : ");
            string s = Console.ReadLine();
            Int32.TryParse(s, out int a);
            Motocikl.setbk(a);

            Console.Write("Maksimalna brzina motocikla : ");
            string c = Console.ReadLine();
            Int32.TryParse(c, out int d);
            Motocikl.setmb(d);

            Console.Write("Vrsta motocikla : ");
            string q = Console.ReadLine();
            Motocikl.setVrsta(q);


        Console.Write("\nBroj Kotaca automobila : ");
        string f = Console.ReadLine();
        Int32.TryParse(f, out int g);
        Automobil.setbk(g);

        Console.Write("Maksimalna brzina automobila je 30% veća. ");
            double b;
            b = d * 1.3;
        Automobil.setmb((int)b);

        Console.Write("\nVrsta automobila : ");
        string l = Console.ReadLine();
        Automobil.setVrsta(l);


        Console.WriteLine("\nBroj Kotaca : " + Motocikl.getbk() + 
            "\nMax brzina : " + Motocikl.getmb() + "\nVrsta : " + Motocikl.getVrsta()
                    );

        Console.WriteLine("\nBroj Kotaca : " + Automobil.getbk() + "\nMax brzina : " + Automobil.getmb() 
            +  "\nVrsta : "  + Automobil.getVrsta() );

        Console.ReadKey();




    }
}
}
