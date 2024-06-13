using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingspree
{
    internal class App
    {
        private User currentUser = new User(1000, new List<ISellable>());

        List<ISellable> itemList = new List<ISellable>()
        {
            new ClothingItem("Hettegenser", 15, 200, "Medium", "Gray"),
            new ElectronicItem("Nintendo Switch", 5, 300, 12, 3600)
        };

        public void Run()
        {

           

            while (true) {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Shop");
                Console.WriteLine("2. Summary");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Shop();
                        break;
                    case "2":
                        Summary();
                        break;
                }


            }

        }

        private void Shop()
        {
            Console.Clear();
            Console.WriteLine($"(You have {currentUser.getMoney()} money.)");
            Console.WriteLine("Shop: ");
            for (int i = 0; i < itemList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {itemList[i].getName()}, price: {itemList[i].getPrice()}, amount: {itemList[i].getAmount()}");
            }

            int userInput = Convert.ToInt32(Console.ReadLine());
            userInput--;

            Console.WriteLine($"With taxes this item costs {itemList[userInput].calculatePrice()}. Do you still want it?");
            Console.WriteLine($"(You have {currentUser.getMoney()} money.)");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            string userInput2 = Console.ReadLine();

            switch (userInput2)
            {
                case "1":
                    if (canAfford(itemList[userInput])){
                        currentUser.addItem(itemList[userInput]);
                        itemList[userInput].reduceAmount();
                        Console.WriteLine($"You bought {itemList[userInput].getName()} for {itemList[userInput].getPrice()} money");
                        Console.ReadKey(true);
                    }
                    break;
                case "2":
                    Console.WriteLine("You left the shop cause you broke..");
                    Console.ReadKey(true);
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    Console.ReadKey(true);
                    break;
                    
            }
            
        }

        private void Summary()
        {
            List<ISellable> itemliste = currentUser.getItems();
            Console.Clear();
            Console.WriteLine($"Money: {currentUser.getMoney()}");
            Console.WriteLine("Items:");

            foreach (var item in itemliste)
            {
                Console.WriteLine($"{item.getName()}");
            }

            Console.ReadKey();
        }

        private bool canAfford(ISellable item)
        {
            if (item.getPrice() <= currentUser.getMoney())
            {
                currentUser.reduceMoney(item.getPrice());
                return true;
            }
            else
            {
                Console.WriteLine("You cannot afford this item");
                Console.ReadKey(true);
                return false; 

            }
        }
    }
}
