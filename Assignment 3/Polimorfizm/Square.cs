using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    public class Square :Shape
    {
        public int Lenght { get; set; }

        public override double CalculateArea()
        {
            return Math.Pow(Lenght, 2);
        }
    }
}
