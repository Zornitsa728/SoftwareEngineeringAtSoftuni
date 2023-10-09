using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Cargo
    {
        private string type;

        private int weight;

        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
        public string Type { get { return type; } set { type = value; } }

        public int Weight { get { return weight; } set { weight = value; } }
    }
}
