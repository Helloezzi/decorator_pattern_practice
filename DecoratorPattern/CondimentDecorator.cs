using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;
        public CondimentDecorator(Beverage _beverage)
        {
            this.beverage = _beverage;
        }

        public override double cost()
        {
            return beverage.cost();
        }
    }
}
