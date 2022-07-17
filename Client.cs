using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Client : Person
    {
        public Client(string name, IInventory inventory, ViewPosition position, uint money = 0) : base(name, money, inventory, position)
        {

        }

        public string EnterOption()
        {
            return Console.ReadLine();
        }
    }
}
