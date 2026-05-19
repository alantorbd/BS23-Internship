using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    internal class Loops
    {
        public Loops()
        {
            //print numbers from 1 to 5 using for loop
            Console.WriteLine("For loop: ");
            for (int count = 1; count <= 5; count++)
            {
                Console.WriteLine($"Count: {count}");
            }

            //print numbers from 1 to 5 using while loop
            Console.WriteLine("\nwhile loop");
            int number = 1;
            while (number <= 5)
            {
                Console.WriteLine($"Number: {number}");
                number++;
            }

            //execution of the loop body at least once useing do-while loop
            Console.WriteLine("\ndo-while loop");
            int checkValue = 1;
            do
            {
                Console.WriteLine($"Value: {checkValue}");
                checkValue++;
            } while (checkValue < 1);

            //print the names of students using foreach loop
            Console.WriteLine("\nforeach loop");
            string[] studentNames = { "Antor", "Jihad", "Abdur" };
            foreach (string name in studentNames)
            {
                Console.WriteLine($"Student: {name}");
            }
        }
    }
}
