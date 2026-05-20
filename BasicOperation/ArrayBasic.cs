using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    internal class ArrayBasic
    {
        public ArrayBasic()
        {
            

        }

        public void ArrayInitialization()
        {
            int size = 0;
            Console.Write("Enter array size: ");
            int.TryParse(Console.ReadLine(), out size);

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} index enter value: ", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0} index value: {1}", i, numbers[i]);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine("Value: {0}", number);
            }
        }
        public void printArray(int[] numbers)
        {
            Console.Write("Array: ");
            foreach (int number in numbers)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
        public void shortArray()
        {
            int[] numbers =  { 3, 6, 5,2,8,4 };
            Array.Sort(numbers);
            printArray(numbers);
            Array.Reverse(numbers);
            printArray(numbers);

            int[] sortedNumbers = numbers.OrderBy(n => n).ToArray();
            printArray(sortedNumbers);
            int[] descSortedNumber = numbers.OrderByDescending(n => n).ToArray();
            printArray(descSortedNumber);
        }

        public void arrayOperation()
        {
            int[] numbers = {43,26,46, 12, 9, 34, 56, 78, 90, 11 };
            int position = Array.IndexOf(numbers, 100,0,4);
            Console.WriteLine(position);
            int[] filterNumbers = numbers.Where(n=>n>30).ToArray();
            printArray(filterNumbers);
        }

        public void listOperation()
        {
            List<string> names = new List<string>();
            List<int> numbers = new List<int> { 43, 26, 46, 12, 9, 34, 56, 78, 90, 11 };
            printArray(numbers.ToArray());
            numbers.Add(456);
            numbers.Remove(43);
            numbers.Insert(0, 100);
            numbers.RemoveAt(numbers.Count - 1);
            printArray(numbers.ToArray());

        }

        public void structureOperation()
        {
            Dictionary<string, int> ages = new Dictionary<string, int> { { "antor", 35 } };
            Dictionary<int, string> students = new Dictionary<int, string>();
            students[3] = "Antor";
            students.Add(120, "Jihad");
            students.Add(10, "Rony");
            students.Add(12, "Najmul");
            Console.WriteLine(students[120]);
            students.Remove(12);
            students[10] = "Rony Updated";

            if (students.ContainsKey(3))
            {
                Console.WriteLine("Key 3 exists in the dictionary.");

            }
            else
            {
                Console.WriteLine("Key 3 does not exist in the dictionary.");
            }

            Console.WriteLine(students.Count);

            if(ages.TryGetValue("antor", out int age))
            {
                Console.WriteLine("Antor's age is: {0}", age);
            }

            foreach (var student in students)
            {
                Console.WriteLine("Key: {0}, Value: {1}", student.Key, student.Value);

}
        }
    }
}
