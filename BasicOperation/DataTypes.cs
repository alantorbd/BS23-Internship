using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    internal class DataTypes
    {
        public void RunTask() {
            int x, y, z;
            int a = 10,
                b = 20,
                c = 30;
            int age = 10;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            
            long bignumber = 23453434L;
            Console.WriteLine(bignumber);
            Console.WriteLine(long.MaxValue);

            double bigdouble = 35.353D;
            Console.WriteLine(bigdouble);
            Console.WriteLine(double.MaxValue);

            float bigfloat = 35.35F;
            Console.WriteLine(bigfloat);
            Console.WriteLine(float.MaxValue);

            decimal bigdecimal = 356.64M;
            Console.WriteLine(bigdecimal);
            Console.WriteLine(decimal.MaxValue);

            //Character type datatypes

            string name = "Antor";
            char grade = 'A';
            Console.WriteLine(name);
            Console.WriteLine(grade);
        }
    }
}
