using System;
namespace CodeWars
{
    public class ReversedWords
    {
        public static string ReverseWords(string str)
        {
            var array = str.Split(" ");
            Array.Reverse(array, 0, array.Length);
            var reversedWords = String.Join(' ', array);
            return reversedWords;
        }
    }
    /*
    Complete the solution so that it reverses all of the words within the string passed in.

    Example:

    "The greatest victory is that which requires no battle" --> 
    "battle no requires which that is victory greatest The"
    */
}