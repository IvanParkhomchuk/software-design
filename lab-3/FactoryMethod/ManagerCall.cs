using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ManagerCall : ISubscribe
    {
        public ISubscription CreateSubscribe(string subType)
        {
            Console.WriteLine("\tManagerCall Subscribe");

            if (subType == "Domestic")
            {
                return new DomesticSubscription();
            }
            else if (subType == "Educational")
            {
                return new EducationalSubscription();
            }
            else if (subType == "Premium")
            {
                return new PremiumSubscription();
            }
            else
            {
                return null;
            }
        }
    }
}
