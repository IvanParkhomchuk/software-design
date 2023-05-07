using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    internal class TechnicalSupportHandler : UserSupportHandlerBase
    {
        public override string Handle()
        {
            Console.Write("Is your problem technical?\nyes - 1\nno - 2\n");
            int UserChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (UserChoice == 1)
            {
                return "The technical problem is solved!";
            }

            return base.Handle();
        }
    }
}
