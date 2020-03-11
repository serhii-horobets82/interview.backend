using System;

namespace Backend
{
    public class Task5
    {
        public void Execute()
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers Between 1 To 100: ");
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
        }
    }
}