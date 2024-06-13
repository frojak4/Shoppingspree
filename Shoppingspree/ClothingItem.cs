using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingspree
{
    internal class ClothingItem : InventoryItem
    {
        private string _size;
        private string _color;


        

        public ClothingItem(string name, int amount, int price, string size, string color) : base(name, amount, price)
        {
            _size = size;
            _color = color;
        }
    }
}
