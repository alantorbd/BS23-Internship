using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{


    public class Book
    {
        public string Title { get; set; }

        public Book(string title)
        {
            Title = title;
        }
    }

    public class BookList
    {
        private List<Book> _books = new List<Book>();

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public Book this[int index]
        {
            get { return _books[index]; }
            set { _books[index] = value; }
        }
    }
    public interface IMyInterface
    {
        void MyMethod();
    }
    public class Box<T>
    {
        public T Content { get;  set; }
    }

    public class  ClassConstrint<T> where T: class
    {
        
    }

    public class StructConstraint<T> where T : struct
    {
    }

    public class NewConstraint<T> where T : new()
    {
    }

    public class  BaseConstraint<T> where T: Box<int>
    {
        
    }

    public class  InterfaceConstraint<T> where T: IMyInterface
    {
        
    }

    public class MultipleConstraints<T> where T : class, new()
    {
    }
    internal class GenericsOperations
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public static void TestGenericsOperations()
        {
            BookList myLibrary = new BookList();

            myLibrary.Add(new Book("Himu"));
            myLibrary.Add(new Book("Gitanjali"));

            Book firstBook = myLibrary[0];
            Console.WriteLine(firstBook.Title);

            myLibrary[1] = new Book("Shesher Kobita");
            Console.WriteLine(myLibrary[1].Title);

            var intBox = new Box<int>();
            var stringBox = new Box<string>();

            int a = 5, b = 10;
            Swap<int>(ref a, ref b);
            Console.WriteLine($"After swap: a = {a}, b = {b}");


            var test1 = new ClassConstrint<string>();
            var test2= new StructConstraint <int> ();


        }
    }
}
