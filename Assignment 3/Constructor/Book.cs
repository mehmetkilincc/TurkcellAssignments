using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }
        public DateTime PublishDate { get; set; }

        //Constructorlar, sınıfın ismiyle aynı olan metotlardır ve geri dönüş tipi belirtmezler. 
        public Book(string title, string author, int pageCount, double price, DateTime publishDate)
        {
            this.Title = title;
            this.Author = author;
            this.PageCount = pageCount;
            this.Price = price;
            this.PublishDate= publishDate;
        }
    }
}
