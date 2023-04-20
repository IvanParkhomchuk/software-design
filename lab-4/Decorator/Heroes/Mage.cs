using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Heroes
{
    internal class Mage : Hero
    {
        public Mage() : base()
        {
            Health = 100;
            Strength = 10;
            Agility = 20;
            Intellect = 95;
        }

        public override int GetMightiness()
        {
            return Intellect / 100;
        }
    }
}
