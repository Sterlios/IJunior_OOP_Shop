using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class ClientInventory : IInventory
    {
        private Dictionary<string, List<Product>> _products;
        private IInventoryView _view;

        public ClientInventory()
        {
            _products = new Dictionary<string, List<Product>>();
            _view = new InventoryView();
        }

        public void Show(ViewPosition position)
        {
            _view.Show(_products, position);
        }

        public void AddProduct(Product product)
        {
            if (_products.ContainsKey(product.Name))
            {
                _products[product.Name].Add(product);
            }
            else
            {
                _products.Add(product.Name, new List<Product> { product });
            }
        }
    }
}
