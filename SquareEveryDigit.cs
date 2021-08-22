namespace CodeWars
{
    //     Welcome.In this kata, you are asked to square every digit of a number and concatenate them.

    // For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

    // Note: The function accepts an integer and returns an integer
    using System;

    public class SquareEveryDigit
    {
        public static int SquareDigits(int n)
        {
            // number to string
            // use chars in string 
            // create empty string variable
            // foreach through string:
            // parse char to number
            // square number
            // number to string
            // concat to string
            // parse to number & return
            var numString = n.ToString();
            var newString = "";
            foreach (var number in numString)
            {
                var charToNumber = Int32.Parse(number.ToString());
                var squareNum = charToNumber * charToNumber;
                newString += squareNum.ToString();
            }
            return Int32.Parse(newString);
        }
    }
}