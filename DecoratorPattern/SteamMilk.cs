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
    public class SteamMilk : CondimentDecorator
    {
        public SteamMilk(Beverage _beverage) : base(_beverage)
        {

        }

        public override double cost()
        {
            return 0.45 + this.beverage.cost();
        }

        public override string GetDiscription()
        {
            return beverage.GetDiscription() + ", SteamMilk";
        }
    }
}
