using System.Reflection.Metadata;
using System.Security.AccessControl;

namespace ObjectAndClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Sınıf (class) bir nesnenin şeklini tanımlayan bir şablondur. Sınıf, verileri ve bu verileri işleyecek kodu içerir.
            //Sınıf nesneleri oluşturmak için temel özellikleri içerir. Nesne(object) ‘ler sınıfların birer örneğidirler.

            Participiant participiant = new Participiant();
            participiant.Name = "Mehmet";
            participiant.Surname = "Kılınç";
            participiant.Age = 24;
            participiant.Mail = "Mehmetkilinc@gmail.com";

            Console.WriteLine($"İlk katılımcı {participiant.Name} {participiant.Surname}'dir.");
            Console.WriteLine($"Katılımcının yaşı {participiant.Age} ve mail adresi {participiant.Mail}'dir.");
        }
    }

    public class Participiant
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
    }
}