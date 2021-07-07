using System;
using System.Collections.Generic;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var noOdds = NoOddities.NoOdds(new int[] { 1, 2, 3, 4, 5 });
            foreach (var number in noOdds)
            {
                Console.Write($"{number}, ");
            }
            Console.WriteLine("");
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
