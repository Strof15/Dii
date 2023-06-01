using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

          
            List<nobeldiajakClass> lista = new List<nobeldiajakClass>();

            try
            {
                File.ReadAllLines("nobel.csv").Skip(1).ToList().ForEach(x => lista.Add(new nobeldiajakClass(x)));
                Console.WriteLine(" jo a beolvasas");
            }
            catch (Exception)
            {
                Console.WriteLine("nem jo a beolvasas");
               
            }

            //4. feladat
            Console.WriteLine(lista.Select(n => n).Where(n => n.Tipus.Contains("irodalmi")));

            //6. feladat

            Console.WriteLine();








        }
    }
}
