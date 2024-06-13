using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingspree
{
    internal class InventoryItem : ISellable
    {
        private string Name;
        private int Amount;
        private int Price;

        public InventoryItem(string name, int amount, int price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }

        public double calculatePrice()
        {
            double taxpercent = 0.3;
            double newPrice = Price + (Price *  taxpercent);

            return newPrice;
        }

        public string getName()
        {
            return Name;
        }

        public int getPrice()
        {
            return Price;
        }

        public int getAmount()
        {
            return Amount;
        }

        public void reduceAmount()
        {
            Amount -= 1;
        }
    }
}
