using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            FunctionBasic.WelcomeMessage();

            FunctionBasic functionBasic = new FunctionBasic();
            functionBasic.functionOperation();
            Console.ReadLine();



        }
    }
}
