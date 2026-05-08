using System;

namespace ConsoleApplication1_csharp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            
            //console.WriteLine("Ayo World");
            //let's remember the capital letters, or we get error 10:
            //   Program.cs(10, 13): [CS0103] The name 'console' does not exist in the current context
            
            // Console.WriteLine('Hi world');
            // also does not work because we need " and not '
            
            Console.Write("Congrats!");
            Console.WriteLine("");
            // Console.WriteLine("First lines of code achieved!");
            Console.WriteLine("First lines of code achieved!");
            Console.WriteLine("And this is the second (more like the fifth) line");

            // end of part 1

            Console.WriteLine("Hello World, from See Sharp! Remember your glasses");
            Console.Write("What is your name? ");
            
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "! Welcome to the optometrist.");
            Console.WriteLine("What is you age?");
            int age = Convert.ToInt32(Console.ReadLine());
            int yearBorn = 2026 - age;
            // Console.WriteLine("Your age is " + age + ", then you were born in " + yearBorn + " if you hadn't a birthday yet.");
            Console.WriteLine($"Your age is {age}, then you were born in {yearBorn}, if you hadn't a birthday yet. Otherwise, {yearBorn-1}");
            
        }
    }
}