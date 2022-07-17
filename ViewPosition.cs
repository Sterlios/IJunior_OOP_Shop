using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class ViewPosition
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public ViewPosition(int x, int y)
        {
            X = x;
            Y = y;
            SetCursorPosition();
        }

        public void SetNextLine()
        {
            Y++;
            SetCursorPosition();
        }

        public void SetCursorPosition()
        {
            Console.SetCursorPosition(X, Y);
        }

        public ViewPosition ToCopy()
        {
            return new ViewPosition(X, Y);
        }
    }
}
