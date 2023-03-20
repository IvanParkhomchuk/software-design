using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISubscribe subscribe = new WebSite();

            ISubscription subscribtion = subscribe.CreateSubscribe("Premium");

            subscribtion.GetSubscribtionType();

            Console.ReadLine();
        }
    }
}
