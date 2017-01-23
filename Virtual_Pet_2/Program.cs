using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello and welcome to your own virtual pet baby turtle. \n\n\n");
            Console.WriteLine("Instructions: Provide your baby turtle with food, water, and activity. \nIf any of the stats hit 0, you lose. \n\n");
            Console.WriteLine("Please enter your pets name: ");


            VirtualPet babyTurtle = new VirtualPet();
            babyTurtle.Name = Console.ReadLine();
            Console.Clear();
            bool turtleBool = true;
            while (turtleBool == true)
            {
                //Console.Clear();
                babyTurtle.DisplayInfo();
                Console.WriteLine();
                babyTurtle.Menu();
                babyTurtle.Selection();
                if (babyTurtle.Food <= 0 || babyTurtle.Water <= 0 || babyTurtle.Happiness <= 0)
                {
                    turtleBool = false;
                    break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            Console.Clear();

            Console.WriteLine("              " + babyTurtle.Name + " has been re-homed due to neglect. \n                               Game Over");

            Console.ReadKey();

        }
    }
}
