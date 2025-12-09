using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hello," + input
                + " nice to meet you");
            //-------------------------------------------
            Console.WriteLine("How old are you?");
            string ageInput = Console.ReadLine();
            //TODO:calculate birth year of user
            //     and display to console
            //-------------------------------
            //convert string to int
            try
            {
                int age = Int32.Parse(ageInput);
                int birthYear = 2025 - age;
                Console.WriteLine("Oh, " + ageInput +
                    " So you birth year is ");
                //if/else/switch
                /*
                 * Generation X(Gen X): 0 <- 1980
                 * Generation Y(Millennials): 1981 - 1996
                 * Generetion Z(Gen Z): 1997 - 2012
                 * Generetion Alpha: 2013 - Present
                 */
                if (birthYear >= 1965 && birthYear <= 1980)
                    Console.WriteLine("You are from Generetion X.");
                else if (birthYear >= 1981 && birthYear <= 1996)
                    Console.WriteLine("You are from Generetion Y (Millennials).");
                else if (birthYear >= 1997 && birthYear <= 2012)
                    Console.WriteLine("You are from Generetion Z.");
                else 
                    Console.WriteLine("You are from Generetion Alpha.");
            }
            catch (Exception ex) {
                Console.WriteLine("You input wrong number.");
            }
        }
    }
}
