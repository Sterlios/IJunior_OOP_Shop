using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Seller : Person
    {
        private Client _client;
        private string _exitText;
        private IReader _reader;

        public Seller(string name, IInventory inventory, ViewPosition position, uint money = 0) : base(name, money, inventory, position)
        {
            _exitText = "выход";
            _reader = new ConsoleReader();
        }

        public bool Serve(Client client)
        {
            _client = client;

            Position.SetNextLine();
            Position.SetNextLine();
            string clientOptionText = _reader.GetInputData(_exitText);

            if (IsExit(clientOptionText))
            {
                return false;
            }

            if (int.TryParse(clientOptionText, out int clientOptionNumber))
            {
                //TODO: Доделать обработку выбора пользователя и передачи товара
            }

            return true;
        }

        private bool IsExit(string option) => option.ToLower() == _exitText.ToLower();
    }
}
