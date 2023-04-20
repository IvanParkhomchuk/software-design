using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Inventory
{
    internal class MagicMantle : InventoryDecorator
    {
        public MagicMantle(Hero hero) : base(hero)
        {
            this._hero.Intellect += 10;
        }

        public override int GetMightiness()
        {
            return this._hero.GetMightiness() + 10;
        }
    }
}
