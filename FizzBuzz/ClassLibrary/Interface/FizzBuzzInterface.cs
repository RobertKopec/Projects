using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class FizzBuzzInterface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosze wybrać wersję gry:");
            Console.WriteLine("1 - Wersja klasyczna.");
            Console.WriteLine("2 - Wariancja.");

            var i = Convert.ToInt16(Console.ReadLine());

            FizzBuzz menu = new FizzBuzz();
            menu.FizzBuzzMenu(i);
        }
    }
}
