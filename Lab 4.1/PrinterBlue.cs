using Lab_4;
using System;

namespace Lab_4_1
{
    class PrinterBlue : Printer
    {
        public void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            base.Print(value);
        }
    }
}