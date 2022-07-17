using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Product
    {
        public string Name { get; private set; }
        public uint Price { get; private set; }

        public Product(string name, uint price)
        {
            Name = name;
            Price = price;
        }
    }
}
