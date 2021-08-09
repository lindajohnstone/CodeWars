namespace CodeWars
{
    // Trolls are attacking your comment section!

    // A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

    // Your task is to write a function that takes a string and return a new string with all vowels removed.

    // For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

    // Note: for this kata y isn't considered a vowel.
    using System;

    public static class DisemvowellTrolls
    {
        public static string Disemvowel(string str)
        {
            // let code know what a vowel is 
            //var newStringNoVowels = "";
            var vowels = new string[] { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U"}; 
            // changed to a string array as string.replace(char, char) does not accept an empty char
            // check if vowels exist in string
            foreach (var vowel in vowels)
            {
                str = str.Replace(vowel, "");
            }
            // remove all vowels
            return str;
        }
    }

}