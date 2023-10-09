using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Tire
    {
        private int age;

        private double pressure;

        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }
        public int Age { get { return age; } set { this.age = value; } }

        public double Pressure { get { return pressure; } set { this.pressure = value; } }
    }
}
