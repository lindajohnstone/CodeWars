namespace CodeWars
{
    // Return an array containing the numbers from 1 to N, where N is the parametered value.

    // Replace certain values however if any of the following conditions are met:

    // If the value is a multiple of 3: use the value "Fizz" instead
    // If the value is a multiple of 5: use the value "Buzz" instead
    // If the value is a multiple of 3 & 5: use the value "FizzBuzz" instead
    // N will never be less than 1.

    // Method calling example:

    // string[] result = FizzBuzz.GetFizzBuzzArray(3); // => [ "1", "2", "Fizz" ]
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FizzBuzz
    {
        public static string[] GetFizzBuzzArray(int n)
        {
            var fizzBuzz = new List<string>();
            for (var num = 1; num <= n; num++)
            {
                if (num % 15 == 0) fizzBuzz.Add("FizzBuzz");
                else if (num % 3 == 0) fizzBuzz.Add("Fizz");
                else if (num % 5 == 0) fizzBuzz.Add("Buzz");
                else fizzBuzz.Add(num.ToString());
            }
            return fizzBuzz.ToArray();
            // return n > 0
            //     ? Enumerable.Range(1, n)
            //         .Select(x => x % 15 == 0 ? "FizzBuzz" : x % 3 == 0 ? "Fizz" : x % 5 == 0 ? "Buzz" : $"{x}")
            //         .ToArray()); // throws errors
        }
    }
}
