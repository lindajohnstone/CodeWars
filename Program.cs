using System;
using System.Collections.Generic;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Multiples3Or5.Solution(10)); // 23
            Console.WriteLine(Multiples3Or5.Solution(20)); // 78
            Console.WriteLine(Multiples3Or5.Solution(21)); // 78
            Console.WriteLine(Multiples3Or5.Solution(-3)); // 0
            //Console.WriteLine(DisemvowellTrolls.Disemvowel("This website is for losers LOL!")); // "Ths wbst s fr lsrs LL!"
            //Console.WriteLine(NumberOfDigits.Digits(1000ul));// 4
            //Console.WriteLine(VowelCount.GetVowelCount("abracadabra")); // 5
            //Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");
            //Console.WriteLine(FindOddInt.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 })); // returns 5 // solution returns -1
            // var array1 = ArrayDifference.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 });
            // foreach (var number in array1)
            // {
            //     Console.Write($"{number} ");// returns new int[] {2}
            // }
            // Console.Write(Environment.NewLine);

            // var array2 = ArrayDifference.ArrayDiff(new int[] { 1, 2, 2, 2, 3 }, new int[] { 2 });
            // foreach (var number in array2)
            // {
            //     Console.Write($"{number} ");// returns new int[] {1, 3}
            // }
            // Console.Write(Environment.NewLine);
            // var a1 = new string[] { "arp", "live", "strong" };
            // var a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            // var ex1 = WhichAreIn.inArray(a1, a2);

            // for (var i = 0; i < ex1.Length; i++)
            // {
            //     Console.Write(ex1[i]);
            // }
            // Console.WriteLine("");
            // // returns["arp", "live", "strong"]
            // var a3 = new string[] { "tarp", "mice", "bull" };
            // var a4 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            // var ex2 = WhichAreIn.inArray(a3, a4);

            // for (var i = 0; i < ex2.Length; i++)
            // {
            //     Console.Write(ex2[i]);
            // }
            // Console.WriteLine("");
            // returns[]
            // Console.WriteLine(StopSpinningMyWords.SpinWords("Hey fellow warriors"));
            // spinWords("Hey fellow warriors") => "Hey wollef sroirraw"
            // Console.WriteLine(StopSpinningMyWords.SpinWords("This is a test"));
            // spinWords("This is a test") => "This is a test"
            // Console.WriteLine(StopSpinningMyWords.SpinWords("This is another test"));
            // spinWords("This is another test") => "This is rehtona test"
            // Console.WriteLine(StopSpinningMyWords.SpinWords("Just kidding there is still one more"));
            // ("Just gniddik ereht is llits one more", Kata.SpinWords("Just kidding there is still one more"))
            // var stringArray = FizzBuzz.GetFizzBuzzArray(15);
            // string[] expected = { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            // foreach (var s in stringArray)
            // {
            //     Console.Write($"{s} ");
            // }
            // Console.WriteLine("");
            // var numbers = DeleteOccurencesMoreThanOnce.DeleteNth(new int[] { 20, 37, 20, 21 }, 1);// return [20,37,21]
            // var numbers = DeleteOccurencesMoreThanOnce.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3); 
            // return [1, 1, 3, 3, 7, 2, 2, 2]
            // foreach (var num in numbers)
            // {
            //     Console.Write($"{num}, ");
            // }
            // Console.WriteLine("");
            // Console.WriteLine(GrowthOfAPopulation.NbYear(1500, 5, 100, 5000)); // 15
            // Console.WriteLine(GrowthOfAPopulation.NbYear(1500000, 2.5, 10000, 2000000)); // 10
            // Console.WriteLine(GrowthOfAPopulation.NbYear(1000, 2, 50, 1200)); // 3
            // testing(Arge.NbYear(1500000, 2.5, 10000, 2000000), 10);
            // testing(Arge.NbYear(1500000, 0.25, 1000, 2000000), 94);
            // Console.WriteLine(LargestPairSumInArray.LargestPairSum(new int[] { 10, 14, 2, 23, 19 })); // 42
            // Console.WriteLine(LargestPairSumInArray.LargestPairSum(new int[] { 99, 2, 2, 23, 19 })); // 122
            // Console.WriteLine(SmallEnoughBeginner.SmallEnough(
            //     new int[] { 66, 101 }, 200)); // true
            // Console.WriteLine(SmallEnoughBeginner.SmallEnough(
            //     new int[] { 78, 117, 110, 99, 104, 117, 107, 115 }, 100)); // false
            // Console.WriteLine(SmallEnoughBeginner.SmallEnough(
            //     new int[] { 101, 45, 75, 105, 99, 107 }, 107)); // true
            // Console.WriteLine(SmallEnoughBeginner.SmallEnough(
            //     new int[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 120)); // true
            // Console.WriteLine(HeronsFormula.CalculateAreaOfTriangle(3, 4, 5)); // 6.0
            // Console.WriteLine(OddsOrEvens.OddOrEven(new int[] { 0 })); // even
            // Console.WriteLine(OddsOrEvens.OddOrEven(new int[] { 0, 1, 4 })); // odd
            // Console.WriteLine(OddsOrEvens.OddOrEven(new int[] { 0, -1, -5 })); // even
            // var noOdds = NoOddities.NoOdds(new int[] { 1, 2, 3, 4, 5 });
            // foreach (var number in noOdds)
            // {
            //     Console.Write($"{number}, ");
            // }
            // Console.WriteLine("");
            // var word = "racer";
            // var anagrams = WhereMyAnagramsAt.Anagrams(word, new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" });
            // foreach (var anagram in anagrams)
            // {
            //     Console.Write($"{anagram} ");
            // } // returns 'new List<string> {"carer", "arcre", "carre"}'
            // Console.WriteLine("");
            // var names = SortArrays1.SortMe(new[] { "one", "two", "three" });
            // Console.WriteLine(String.Join(", ", names));
            // Console.WriteLine(StringEndsWith.EndsWith("abc", "bc")); // true
            // Console.WriteLine(StringEndsWith.EndsWith("abc", "d")); // false
            // Console.WriteLine(Operation.Result(
            //     new int[,] 
            //     { 
            //         { 0, 4, 8, 5 }, 
            //         { 2, 4, 7, 1 }, 
            //         { 7, 5, 3, 2 },
            //         { 2, 9, 2, 6 } 
            //     })); // returns 76874
            // Console.WriteLine(LastSurvivors.LastSurvivor("zbk", new int[] { 2, 1 })); // b
            // Console.WriteLine(StringRepeat.RepeatStr(6, "I")); // "IIIIII"
            // Console.WriteLine(StringRepeat.RepeatStr(5, "Hello")); // "HelloHelloHelloHelloHello"
            // Console.WriteLine(HighestAndLowest.HighAndLow("1 2 3 4 5"));  // return "5 1"
            // Console.WriteLine(HighestAndLowest.HighAndLow("1 2 -3 4 5")); // return "5 -3"
            // Console.WriteLine(HighestAndLowest.HighAndLow("1 9 3 4 -5")); // return "9 -5"
            // var countByOnes = CountByX.CountBy(1, 10);
            // Console.WriteLine(String.Join(", ", countByOnes));
            // var countByTwos = CountByX.CountBy(2, 5);
            // Console.WriteLine(String.Join(", ", countByTwos));
            // Console.WriteLine(OverTheRoad.overTheRoad(1, 3)); // 6
            // Console.WriteLine(OverTheRoad.overTheRoad(6, 3)); // 1
            // Console.WriteLine(OverTheRoad.overTheRoad(3, 3)); // 4
            // Console.WriteLine(OverTheRoad.overTheRoad(2, 3)); // 5
            // Console.WriteLine(OverTheRoad.overTheRoad(3, 5)); // 8
            // Console.WriteLine(ReturningStrings.Greet("Linda"));
            // Console.WriteLine(ReturnNegative.MakeNegative(0));
            // Console.WriteLine(RemoveFirstAndLastCharacters.Remove_char("apple"));
            // var ages = CatYearsAndDogYears.humanYearsCatYearsDogYears(3);
            // foreach (var age in ages)
            // {
            //     Console.WriteLine(age);
            // }
            // Console.WriteLine(ReversedWords.ReverseWords("str"));
            // Console.WriteLine(ReversedWords.ReverseWords("Hello World"));
            // Console.WriteLine(ReversedWords.ReverseWords("Reversed Words"));
            // Console.WriteLine(GetMeanOfArray.GetAverage(new int[] { 2, 2, 2, 2 }));
            // Console.WriteLine(CompareWithinMargin.CloseCompare(4, 5));
            // Console.WriteLine(CompareWithinMargin.CloseCompare(5, 5));
            // Console.WriteLine(CompareWithinMargin.CloseCompare(6, 5));
            // Console.WriteLine(CompareWithinMargin.CloseCompare(-6, -5));
            // Console.WriteLine(CompareWithinMargin.CloseCompare(2, 5, 3));
            // Console.WriteLine(CompareWithinMargin.CloseCompare(8.1, 5, 3));
            // Console.WriteLine(CompareWithinMargin.CloseCompare(1.99, 5, 3));
        }
    }
}
