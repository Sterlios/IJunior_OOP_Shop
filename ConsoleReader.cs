using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class ConsoleReader : IReader
    {
        public string GetInputData(string exitText)
        {
            Console.Write($"Введите номер товара для покупки ({exitText} - для выхода): ");
            return Console.ReadLine();
        }
    }
}
