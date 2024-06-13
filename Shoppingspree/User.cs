using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingspree
{
    internal class User
    {
        private int _money;
        private List<ISellable> _items;

        public User(int money, List<ISellable> items)
        {
            _money = money;
            _items = items;
        }

        public int getMoney()
        {
            return _money;
        }

        public List<ISellable> getItems() 
        {
            return _items;
        }

        public void addItem(ISellable item)
        {
            _items.Add(item);
        }

        public void reduceMoney(double amount)
        {
            _money -= (int)amount;
        }
    }
}
