using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class MobileApp : ISubscribe
    {
        public ISubscription CreateSubscribe(string subType)
        {
            Console.WriteLine("\tMobileApp Subscribe");

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
