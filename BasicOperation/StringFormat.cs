using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    internal class StringFormat
    {
        public StringFormat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //using string.Format() method
            string name = "Antor";
            int age = 25;
            string formattedString = string.Format("My name is {0} and I am {1} years old.", name, age);
            Console.WriteLine(formattedString);
            //using string interpolation
            string interpolatedString = $"My name is {name} and I am {age} years old.";
            Console.WriteLine(interpolatedString);

            //formatting numbers
            double pi = -3.14159;
            Console.WriteLine(string.Format("{0:0000}",pi));
            Console.WriteLine(string.Format("{0:0.00}", pi));
            Console.WriteLine(pi.ToString("C",CultureInfo.CreateSpecificCulture("bn-BD")));

            //parsing string to number default value is 0 returned if the parsing fails
            //int number = 1;
            //bool success = int.TryParse(Console.ReadLine(), out number);
            //if (success)
            //{
            //    Console.WriteLine($"You entered the number: {number}");
            //}
            //else
            //{
            //    Console.WriteLine($"Invalid input. value: {number}");
            //}

            //string literal

            string path = @"C:\Users\Antor\Documents\file.txt";
            Console.WriteLine(path);
            path = @"C:\Users\Antor\Documents\ ""file.txt"" ";
            Console.WriteLine(path);

            string firstName = "Antor";
            string lastName = "Hossain";

            Console.WriteLine("Check Equal: {0}",firstName.Equals(lastName));
            Console.WriteLine("Check lengh {0}: {1} ", firstName,firstName.Length);
            Console.WriteLine("Check Contain o: {0}", firstName.Contains('o'));
            for(int i = 0; i<firstName.Length;i++)
            {
                Console.WriteLine($"Character at index {i}: {firstName[i]}");
            }
            Console.WriteLine($"Check is empty: {string.IsNullOrEmpty(firstName)}");
            

        }
    }
}
