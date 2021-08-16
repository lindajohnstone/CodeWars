using System;

namespace CodeWars
{
    // Digital root is the recursive sum of all the digits in a number.

    // Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced.The input will be a non-negative integer.

    // Examples
    //     16  -->  1 + 6 = 7
    // 942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
    // 132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
    // 493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2
    public class SumOfDigits
    {
        public static int DigitalRoot(long n)
        {
            // split number into single integers
            // add to list
            // sum list
            // check length of list
            // if length more than repeat above steps until length = 1
            var sum = 0;
            do
            {
                if (sum > 0) n = sum;
                var numbersString = n.ToString();
                var numbersChar = numbersString.ToCharArray();
                foreach (var number in numbersChar)
                {
                    sum += Int32.Parse(number.ToString());
                }
            } while (sum.ToString().ToCharArray().Length > 1);
            return sum;
        }
    }
}