using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class EducationalSubscription : ISubscription
    {
        private int _monthlyFee;
        private int _minSubPeriod;
        private List<string> _channels;

        public EducationalSubscription()
        {
            this._monthlyFee = 0;
            this._minSubPeriod = 9;
            this._channels = new List<string>() { "Channel 1", "Channel 2", "Channel 3", "Channel 4", "Channel 5", "Channel 6" };
        }

        public void GetSubscribtionType()
        {
            Console.WriteLine("\tEducational subscription.");
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
