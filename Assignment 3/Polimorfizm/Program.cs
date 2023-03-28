// See https://aka.ms/new-console-template for more information
using Polimorfizm;

//Çok Biçimlilik (Polymorphism): C# programlama dilinde nesnelerin,kalıtım (inheritance) veya
//arayüz (interface) kavramları kullanılarak farklı şekillerde kullanılabilmesine izin verir.

Shape shape1 = new Square() { Lenght = 5 };

Shape shape2 = new Rectangle() { Lenght = 5, Width = 3 };

Console.WriteLine($"Şekil 1 alanı : {shape1.CalculateArea()}");
Console.WriteLine($"Şekil 2 alanı : {shape2.CalculateArea()}");

