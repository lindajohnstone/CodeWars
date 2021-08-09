using System.Collections;
using System.Collections.Generic;

namespace CodeWars
{
    // Return the number(count) of vowels in the given string.

    // We will consider a, e, i, o, u as vowels for this Kata (but not y).

    // The input string will only consist of lower case letters and/or spaces.
    public static class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            string vowels = "aeiou";
            int vowelCount = 0;
            var charArray = str.ToCharArray();
            var queue = new Queue<char>(charArray);
            
            while(queue.TryDequeue(out var currentChar)) //returns false if queue is empty, true if there's a char to dequeue
            {
                if (vowels.Contains(currentChar)) vowelCount++;
            }

            return vowelCount;
        }
    }
}