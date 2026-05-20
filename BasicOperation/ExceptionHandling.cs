using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    internal class ExceptionHandling
    {
        public static void TestExceptionHandling()
        {
            Console.Write("Enter a number: ");

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input is not a valid number.");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Input number is too large or too small.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Input cannot be null.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error Ocurre: {e.Message}");
            }
        }
    }
}
