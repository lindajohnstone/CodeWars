// Just a simple sorting usage. Create a function that returns the elements 
// of the input-array / list sorted in lexicographical order.
using System;
namespace CodeWars
{
    public class SortArrays1
    {
        public static string[] SortMe(string[] names)
        {
            Array.Sort(names);
            return names;
        }
    }
}