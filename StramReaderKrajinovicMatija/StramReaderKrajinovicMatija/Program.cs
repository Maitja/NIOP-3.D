using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StramReaderKrajinovicMatija
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Učenik\source\repos\StramReaderKrajinovicMatija\haha.txt");
            
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            
            sr.Close();
            Console.ReadKey();
        }
    }
}
