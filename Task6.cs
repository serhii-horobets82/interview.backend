using System;
using System.Linq;

namespace Backend
{
    public class Task6
    {
        public void Execute()
        {
            string FizzBuzz(int x) => // Local function, defined as an expression-bodied method
                (x % 3 == 0, x % 5 == 0) switch
                { // Tuple definition  
                    (true, true) => "FizzBuzz", // Pattern-matching on the tuple values
                    (true, _) => "Fizz", // Discard (_) is used to omit
                    (_, true) => "Buzz", // the values we don't care about
                    _ => x.ToString()
                };

            Enumerable.Range(1, 100) // Make a range of numbers from 1 to 100
                .Select(FizzBuzz).ToList() // Map each number to a corresponding FizzBuzz value
                .ForEach(Console.WriteLine); // Print the result to the console  
        }

    }
}