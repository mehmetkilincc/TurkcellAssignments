using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Manager : Employee
    {
        public void Organizes()
        {
            Console.WriteLine("Şirket ile ilgili işleri organize edildi.");
        }
    }
}
