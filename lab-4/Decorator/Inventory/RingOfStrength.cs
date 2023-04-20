using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Inventory
{
    internal class RingOfStrength : InventoryDecorator
    {
        public RingOfStrength(Hero hero) : base(hero)
        {
            this._hero.Strength += 5;
        }

        public override int GetMightiness()
        {
            return this._hero.GetMightiness() + 5;
        }
    }
}
