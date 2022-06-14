using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace pr16_4
{
    class Calculation
    {
        static Queue<Countries> myQueue = new Queue<Countries>();
        public static void NumberOfCountries(string n)
        {
            StreamReader sr = new StreamReader("Countries.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] lines = line.Split(' ');
                if (sort(lines[0], lines[1], n) == true)
                {

                    Countries title = new Countries();
                    title.countrie = lines[0];
                    title.population = int.Parse(lines[1]);
                    myQueue.Enqueue(title);
                }
                else
                {
                    Console.WriteLine("Вводить можно только цифры");
                    return;
                }
            }
            sr.Close();
            IEnumerable<Countries> countries = myQueue.OrderBy(x => x.countrie.Length).ThenBy(x => x.countrie).Where(x => x.population > int.Parse(n));
            foreach (var item in countries)
            {
                Console.WriteLine($"{item.countrie} {item.population}");
            }

        }
        public static bool sort(string title, string population, string n)
        {
            for (int i = 0; i < title.Length; i++)
            {
                if (char.IsDigit(title[i]))
                {
                    return false;
                }
            }
            for (int i = 0; i < population.Length; i++)
            {
                if (char.IsLetter(population[i]))
                {
                    return false;
                }
            }
            try
            {
                int.Parse(n);
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}
