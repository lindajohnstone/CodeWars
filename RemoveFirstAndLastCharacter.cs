using System;
namespace CodeWars
{
    public class RemoveFirstAndLastCharacters
    {
        public static string Remove_char(string s)
        {
            var RemoveFirstCharacter = s.Remove(0, 1);
            return RemoveFirstCharacter.Remove(RemoveFirstCharacter.Length - 1, 1);
        }
    }
    // It 's pretty straightforward. Your goal is to create a function that removes the 
    // first and last characters of a string. You're given one parameter, the original string. 
    // You don't have to worry with strings with less than two characters.
}