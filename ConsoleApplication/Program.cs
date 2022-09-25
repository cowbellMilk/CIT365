// My First Visual Studio C# Application
// BYUI CIT 365 - Fall 2022 - Brother Thayne

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare variables
            string myName = "Glory Ozonuwe";
            string myLocation = "Nigeria";


            // Output name and location
            Console.WriteLine($"Hello, My name is {myName}.");
            Console.WriteLine($"I am from {myLocation}.");

            // Output current date
            Console.WriteLine($"Today's date is {DateTime.Now.ToString("ddd, dd MMM yyy")}.");

            // Countdown to Christmas
            DateTime xmas = new DateTime(DateTime.Today.Year, 12, 25);
            double daysUntilChristmas = xmas.Subtract(DateTime.Today).TotalDays;
            Console.WriteLine($"It is {daysUntilChristmas} days until Christmas this year! :)");

            // Textbook 2.1 program
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Input Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Input Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            // Pause and exit
            Console.WriteLine("Press any key to exit :)");
            Console.ReadKey();
        }
    }
}
