using System;
using System.IO;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda tähtkuju");
            string tahtkuju = Console.ReadLine();

            Console.WriteLine(GetHoroscope(tahtkuju));


        }

        public static string[] ReadHoroscope()
        {
            string FilePath = @"C:\Users\opilane\samples\horoscope.txt";
            string[] datafromfile = File.ReadAllLines(FilePath);
            Console.WriteLine(datafromfile.Length);

            return datafromfile;
        }

        public static string GetHoroscope(string UserInput)
        {
            string[] horoscope = ReadHoroscope();
            string todayHoroscope = "";
            foreach(string elements in horoscope)
            {
                if (elements.Contains(UserInput))
                {
                    todayHoroscope = elements;
                }
            }
            return todayHoroscope;
        }


    }
}
