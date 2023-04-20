using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Heroes
{
    internal class Warrior : Hero
    {
        public Warrior() : base()
        {
            Health = 200;
            Strength = 50;
            Agility = 90;
            Intellect = 10;
        }

        public override int GetMightiness()
        {
            return Agility / 100;
        }
    }
}
