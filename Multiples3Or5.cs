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
            if (value <= 0) return 0;
            return Enumerable.Range(0, value - 1).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}