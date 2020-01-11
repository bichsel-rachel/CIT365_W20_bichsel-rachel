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
            var name = "Rachel";
            Console.WriteLine($"Hello, my name is {name}.");

            var location = "Utah";
            Console.WriteLine($"I'm from {location}.");

            DateTime currentDate = DateTime.Today;

            Console.WriteLine(currentDate.ToString("d"));

            var dec25 = new DateTime(2019, 12, 25);
            int dec25DayOfYear = dec25.DayOfYear;

            int currentDayOfYear = DateTime.Now.DayOfYear;
            int daysToChristmas = dec25DayOfYear - currentDayOfYear + 1;
            Console.WriteLine($"Days until Christmas: {daysToChristmas}");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("What is the width in feet?");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("What is the height in feet?");
            heightString = Console.ReadLine();

            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.ReadKey();
        }
    }
}
