using System;

namespace ConsoleApplication1_csharp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var city = "Tromsø";
            int inhabitants = 79604;
            var message = "well i do not know what else to do now, let's see... ";
            var question = "Do you enjoy football? Like in Alfheim stadium.";
            var ball = "How much do you enjoy football, from 0 to 10?";
            
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
            Console.WriteLine($"Your age is {age}, let's figure out your birth year.");
            
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
            
            Greet(message);
            int ballInterest = AskForInt(ball);
            Console.WriteLine($"You care {ballInterest} out of 10.");
            
        }

        public static void Greet(string message)
        {
            Console.WriteLine(message);
        }

        public static string Ask(string question)
        {
            Console.WriteLine(question + " ");
            return Console.ReadLine();
        }

        public static int AskForInt(string ball)
        {
            var answerStr = Ask(ball);
            return Convert.ToInt32(answerStr);
        }
    }
}