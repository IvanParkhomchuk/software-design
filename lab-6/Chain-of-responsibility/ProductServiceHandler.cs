﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    internal class ProductServiceHandler : UserSupportHandlerBase
    {
        public override string Handle()
        {
            Console.Write("Is your problem product?\nyes - 1\nno - 2\n");
            int UserChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (UserChoice == 1)
            {
                return "The product problem is solved!";
            }

            return base.Handle();
        }
    }
}
