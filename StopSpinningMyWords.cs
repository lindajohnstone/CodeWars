namespace CodeWars
{
    // Write a function that takes in a string of one or more words, and returns the same string, 
    // but with all five or more letter words reversed(like the name of this kata).

    // Strings passed in will consist of only letters and spaces.
    // Spaces will be included only when more than one word is present.
    // Examples:

    // spinWords("Hey fellow warriors") => "Hey wollef sroirraw"
    // spinWords("This is a test") => "This is a test"
    // spinWords("This is another test") => "This is rehtona test"
    using System.Collections.Generic;
    using System.Linq;
    using System;

    public class StopSpinningMyWords
    {
        public static string SpinWords(string sentence)
        {
            var words = sentence.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5) words[i] = ReverseIt(words[i]);
            }
            return String.Join(" ", words);
            // return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
        }

        private static string ReverseIt(string input)
        {
            var reversedInput = "";
            for (int offset = 0; offset < input.Length; offset++)
            {
                var piece = input.Substring(offset, 1);
                reversedInput = String.Concat(piece, reversedInput);
            }
            return reversedInput;
        }
    }    
}