using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Practice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is employee or not");
            bool isemployee = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("You entered these values: " + name + ", Age = " + age + "");
            Console.WriteLine("You entered these values: Name = {0}, Age = {1}", name, age);
            Console.WriteLine($"You entered these values: Name = {name}, Age = {age}");

            //  ===========================================================
            Console.WriteLine("Please enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 0 && num2 > 0)
            {
                Console.WriteLine($"Add result = { num1 + num2}");
            }
            else
            {
                Console.WriteLine("Either num1 or num2 is less than 0");
            }
        }
    }
}
