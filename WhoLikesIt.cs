namespace CodeWars
{
    // You probably know the "like" system from Facebook and other pages.People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.

    // Implement the function likes which takes an array containing the names of people that like an item.It must return the display text as shown in the examples:

    // Kata.Likes(new string[0]) => "no one likes this"
    // Kata.Likes(new string[] {"Peter"}) => "Peter likes this"
    // Kata.Likes(new string[] { "Jacob", "Alex" }) => "Jacob and Alex like this"
    // Kata.Likes(new string[] { "Max", "John", "Mark" }) => "Max, John and Mark like this"
    // Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }) => "Alex, Jacob and 2 others like this

    using System;

    public static class WhoLikesIt
    {
        public static string Likes(string[] names)
        {
            if (names.Length == 0) return $"no one likes this";
            if (names.Length == 1) return $"{names[0]} likes this";
            if (names.Length == 2) return $"{names[0]} and {names[1]} like this";
            if (names.Length == 3) return $"{names[0]}, {names[1]} and {names[2]} like this";
            return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
            // alternatives
            // switch - cases as per if statements
            // string[] pattern = { "no one likes this", "{0} likes this", "{0} and {1} like this", "{0}, {1} and {2} like this", "{0}, {1} and {2} others like this" };
            // return name.Length < 4 ? string.Format(pattern[name.Length], name) : string.Format(pattern[4], name[0], name[1], name.Length - 2);
        }
    }
}