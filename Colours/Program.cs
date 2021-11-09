using System;
using System.IO;

namespace Colours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda lemmik värv");
            string värv = Console.ReadLine();

            Console.WriteLine(GetColor(värv));


        }

        public static string[] ReadColor()
        {
            string FilePath = @"C:\Users\opilane\samples\Color.txt";
            string[] datafromfile = File.ReadAllLines(FilePath);
            

            return datafromfile;
        }

        public static string GetColor(string UserInput)
        {
            string[] Color = ReadColor();
            string todayColor = "";
            foreach (string elements in Color)
            {
                if (elements.Contains(UserInput))
                {
                    todayColor = elements;
                }
            }
            return todayColor;
        }
    }
}
