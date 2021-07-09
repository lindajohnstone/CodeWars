using System;
using System.Linq;

namespace CodeWars
{
    //     Given a sequence of numbers, find the largest pair sum in the sequence.

    // For example

    // [10, 14, 2, 23, 19] -->  42 (= 23 + 19)
    // [99, 2, 2, 23, 19]  --> 122 (= 99 + 23)
    // Input sequence contains minimum two elements and every element is an integer.
    public class LargestPairSumInArray
    {
        public static int LargestPairSum(int[] numbers)
        {
            var arrayToList = numbers.ToList();
            var largest = arrayToList.Max();
            arrayToList.Remove(largest);
            var nextLargest = arrayToList.Max(); 
            return largest + nextLargest;
            // Array.Sort(numbers);
            // return numbers[^1] + numbers[^2];
            // return numbers.OrderByDescending(x=>x).Take(2).Sum();
        }
    }
}