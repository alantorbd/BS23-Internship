using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    internal class FlowControl
    {
        public FlowControl()
        {
            //if (else if) else // == <= >= < > != || && 
            // check if a number is positive, negative or zero
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("a is positive number");
            }
            else if (number < 0)
            {
                Console.WriteLine("a is negative number");
            }
            else
            {
                Console.WriteLine("a is equal to zero");
            }

            // check if a person is a child, adult or senior citizen based on their age
            int age = 35;
            if (age > 0 && age < 18)
            {
                Console.WriteLine("You are a child");

            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult");
            }
            else if (age >= 65)
            {
                Console.WriteLine("You are a senior citizen");
            }
            else
            {
                Console.WriteLine("You are not born yet");
            }


            //check the day of the week based on a number (1-7)
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            // check if a number is even or odd
            number = 35;
            string result = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine($"{number} is an {result} number");
        }
    }
}
