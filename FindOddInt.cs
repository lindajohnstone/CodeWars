namespace CodeWars
{
    using System;
    using System.Collections.Generic;
    // Given an array of integers, find the one that appears an odd number of times.

    // There will always be only one integer that appears an odd number of times.
    using System.Linq;
    public class FindOddInt
    {
        public static int find_it(int[] seq)
        {
            var numbers = seq.ToList();
            var count = 0;
            for (var i = 0; i < numbers.Count; i++)
            {
                var numCount = numbers.FindAll(x => x == numbers[i]).Count % 2 == 1;
                count = numbers[i];
            }
            return count;
            //return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
        }
    }
}