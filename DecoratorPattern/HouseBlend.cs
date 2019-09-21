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
    public class HouseBlend : Beverage
    {
        public override double cost()
        {
            return 0.89;
        }

        public override string GetDiscription()
        {
            return "하우스블렌드";
        }
    }
}
