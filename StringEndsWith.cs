namespace CodeWars
{
    // Complete the solution so that it returns true if the first argument(string) 
    // passed in ends with the 2nd argument (also a string).

    // Examples:

    // strEndsWith('abc', 'bc')-- returns true
    // strEndsWith('abc', 'd')-- returns false
    public class StringEndsWith
    {
        public static bool EndsWith(string str, string ending)
        {
            if (ending == "") return true;
            var position = str.LastIndexOf(ending);
            if (position == -1) return false;
            if (str.Substring(position) != ending) return false;
            return true;
            //return str.EndsWith(ending);
        }
    }
}