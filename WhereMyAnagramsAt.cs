// What is an anagram ? Well, two words are anagrams of each other if they both contain 
// the same letters. For example:

// 'abba' & 'baab' == true

// 'abba' & 'bbaa' == true

// 'abba' & 'abbba' == false

// 'abba' & 'abca' == false
// Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words. You should return an array of all the anagrams or an empty array if there are none. For example:

// anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']

// anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']) => ['carer', 'racer']

// anagrams('laser', ['lazing', 'lazy', 'lacer']) => [] 

// 5kyu - fails 
using System;
using System.Collections.Generic;
namespace CodeWars
{
    public static class WhereMyAnagramsAt
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            var anagrams = new List<string>();
            foreach (var item in words)
            {

                if (item.Length == word.Length)
                {
                    var wordChars = word.ToCharArray();
                    var count = 0;
                    for (var i = 0; i < wordChars.Length; i++)
                    {
                        if (item.Contains(wordChars[i])) count++;
                    }
                    if (count == word.Length) anagrams.Add(item);
                }

            }
            return anagrams;
        }
    }
}