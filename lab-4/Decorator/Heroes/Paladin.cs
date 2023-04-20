using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Heroes
{
    internal class Paladin : Hero
    {
        public Paladin() : base()
        {
            Health = 550;
            Strength = 120;
            Agility = 30;
            Intellect = 30;
        }

        public override int GetMightiness()
        {
            return Strength / 100;
        }
    }
}
