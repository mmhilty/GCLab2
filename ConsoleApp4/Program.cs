using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            //loop while true
            while (true)
            {

                //user input length 
                //user input width 
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
                Console.WriteLine("Enter Length: ");
                string lengthInput = Console.ReadLine();
                Console.WriteLine("Enter Width: ");
                string widthInput = Console.ReadLine();

                double roomLength = Double.Parse(lengthInput);
                double roomWidth = Double.Parse(widthInput);

                //do the stuff to it

                double roomPerimeter = (roomLength * 2) + (roomWidth * 2);
                double roomArea = roomLength * roomWidth;

                //display results

                Console.WriteLine("Area: " + roomArea);
                Console.WriteLine("Perimeter: " + roomPerimeter);

                Console.WriteLine("Continue? (y/n)");
                string contInput = Console.ReadLine();

                if (contInput == "n")
                {
                    break;
                }

                //continue ifelse 



            }
        }
    }
}
