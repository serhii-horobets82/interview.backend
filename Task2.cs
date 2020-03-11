using System;
using System.Collections.Generic;

namespace Backend
{
    delegate void Printer();

    public class Task2
    {
        public void Execute()
        {
            List<Printer> printers = new List<Printer>();
            for (int i = 0; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var printer in printers)
            {
                printer();
            }
        }
    }
}