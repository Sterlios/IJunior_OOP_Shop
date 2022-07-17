using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    interface IInventory
    {
        void Show(ViewPosition position);
        void AddProduct(Product product);
    }
}
