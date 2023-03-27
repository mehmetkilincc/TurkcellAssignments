using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class WebDeveloper : SoftwareDeveloper
    {
        public string WebFramework { get; set; }
        public void DevelopWebsite()
        {
            Console.WriteLine("Web sitesi geliştirildi.");
        }
    }
}
