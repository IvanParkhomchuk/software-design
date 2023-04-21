using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class BigMacMenuFacade
    {
        private BigMac _bigMac;
        private Fries _fries;
        private Nuggets _nuggets;
        private Cola _cola;
        private Packaging _packaging;
        private Napkins _napkins;
        private Price _price;

        public BigMacMenuFacade()
        {
            this._bigMac = new BigMac();
            this._fries = new Fries();
            this._nuggets = new Nuggets();
            this._cola = new Cola();
            this._packaging = new Packaging();
            this._napkins = new Napkins();
            this._price = new Price();
        }

        public void CreateMenu()
        {
            Console.WriteLine(this._bigMac.Add());
            Console.WriteLine(this._fries.Add());
            Console.WriteLine(this._nuggets.Add());
            Console.WriteLine(this._cola.Add());
            Console.WriteLine(this._packaging.Add());
            Console.WriteLine(this._napkins.Add());
            Console.WriteLine(this._price.Add());
        }
    }
}
