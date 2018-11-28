using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrajinovicMatijaSystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string putanja = @"C:\Users\Učenik\Documents";
            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Datoteke: ");
                foreach (string datoteka in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }


            //kreiranje i brisanje
            string mapa1 = putanja + "\\test";
                if (Directory.Exists(mapa1))
                {

                   
                   Console.WriteLine("  Mapa postoji.");
                Directory.Delete(mapa1);
                }
                else {
                    Console.WriteLine("\nMapa kreirana");
                    Directory.CreateDirectory(mapa1);
                }
                //ispis podmapi

                if (Directory.Exists(mapa1))
                {
                    Console.WriteLine(" \nPodmape");
                    foreach (string datoteka in Directory.GetDirectories(putanja))
                    {
                        Console.WriteLine(datoteka);
                    }
                }
                

            }
            Console.ReadKey();

        }
    }
}
