using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    interface IInventoryView
    {
        void Show(List<Product> _products, ViewPosition position);
        void Show(Dictionary<string, List<Product>> _products, ViewPosition position);
    }
}
