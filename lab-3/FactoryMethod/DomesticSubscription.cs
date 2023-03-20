using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DomesticSubscription : ISubscription
    {
        private int _monthlyFee;
        private int _minSubPeriod;
        private List<string> _channels;

        public DomesticSubscription()
        {
            this._monthlyFee = 30;
            this._minSubPeriod = 1;
            this._channels = new List<string>() { "Channel 1", "Channel 2", "Channel 3" };
        }

        public void GetSubscribtionType()
        {
            Console.WriteLine("\tDomestic subscription.");
            Console.WriteLine($"\n\tCost: {this._monthlyFee}UAH per month.");
            Console.WriteLine($"\tMinimal Subscription period: {this._minSubPeriod} months.");
            Console.WriteLine("\tChannel list: ");

            foreach (var channel in this._channels)
            {
                Console.WriteLine($"\t\t{channel}");
            }
        }
    }
}
