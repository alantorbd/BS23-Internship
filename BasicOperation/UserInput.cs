using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    internal class UserInput
    {
        public UserInput() {
            int age;
            string name;
            Console.Write("Enter your name: ");
            name=  Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your name: {name}\nYour age: {age}"); ;
        }
    }
}
