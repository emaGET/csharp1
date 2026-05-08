using System;

namespace ConsoleApplication1_csharp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var city = "Tromsø";
            int inhabitants = 79604;
            
            Console.WriteLine("Hello World, from See Sharp! Remember your glasses");
            Console.WriteLine($"We are {inhabitants} here in {city}.");
            Console.Write("What is your name? ");
            
            string name = Console.ReadLine();
                // Console.WriteLine("Hello " + name + "! Welcome to the optometrist.");
            Console.WriteLine($"Hello {name}! Welcome to the optometrist.");
            
            Console.WriteLine("What is you age?");
            int age = Convert.ToInt32(Console.ReadLine());
            int yearBorn = 2026 - age;
                // Console.WriteLine("Your age is " + age + ", then you were born in " + yearBorn + " if you hadn't a birthday yet.");
            Console.WriteLine($"Your age is {age}, then you were born in {yearBorn}, if you had your birthday already. Otherwise, {yearBorn-1}");
            
                // let's begin with bool!
            
            Console.WriteLine("Have you had your birthday this year? (y/n) ");
            string bdAlready = Console.ReadLine();
            bool hadBday  = bdAlready == "y";
            if (hadBday)
            {
                Console.WriteLine($"well then you must be from {yearBorn}");
            }
            else
            {
                Console.WriteLine($"then you are from {yearBorn-1}");
            }
            
        }
    }
}