using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Day_9_pigLatinTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            string ans2 = "y";
            do
            {
                Console.WriteLine("Enter a line to be translated:");
                string ans = Console.ReadLine();

                Lab_6_Day_9_pigLatinTranslator.Translator brad = new Translator();
                string translatedWord = brad.Translate(ans);
                Console.WriteLine(translatedWord);

                Console.WriteLine("Translate another line? (y/n)");
                ans2 = Console.ReadLine();
            }
            
            while (ans2 == "y");

        



        }
    }
}
