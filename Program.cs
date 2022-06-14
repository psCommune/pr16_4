using System;

namespace pr16_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            string n = Console.ReadLine();
            Calculation.NumberOfCountries(n);
        }
    }
}
