﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    public abstract class Beverage
    {
        public abstract string GetDiscription();

        public abstract double cost();
    }


}
