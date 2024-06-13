using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingspree
{
    internal class ElectronicItem : InventoryItem
    {

        private int _insurance;
        private int _watt;

        public ElectronicItem(string name, int amount, int price, int insurance, int watt) : base(name, amount, price)
        {
            _insurance = insurance;
            _watt = watt;
        }
    }
}
