using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilość wyrazów ciągu Fibonacciego do wypisania: ");
            Int32.TryParse(Console.ReadLine(), out int n);

            Console.WriteLine($"{n} pierwszych wyrazów ciągu Fibonacciego:  ");

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{Fibonacci.GetElement(i)} ");
            }

        }
    }
}
