using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Person
    {
        private string _name;
        private uint _money;
        public IInventory Inventory { get; private set; }
        public ViewPosition Position { get; private set; }
        private ViewPosition _defaultPosition;

        public Person(string name, uint money, IInventory inventory, ViewPosition position)
        {
            _name = name;
            _money = money;
            Inventory = inventory;
            Position = position;
            _defaultPosition = position.ToCopy();
        }

        public void SetDefaultViewPosition()
        {
            Position = _defaultPosition.ToCopy();
        }

        public void Showinfo()
        {
            Position.SetCursorPosition();
            Console.WriteLine(_name);
            Position.SetNextLine();
            Console.WriteLine("Денег: " + _money);
            Position.SetNextLine();
            Inventory.Show(Position);
        }
    }
}
