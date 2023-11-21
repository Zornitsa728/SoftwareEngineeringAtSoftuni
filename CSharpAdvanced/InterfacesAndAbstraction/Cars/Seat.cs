using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get ; set; }
        public string Color { get ; set ; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Color} ");
            sb.Append($"{this.GetType().Name} ");
            sb.AppendLine($"{Model} ");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());

            return sb.ToString().Trim();
        }
    }
}
