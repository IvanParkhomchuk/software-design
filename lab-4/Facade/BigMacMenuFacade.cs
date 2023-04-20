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
            this._bigMac.Add();
            this._fries.Add();
            this._nuggets.Add();
            this._cola.Add();
            this._packaging.Add();
            this._napkins.Add();
            this._price.Add();
        }
    }
}
