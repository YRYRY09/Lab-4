using Lab_4;
using System;

namespace Lab_4_1
{
    class PrinterRed : Printer
    {
        public void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            base.Print(value);
        }
    }
}
