namespace CodeWars
{
    // Write a function that will return the count of distinct case-insensitive 
    // alphabetic characters and numeric digits that occur more than once in the 
    // input string. The input string can be assumed to contain only alphabets(both 
    // uppercase and lowercase) and numeric digits.

    // Example
    // "abcde" -> 0 # no characters repeats more than once
    // "aabbcde" -> 2 # 'a' and 'b'
    // "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
    // "indivisibility" -> 1 # 'i' occurs six times
    // "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
    // "aA11" -> 2 # 'a' and '1'
    // "ABBA" -> 2 # 'A' and 'B' each occur twice
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            // convert string to lower case
            // loop through & count number of times character appears
            // add number to list
            // return largest number 
            var stringToLower = str.ToLower();
            var listOfCounts = new List<int>();
            // for (var i = 0; i < stringToLower.Length; i++)
            // {
            //     var count = 0;
            //     foreach(var s in stringToLower)
            //     {
            //         if (s == stringToLower[i]) count++;
            //     }
            //     listOfCounts.Add(count);
            // }
            foreach (var s in stringToLower)
            {
                var count = stringToLower.Count(c => c == s);
                listOfCounts.Add(count);
            }
            return listOfCounts.Max();
        }
    }
}