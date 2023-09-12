using System;

namespace Mod_2_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число: ");
            int n = int.Parse(Console.ReadLine());

            bool isEven = n % 2 == 0;
            if (isEven)
            {
                Console.WriteLine($" Число {n} является четным.");
            }
            else
            {
                Console.WriteLine($" Число {n} не является четным.");
            }


            bool end7 = n % 10 == 7;
            if (end7)
            {
                Console.WriteLine($" Число {n} оканчивается цифрой 7.");
            }
            else
            {
                Console.WriteLine($" Число {n} не оканчивается цифрой 7.");
            }
        }
    }
}
