using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    public class WebSite : ISubscribe
    {
        public ISubscription CreateSubscribe(string subType)
        {
            Console.WriteLine("\tWebsite Subscribe");

            if (subType == "Domestic")
            {
                return new DomesticSubscription();
            } else if (subType == "Educational")
            {
                return new EducationalSubscription();
            } else if (subType == "Premium")
            {
                return new PremiumSubscription();
            } else
            {
                return null;
            }
        }
    }
}
