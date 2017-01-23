using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_2
{
    class VirtualPet
    {
        //fields
        private int food;
        private int happiness;
        private int water;

        private string name;
        public string selector;

        //properties
        public int Food
        {
            get { return this.food; }
            set { this.food = value; }
        }
        public int Happiness
        {
            get { return this.happiness; }
            set { this.happiness = value; }
        }
        public int Water
        {
            get { return this.water; }
            set { this.water = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Selector
        {
            get { return this.selector; }
            set { this.selector = value; }
        }
        //constructors
        public VirtualPet()
        {
            this.name = Name;
            this.water = 100;
            this.food = 100;
            this.happiness = 50;
            this.selector = Selector;

        }
        //methods
        public void DisplayInfo()
        {
            Console.WriteLine("Virtual Baby Turtle Simulator");
            Console.WriteLine("\n******************************");
            Console.WriteLine("Current stats for: " + Name);
            Console.WriteLine("food level is: " + Food);
            Console.WriteLine("water level is: " + Water);
            Console.WriteLine("happiness level is: " + Happiness);
            Console.WriteLine("******************************");
        }

        public void Menu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("******************************");
            Console.WriteLine("1. Feed " + Name);
            Console.WriteLine("2. Fill " + Name + "'s water bowl.");
            Console.WriteLine("3. Pet " + Name);
        }
        public void Selection()
        {
            Selector = Console.ReadLine();
            switch (Selector)
            {
                case "1":
                    if (food >= 90)
                    {
                        Console.WriteLine("Too much food. Try something else.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You fed " + Name + ".");
                        Food += 10; Water -= 20; Happiness -= 10;
                        break;
                    }
                case "2":
                    if (water >= 85)
                    {
                        Console.WriteLine("Too much water. Are you trying to drown " + Name + "??! Try something else.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You filled " + Name + "'s water bowl.");
                        Water += 15; Food -= 20; Happiness -= 5;
                        break;
                    }

                case "3":
                    if (happiness >= 80)
                    {
                        Console.WriteLine("Too much playing. " + Name + " is tired. Try something else.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You played with " + Name + " and had a great time.");
                        Happiness += 20; Food -= 10; Water -= 10;
                        break;
                    }

                default:
                    Console.WriteLine("Didn't read the menu? Clumsy fingers? Try again. ");
                    break;
            }
        }
    }
}

