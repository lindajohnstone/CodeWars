// Given a random non-negative number, you have to return the digits of this number 
// within an array in reverse order.

// Example:

// 348597 => [7,9,5,8,4,3]
using System;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{
    class Digitizer
    {
        public static long[] Digitize(long n)
        {
            var digits = new List<long>();
            var numbers = n.ToString().ToCharArray();
            foreach (var number in numbers)
            {
                digits.Add(Int64.Parse(number.ToString()));
            }
            digits.Reverse();
            return digits.ToArray();
            // return n.ToString()
            //   .Reverse()
            //   .Select(t => Convert.ToInt64(t.ToString()))
            //   .ToArray();
        }
    }
}