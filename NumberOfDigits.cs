namespace CodeWars
{
    // Determine the total number of digits in the integer(n>=0) given as input to the function.
    // For example, 9 is a single digit, 66 has 2 digits and 128685 has 6 digits.Be careful to avoid 
    // overflows/underflows.

    // All inputs will be valid.
    public class NumberOfDigits
    {
        public static int Digits(ulong n)
        {
            var digits = 1;
            while (n >= 10) { // if the number is less than 10, stop looping
                n /= 10;
                digits++;
            }
            return digits;
        }
    }
}