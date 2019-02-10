using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using klaseAndObjekti.Klase;

namespace klaseAndObjekti
{
    class Program
    {
        static void Main(string[] args)
        {

            Vozilo avijon = new Vozilo();
            Vozilo buba = new Vozilo();
            string k;

            int j = 0;
            int i = 0;
            do
            {
                Console.WriteLine("Broj Kotaca : ");
                string s = Console.ReadLine();
                Int32.TryParse(s, out int a);
                buba.setBrojKotaca(a);

                Console.WriteLine("Vrsta : ");
                string q = Console.ReadLine();
                buba.setVrsta(q);

                Console.WriteLine("Oznaka : ");
                string w = Console.ReadLine();
                buba.setOznaka(w);

                Console.WriteLine("Vozi(true ili false) : ");
                string b = Console.ReadLine();
                bool e = bool.Parse(b);
                buba.setVozi(e);

                Console.WriteLine("Pliva(true ili false) : ");
                string t = Console.ReadLine();
                bool z = bool.Parse(t);
                buba.setPliva(z);

                Console.WriteLine("Pliva(true ili false) : ");
                string f = Console.ReadLine();
                bool g = bool.Parse(f);
                buba.setLeti(g);

                Console.WriteLine("\nBroj Kotaca : " + buba.getBrojKotaca() + "\nVrsta : " + buba.getVrsta() + "\nOznaka : " + buba.getOznaka()
                    + "\nVozi : " + buba.getVozi() + "\nPliva : " + buba.getPliva() + "\nLeti : " + buba.getLeti());

                Console.WriteLine("\nAko želite ponovno upišite doslovno bilo što,a ako ne želite upišite ne  : \n");
                string c = Console.ReadLine();
                int m = 0;
                if (c == "ne" || c == "NE" || c == "Ne" || c == "n" || c == "N")
                { m++; }
                j = m;
                

            } while (j < 1);


            /*Console.WriteLine(s); 

            avijon.setBrojKotaca(6);
            avijon.setLeti(true);
            avijon.setPliva(false);
            avijon.setVozi(true);
            avijon.setVrsta("Cessna");
            avijon.setOznaka("1312");

            Vozilo kamijon = new Vozilo(8, false, false, true, "TAM", "RI1987AR");

            Console.WriteLine("Vrsta: " + avijon.getVrsta() + " Oznaka: " +
                avijon.getOznaka() + "\nLeti: " + avijon.getLeti() + "\nPlovi: "+ avijon.getPliva()
                + "\nVozi: " + avijon.getVozi() + "\nBroj kotača: "+avijon.getBrojKotaca() + "\n");
            
            Console.WriteLine(kamijon.ToString());

            Console.WriteLine(avijon.ispis());*/

            Console.ReadLine();
        }
    }

    
}
