// See https://aka.ms/new-console-template for more information
using Constructor;
BookService bookService = new();
//Constructor, bir sınıfın nesnesi oluşturulduğunda çalışan ve
//genellikle sınıfın üye değişkenlerine başlangıç değerleri atanmasında kullanılan özel bir metotdur.

//Constructorlar, nesne yaratıldığında otomatik olarak çağrılır ve sınıfın her bir örneği için yalnızca bir kez çalıştırılır.
Console.WriteLine("First Book");
Book myBook = new("The Great Gatsby", "F. Scott Fitzgerald", 180, 14.99, new DateTime(1925, 4, 10));
bookService.DisplayBookInfo(myBook);

Console.WriteLine("Second Book");
Book myBook2 = new("Sapiens", "Yuval Noah Harari", 464, 14.99, new DateTime(2011, 6, 15));
bookService.DisplayBookInfo(myBook2);