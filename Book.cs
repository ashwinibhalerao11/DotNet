using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.CrudOperations
{
    public class Book
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
    public class BookCRUD
    {
        private List<Book> Books;
        public BookCRUD()
        {
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void UpdateBook(Book book)
        {
            foreach (Book b in Books)
            {
                if (b.Id == book.Id)
                {
                    b.Name = book.Name;
                    b.Price = book.Price;
                }
            }
        }
        public void DeleteBook(int id)
        {
            foreach (Book b in Books)
            {
                if (b.Id == id)
                {
                    Books.Remove(b);
                    break;
                }
            }
        }
        public List<Book> GetBooks()
        {
            return Books;
        }

        public Book GetBookById(int id)
        {
            Book book = new Book();
            foreach (Book b in Books)
            {
                if (b.Id == id)
                {
                    book = b;
                    break;
                }
            }
            return book;
        }
    }

    public class Program1
    {

        static void Main(string[] args)
        {
            BookCRUD b1 = new BookCRUD();
            int op = 0;
            do
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Update Book");
                Console.WriteLine("3. Delete Book");
                Console.WriteLine("4. View All");
                Console.WriteLine("5. View by Id");
                Console.WriteLine("6. Price less than 1000");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Book B = new Book();
                        Console.WriteLine("Enter Id");
                        B.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        B.Name = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        B.Price = Convert.ToInt32(Console.ReadLine());
                        b1.AddBook(B);
                        break;
                    case 2:
                        Book B1 = new Book();
                        Console.WriteLine("Enter Id");
                        B1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        B1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        B1.Price = Convert.ToInt32(Console.ReadLine());
                        b1.UpdateBook(B1);
                        break;
                    case 3:
                        Console.WriteLine("Enter Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        b1.DeleteBook(id);
                        break;
                    case 4:
                        List<Book> list = b1.GetBooks();
                        Console.WriteLine("Id \t Name \t Price");
                        foreach (Book item in list)
                        {
                            Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Price}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter Id");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        Book item2 = b1.GetBookById(id2);
                        Console.WriteLine("Id \t Name \t Price");
                        Console.WriteLine($"{item2.Id} \t {item2.Name} \t {item2.Price}");
                        break;
                    default:
                        Console.WriteLine("No option available");
                        break;
                }

                Console.WriteLine("Do you want to continue ");
                op = Convert.ToInt32(Console.ReadLine());
            }
            while (op == 1);
        }
    }
}

