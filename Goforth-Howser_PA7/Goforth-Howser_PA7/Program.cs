using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goforth_Howser_PA7
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            double buildTime = 0;

            Console.WriteLine("\t\tGozer's Destroyers!\n");

            List<Robot> robotsBuilt = new List<Robot>();

            while (buildTime < 12)
            {
                counter++;

                Console.Write("\nEnter Robot {0} ID: ", counter);
                string idName = Console.ReadLine();

                Console.Write("Enter number of batteries: ");
                int batteries;
                while (int.TryParse(Console.ReadLine(), out batteries) != true)
                {
                    ConsoleColor color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Invalid value. Try again: ");
                    Console.ForegroundColor = color;
                }

                Console.Write("Enter number of components: ");
                int components;
                while (int.TryParse(Console.ReadLine(), out components) != true)
                {
                    ConsoleColor color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Invalid value. Try again: ");
                    Console.ForegroundColor = color;
                }

                Console.Write("How many hours to buld Robot {0}: ", counter);
                double hours;
                while (double.TryParse(Console.ReadLine(), out hours) != true)
                {
                    ConsoleColor color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Invalid value. Try again: ");
                    Console.ForegroundColor = color;
                }
                buildTime += hours;

                robotsBuilt.Add(new Robot(idName, batteries, components, hours));
            }

            Console.Write("\nLow-power robot summary:\n");
            foreach (Robot thing in robotsBuilt)
            {
                if (thing.IsHighPower() != true)
                {
                    ConsoleColor color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    thing.PrintDetails();
                    Console.ForegroundColor = color;
                }
            }

            Console.Write("\nHigh-power robot summary:\n");
            foreach (Robot thing in robotsBuilt)
            {
                if (thing.IsHighPower() == true)
                {
                    ConsoleColor color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    thing.PrintDetails();
                    Console.ForegroundColor = color;
                }
            }

            double cost = 0;
            foreach (Robot thing in robotsBuilt)
            {
                cost += thing.GetCost();
            }
            Console.Write("\nTotal cost is {0:C}", cost);


            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();

        }


    }
}
