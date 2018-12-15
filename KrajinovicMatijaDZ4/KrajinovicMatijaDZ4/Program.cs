﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrajinovicMatijaDZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite putanju direktorija: ");
            string putanja = Console.ReadLine();
            
            DirectoryInfo diIzvor = new DirectoryInfo(putanja);
            
            Console.WriteLine("\n-- Poddirektoriji:");
            foreach (DirectoryInfo di in diIzvor.GetDirectories())
            {
             Console.WriteLine("{0}\t{1}\t{2}",di.Name, di.CreationTime, di.LastAccessTime);
            }
            
            Console.WriteLine("\n-- Datoteke:");
            foreach (FileInfo fi in diIzvor.GetFiles())
            {
                Console.WriteLine("{0}\t{1}\t{2}",fi.Name, fi.CreationTime, fi.LastAccessTime);

            }
            Console.ReadKey();
        }
    }
}
