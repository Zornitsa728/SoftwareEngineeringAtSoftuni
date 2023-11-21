using BorderControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models
{
    internal class Pet : IBirthable
    {
        public Pet(string name, DateOnly birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; private set; }
        public DateOnly Birthdate { get; private set; }
    }
}
