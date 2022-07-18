using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class TextCreator
    {
        private int _productNumber;
        public Product Product { get; private set; }
        public int ProductsCount { get; private set; }

        public TextCreator(int productNumber, Product product, int productsCount)
        {
            _productNumber = productNumber;
            Product = product;
            ProductsCount = productsCount;
        }

        public string GetProductText()
        {
            string text = GetNumberText();
            text += GetProductName(); 
            return text;
        }

        private string GetNumberText()
        {
            string seperator = ") ";
            string numberText = _productNumber + seperator;
            string maxNumberText = ProductsCount + seperator;
            string text = numberText.PadRight(maxNumberText.Length);
            return text;
        }

        private string GetProductName()
        {
            int nameFieldLength = 20;
            string text = Product.Name.PadRight(nameFieldLength, '.');
            return text;
        }
    }
}
