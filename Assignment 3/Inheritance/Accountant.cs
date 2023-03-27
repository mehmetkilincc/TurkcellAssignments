using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Bir sınıf sadece bir sınıftan kalıtım alabilir.
    public class Accountant : Employee
    {
        public void CalculateTax()
        {
            Console.WriteLine("Vergi hesaplama işlemi gerçekleşti.");
        }
        public void Invoice()
        {
            Console.WriteLine("Fatura Kesme işlemi gerçekleşti.");
        }

        public void ManageFinances()
        {
            Console.WriteLine("Finansman yönetildi.");
        }
    }
}
