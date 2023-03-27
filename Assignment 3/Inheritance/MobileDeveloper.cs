using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class MobileDeveloper : SoftwareDeveloper
    {
        public string MobileOS { get; set; }
        public void DevelopMobileApp()
        {
            Console.WriteLine("Mobil uygulama geliştirildi.");
        }
    }
}
