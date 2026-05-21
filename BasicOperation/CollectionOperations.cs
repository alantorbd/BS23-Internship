using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    internal class CollectionOperations
    {
        public static void TestCollectionOperations()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            foreach(int number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();
            // Multidimensional array
            string[,] chessBoard = new string[2, 2]{
               { "Rook", "Knight" },

                { "Bishop", "Queen" },
            };

            Console.WriteLine(chessBoard[0,1]);

            // Jagged array
            int[][] daysInMonths = new int[2][];
            daysInMonths[0] = new int[31];
            daysInMonths[1] = new int[28];

            daysInMonths[0][0] = 1;
            Console.WriteLine($"Days {daysInMonths[0][0]}");

            // List

            var names = new List<string>() { "antor", "jihad" };
            names.Add("Sikta");
            names.RemoveAll(x => x.Contains("i") );

            // Dictionary
            var studentGrades = new Dictionary<string, int>();
            studentGrades.Add("Alice", 85);
            studentGrades.Add("Bob", 92);
            studentGrades.Remove("Alice");
            Console.WriteLine($"Dictionnary: {studentGrades["Bob"]}");

            //HashSet
            var uniqueNumbers = new HashSet<int>() { 1, 2, 3, 4, 5 };
            uniqueNumbers.Add(1);
            uniqueNumbers.Remove(2);

            // Queue
            var arc = new Queue<string>();
            arc.Enqueue("First");
            arc.Enqueue("Second");
            var deleteItem = arc.Dequeue();
            Console.WriteLine($"Queue Front: {arc.Peek()}, delete = {deleteItem}");

            //Stack
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            var stackDelete = stack.Pop();
            Console.WriteLine($"Stack top: {stack.Peek()}");




        }
    }
}
