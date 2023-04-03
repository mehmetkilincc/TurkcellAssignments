using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class BookService
    {
        public void DisplayBookInfo(Book book)
        {
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Page Count: {book.PageCount}");
            Console.WriteLine($"Price:  {book.Price.ToString("C")}");
            Console.WriteLine($"Publish Date:  {book.PublishDate.ToShortDateString()}");
        }
    }
}
