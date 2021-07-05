// Write a function called repeatStr which repeats the given string string exactly n times.

// repeatStr(6, "I") // "IIIIII"
// repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"
namespace CodeWars
{
  public static class StringRepeat
  {
    public static string RepeatStr(int n, string s)
    {
        var repeatedString = "";
            for (int i = 0; i < n; i++)
            {
                repeatedString += s;
            }
                return repeatedString;
        }
  }
}