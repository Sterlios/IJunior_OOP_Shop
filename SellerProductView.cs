using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class SellerProductView : TextCreator, IProductView
    {
        public SellerProductView(int productNumber, Product product, int productsCount) : base(productNumber, product, productsCount) { }

        public void Show(ViewPosition position)
        {
            string productText = GetProductText();
            productText += " Цена: " + Product.Price;
            Console.SetCursorPosition(position.X, position.Y);
            Console.WriteLine(productText);
        }
    }
}
