using System;

namespace Utilities
{
    public static class StringUtilities
    {
        public static int LongWordsCount(string str)
        {
            var split = str.Split(' ');
            var counter = 0;
            foreach (var item in split)
            {
                if (item.Length > 2)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static string ToSpinalCase(string str)
        {
            var stringLower = str.ToLower();
            stringLower = stringLower.Replace(" ", "-");
            return stringLower;
        }
    }
}
