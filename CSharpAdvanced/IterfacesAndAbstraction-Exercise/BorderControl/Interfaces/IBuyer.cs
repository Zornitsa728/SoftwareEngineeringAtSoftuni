﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Interfaces
{
    public interface IBuyer : INameble
    {
        public int Food { get;}

        public void BuyFood();
    }
}
