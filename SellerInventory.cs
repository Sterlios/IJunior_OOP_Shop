using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class SellerInventory : IInventory
    {
        private List<Product> _products;
        private IInventoryView _view;

        public SellerInventory()
        {
            _view = new InventoryView();
            InitializeProductsList();
        }

        public void Show(ViewPosition position)
        {
            _view.Show(_products, position);
        }

        public void AddProduct(Product product) { }

        private void InitializeProductsList()
        {
            _products = new List<Product>() {
                    new Product("Хлеб", 60),
                    new Product("Топор", 10000),
                    new Product("Лук", 12000),
                    new Product("Стрелы", 500),
                    new Product("Элексир маны", 100),
                    new Product("Элексир здоровья", 100),
                    new Product("Кирка", 400),
                    new Product("Камень бессмертных", 1000),
                    new Product("Знак преступника", 800),
                    new Product("Бронежилет", 8000),
                    new Product("Кольцо", 4000),
                    new Product("Знамя", 7500)
            };
        }
    }
}
