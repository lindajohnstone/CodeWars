// Write function heron which calculates the area of a triangle with sides a, b, and c.

// Heron's formula: sqrt (s * (s - a) * (s - b) * (s - c)), where s = (a + b + c) / 2. 
// Output should have 2 digits precision.
using System;

public static class HeronsFormula
{
    public static double CalculateAreaOfTriangle(double a, double b, double c)
    {
        var s = (a + b + c) / 2;
        return Math.Round(Math.Sqrt(s * (s - a) * (s - b) * (s - c)), 2);
    }
}