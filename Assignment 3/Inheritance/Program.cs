using System.Threading.Channels;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Inheritance (Kalıtım)
             * Bir sınıftan yeni bir sınıf oluşturma işlemine kalıtım denir.
             * Kalıtım kullanımında hangi sınıftan kalıtım alınıyorsa o sınıfa ait metotlar ve özellikler yeni sınıfta da olur.
             * İstenirse yeni sınıfa farklı özellik ve metotlar eklenebilir. 
             */

            Accountant accountant = new Accountant();
            accountant.Name = "Ahmet";
            accountant.Surname = "Haril";
            accountant.Age = 38;
            accountant.Experience = 7;
            accountant.Salary = 12000;
            accountant.ManageFinances();


            WebDeveloper webDeveloper = new WebDeveloper();
            webDeveloper.Name = "Mehmet";
            webDeveloper.Surname = "Kılnç";
            webDeveloper.Age = 24;
            webDeveloper.Experience = 1;
            webDeveloper.Salary = 20000;
            webDeveloper.WebFramework="Asp.Net Core";
            webDeveloper.DevelopWebsite();
        }
    }
}