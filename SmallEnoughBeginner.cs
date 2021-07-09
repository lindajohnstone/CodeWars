using System;

namespace CodeWars
{
    // You will be given an array and a limit value.You must check that all values in the array 
    // or equal to the limit value. If they are, return true. Else, return false.

    // You can assume all values in the array are numbers
    public class SmallEnoughBeginner
    {
        public static bool SmallEnough(int[] a, int limit)
        {
            // var found = Array.FindAll(a, x => x <= limit);
            // if (found.Length == a.Length) return true;
            // return false;
            return Array.TrueForAll(a, x => x <= limit);
        }
    }
}