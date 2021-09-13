using System;
namespace SampleApp
{
    class Books
    {
     
            public string BookTitle { get; set; }
            public string BookAuthor { get; set; }
            public int BookPrice { get; set; }
            public int BookId { get; set; }

        }
        class Booksdemo
        {
            static void Main(string[] args)
            {
                Books book = new Books();
                Console.WriteLine("Enter the BookTitle");
                book.BookTitle = Console.ReadLine();
                Console.WriteLine("enter the author name");
                book.BookAuthor = Console.ReadLine();

                Console.WriteLine($"The name of the book is{book.BookTitle} of {book.BookAuthor}");
                //Console.WriteLine("of" + BookAuthor);
                //Console.WriteLine("price of" + BookPrice);

            }
        }
}
