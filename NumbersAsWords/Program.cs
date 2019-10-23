using System;
using System.Collections.Generic;
using Ploeh.Numsense.ObjectOriented;

namespace NumbersAsWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "one-thousand, two-hundred, sixty two"; //best-case scenario
            //var input = "zero one two three four five six seven eight nine ten";
            var cleaned = input.Replace(",", string.Empty);
            var eachWord = cleaned.Split(' ');
            List<int> resultingDigits = new List<int>();
            int counter = 0;
            foreach (var word in eachWord)
            {
                var success = Numeral.English.TryParse(word, out int result);
                if (success)
                {
                    resultingDigits.Add(result);
                    counter += result;
                }
            }
            Console.WriteLine("Result: " + counter);
        }
    }
}
