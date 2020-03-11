using System;

namespace Backend
{
    public class Task1
    {

        public void Execute()
        {
            Boxing();
            Unboxing();
        }

        public void Boxing()
        {
            Console.WriteLine("Boxing");
            int num = 123;
            Object obj = num;
            Console.WriteLine($"num = {num}, {num.GetType()}");
            Console.WriteLine($"obj = {obj}, {obj.GetType()}");
        }

        public void Unboxing()
        {
            Console.WriteLine("Unboxing");
            Object obj = 123;
            int num = (int) obj;
            Console.WriteLine($"num = {num}, {num.GetType()}");
            Console.WriteLine($"obj = {obj}, {obj.GetType()}");
        }
    }
}