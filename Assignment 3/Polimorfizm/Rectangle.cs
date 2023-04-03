using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    public class Rectangle:Shape
    {
        public int Lenght { get; set; }
        public int Width { get; set; }
        public override double CalculateArea()
        {
            return Lenght * Width;
        }
    }
}
