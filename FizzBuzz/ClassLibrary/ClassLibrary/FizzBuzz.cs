using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FizzBuzz
    {
        public void FizzBuzzMenu(int i)
        {
            switch (i)
            {
                case 1:
                    FizzBuzz clasic = new FizzBuzz();
                    clasic.FizzBuzzClasic();
                    break;
                case 2:
                    FizzBuzz variation = new FizzBuzz();
                    variation.FizzBuzzVariation();
                    break;
                default:
                    Console.WriteLine("Podano nieodpowiedni znak.");
                    break;
            }
        }
        public void FizzBuzzClasic()
        {
            Console.WriteLine("Proszę podać zakres liczb dla gry.");
            var zakres = Convert.ToInt16(Console.ReadLine());
            zakres++;
            string[] tabFB = new string[zakres];

            for (int i = 1; i < zakres; i++)
            {
                tabFB[i] = Convert.ToString(i);
                if (i % 3 == 0)
                    tabFB[i] = "Fizz";
                if (i % 5 == 0)
                    tabFB[i] = "Buzz";
                if ((i % 3 == 0) && (i % 5 == 0))
                    tabFB[i] = "Fizz Buzz";
            }
            for (int i = 1; i < zakres; i++)
                Console.Write("{0} ", tabFB[i]);  
        }

        public void FizzBuzzVariation()
        {
            Console.WriteLine("Proszę podać zakres liczb dla gry.");
            var zakres = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Proszę podać jakie liczby maja zostać zamienione.");
            int liczba1 = Convert.ToInt16(Console.ReadLine());
            int liczba2 = Convert.ToInt16(Console.ReadLine());
            int liczba3 = Convert.ToInt16(Console.ReadLine());

            zakres++;
            string[] tabFB = new string[zakres];

            for (int i = 1; i < zakres; i++)
            {
                tabFB[i] = Convert.ToString(i);
                if (i % (liczba1) == 0)
                    tabFB[i] = "Fizz";
                if (i % (liczba2) == 0)
                    tabFB[i] = "Buzz";
                if (i % (liczba3) == 0)
                    tabFB[i] = "Pop";
                if ((i % (liczba1) == 0) && (i % (liczba2) == 0) && (i % (liczba3) == 0))
                    tabFB[i] = "Fizz Buzz Pop";
            }
            for (int i = 1; i < zakres; i++)
                Console.Write("{0} ", tabFB[i]);            
        }
    }
}