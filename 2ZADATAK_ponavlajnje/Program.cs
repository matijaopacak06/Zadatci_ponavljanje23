using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ZADATAK_ponavlajnje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi niz znakova.");
            string input = Console.ReadLine();
            string output = input.Replace(' ', '_');
            Console.WriteLine(":" + output);
            Console.ReadKey(); 
        }
    }
}
