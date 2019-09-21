using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// The 'ConcreateComponent' class
    /// </summary>
    public class Espresso : Beverage
    {
        public override double cost()
        {
            return 1.99;            
        }

        public override string GetDiscription()
        {
            return "에스프레소";
        }
    }
}
