﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage _beverage) : base(_beverage)
        {
        }

        public override double cost()
        {
            return 0.50 + this.beverage.cost();
        }

        public override string GetDiscription()
        {
            return beverage.GetDiscription() + ", Whip";
        }
    }
}
