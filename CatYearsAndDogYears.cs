// I have a cat and a dog.

// I got them at the same time as kitten/puppy. That was humanYears years ago.

// Return their respective ages now as [humanYears, catYears, dogYears]

// NOTES:

// humanYears >= 1
// humanYears are whole numbers only
// Cat Years
// 15 cat years for first year
// +9 cat years for second year
// +4 cat years for each year after that
// Dog Years
// 15 dog years for first year
// +9 dog years for second year
// +5 dog years for each year after that
namespace  CodeWars
{
    public class CatYearsAndDogYears
    {
        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            // Your code here!
            var catYears = 15 + (humanYears >= 2 ? 9 + 4 * (humanYears - 2) : 0);
            var dogYears = 15 + (humanYears >= 2 ? 9 + 5 * (humanYears - 2) : 0);

            return new int[] { humanYears, catYears, dogYears };
        }
    }
}