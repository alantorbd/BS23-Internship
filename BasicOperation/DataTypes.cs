using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{

    class DataTypes
    {
        public void RunTask()
        {
            //int count, age, number;
            int count = 10,
                age = 24,
                number = 39;
            Console.Write("count: {0} age: {1} number: {2}\n", count,age, number);
            Console.WriteLine($"Max int value: {int.MaxValue}");

            long distance = 1234567890L;
            Console.WriteLine($"distance: {distance}" );
            Console.WriteLine($"Max long value: {long.MaxValue}");

            float gpa = 3.5F;
            Console.WriteLine($"gpa: {gpa}");

            double pi = 3.14159D;
            Console.WriteLine($"pi: {pi}");

            decimal price = 19.99M;
            Console.WriteLine($"price: {price}");

            string name = "Al Antor";
            Console.WriteLine($"Name: {name}");

            char grade = 'A';
            Console.WriteLine($"Grade: {grade}");

            bool isMale = true;
            Console.WriteLine($"isMale: {isMale}");


            // converting string to number

            string textAge = "35";
            age = Convert.ToInt32(textAge);
            Console.WriteLine($"Convert int: {age}");

            string textDistance = "1234567890";
            distance = Convert.ToInt64(textDistance);

            pi = Convert.ToDouble("3.14159");
            gpa = Convert.ToSingle("3.5");
            price = Convert.ToDecimal("19.99");

            //operations
            Console.WriteLine($"current age: {age}");

            age++;
            Console.WriteLine($"age++: {++age}");

            age--;
            Console.WriteLine($"age--: {age}");

            age += 5;
            Console.WriteLine($"age += 5: {age}");

            age /= 3;
            Console.WriteLine($"age /= 3: {age}");

            age *= 3;
            double result = age / 5f;
            Console.WriteLine($"result: {result}");

            grade += (char)1;
            Console.WriteLine($"update grade: {grade}");


            //reminder
            int remainder = age % 4;
            Console.WriteLine($"age: {age} % 4 = {remainder}");

            //var variable
            var city = "Dhaka";
            var population = 20000000L;
            var area = 306.4;
            Console.WriteLine($"City: {city} Population: {population} Area: {area}");

            const double gravity = 9.81;
            Console.WriteLine($"gravity: {gravity}");
        }
  
    }
}
