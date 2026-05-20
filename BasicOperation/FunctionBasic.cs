using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    internal class FunctionBasic
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my function");
        }

        static int factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * factorial(n - 1);
        }

        static void PrintArray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write($"{i} ");

            }
            Console.WriteLine();
        }

        static void DisplayUser(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        static void ResetVariableUsingOut(out int age)
        {
            age = 0;
        }
        static void ResetVariableUsingRef(ref int age)
        {
            age = 0;
        }
        public void functionOperation()
        {
            Console.WriteLine(factorial(5));
            PrintArray(new int[] { 3,5,3,6,2});
            DisplayUser(age: 30, name: "Antor");
            int age = 26;
            ResetVariableUsingRef(ref age);
            Console.WriteLine(age);

        }
    }
}
