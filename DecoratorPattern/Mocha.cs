using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    class Mocha : CondimentDecorator
    {
        public Mocha(Beverage _beverage) : base(_beverage)
        {
        }
        
        public override double cost()
        {
            return 0.20 + cost();
        }

        public override string GetDiscription()
        {
            return beverage.GetDiscription() + ", Mocha";
        }
    }
}
