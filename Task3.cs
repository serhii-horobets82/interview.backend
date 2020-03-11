using System;

namespace Backend
{
    public class Task3
    {
        public delegate void MyDelegate(int a, int b);

        public void Execute()
        {
            // Multicast delegate
            MyDelegate myDel = new MyDelegate(AddNumbers);
            myDel += new MyDelegate(MultiplyNumbers);
            myDel(10, 20);
        }

        public void AddNumbers(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine($"Sum = {sum}");
        }

        public void MultiplyNumbers(int x, int y)
        {
            int mul = x * y;
            Console.WriteLine($"Mul = {mul}");
        }
    }
}