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
            string text = _productNumber + ") ";

            for (int i = (int)Math.Log10(_productNumber); i < (int)Math.Log10(ProductsCount); i++)
            {
                text += " ";
            }

            return text;
        }

        private string GetProductName()
        {
            int nameFieldLength = 20;
            string text = "";

            for (int i = 0; i < nameFieldLength; i++)
            {
                text += i < Product.Name.Length ? Product.Name[i].ToString() : ".";
            }

            return text;
        }
    }
}
