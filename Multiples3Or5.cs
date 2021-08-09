using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    //     If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

    // Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

    // Note: If the number is a multiple of both 3 and 5, only count it once.Also, if a number is negative, return 0(for languages that do have them)
    public static class Multiples3Or5
    {
        public static int Solution(int value)
        {
            var multiplesList = new List<int>();
            // loop through find numbers that are multiples of 3 that are below value
            // %3 
            for (var i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0 && !multiplesList.Contains(i))
                    multiplesList.Add(i);
            }
            IEnumerable<int> multiples =
                (IEnumerable<int>)Enumerable.Range(1, value).Select(x => x % 3 == 0 || x % 5 == 0);
            foreach (var multiple in multiples)
            {
                if (!multiplesList.Contains(multiple)) multiplesList.Add(multiple);
            }
            // use || - or to combine loops
            // google how to determine if number is already in list

            // loop through find numbers that are multiples of 5 that are below value
            // no duplicates
            // add multiples together
            // return sum
            var sum = multiplesList.Sum();
            return sum;
        }
    }
}