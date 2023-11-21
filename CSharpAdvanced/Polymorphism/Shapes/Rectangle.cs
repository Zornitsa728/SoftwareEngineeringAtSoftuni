using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double hight;

        private double width;

        public Rectangle(double hight, double width)
        {
            this.hight = hight;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return width * hight;
        }

        public override double CalculatePerimeter()
        {
            return ( hight + width ) * 2;
        }

        public override string Draw()
        {
            return base.Draw();
        }
    }
}
