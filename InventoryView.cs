using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class InventoryView : IInventoryView
    {
        public void Show(List<Product> products, ViewPosition position)
        {
            int productNumber = 0;

            foreach (Product product in products)
            {
                position.SetNextLine();
                productNumber++;
                IProductView productView = new SellerProductView(productNumber, product, products.Count);
                productView.Show(position);
            }
        }

        public void Show(Dictionary<string, List<Product>> products, ViewPosition position)
        {
            int productNumber = 0;

            foreach (string productName in products.Keys)
            {
                position.SetNextLine();
                productNumber++;
                IProductView productView = new ClientProductView(productNumber, products[productName][0], products[productName].Count);
                productView.Show(position);
            }
        }
    }
}
