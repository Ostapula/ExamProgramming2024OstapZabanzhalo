using System;
using Utilities;

namespace UtilitiesTests
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringUtilities.LongWordsCount("Marcin Jagiela"));
            Console.WriteLine(StringUtilities.LongWordsCount("The lord of the rings"));

            Console.WriteLine(StringUtilities.ToSpinalCase("Marcin Jagiela"));
            Console.WriteLine(StringUtilities.ToSpinalCase("the LorD OF thE Rings"));


        }
    }
}
