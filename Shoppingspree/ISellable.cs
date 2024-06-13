using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingspree
{
    internal interface ISellable
    {
        double calculatePrice();
        string getName();

        int getPrice();
        int getAmount();

        void reduceAmount();
    }
}
