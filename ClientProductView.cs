using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class ClientProductView : TextCreator, IProductView
    {
        public ClientProductView(int productNumber, Product product, int productsCount) : base(productNumber, product, productsCount) { }

        public void Show(ViewPosition position)
        {
            string productText = GetProductText();
            productText += " Количество: " + ProductsCount;
            Console.SetCursorPosition(position.X, position.Y);
            Console.WriteLine(productText);
        }
    }
}
