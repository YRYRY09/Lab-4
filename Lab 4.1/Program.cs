﻿using System;

namespace Lab_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterRed printerRed = new PrinterRed();
            printerRed.Print("First line");

            PrinterBlue printerBlue = new PrinterBlue();
            printerBlue.Print("Second line");

            Console.ReadKey();
        }
    }
}