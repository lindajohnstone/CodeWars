// Write a small function that returns the values of an array that are not odd.

// All values in the array will be integers. Return the good values in the order they 
// are given.
using System;
using System.Collections.Generic;

public class NoOddities
{
    public static int[] NoOdds(int[] values)
    {
        var noOdds = new List<int>();
        foreach (var value in values)
        { 
            if (value % 2 == 0) 
            {
                noOdds.Add(value);
            }
        }
        return noOdds.ToArray();
    }
}