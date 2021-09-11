using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomKatas
{
    /*  Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

        For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

        Note: The function accepts an integer and returns an integer */
    public class SquareEveryDigit
    {
        public static int SquareDigits(int n)
        {
            // 1
            string output = null;
            foreach (char num in n.ToString())
            {
                int square = Convert.ToInt32(char.GetNumericValue(num));
                output += square * square;
            }
            return int.Parse(output);
            
            // 2
            // string results = null;
            // int squareResults;
            // List<int> numbersArray = n.ToString().Select(n => Convert.ToInt32(char.GetNumericValue(n))).ToList<int>();
            // numbersArray.ForEach(x => {results += x * x;});
            // squareResults = int.Parse(results);
            // return squareResults;
            
            // 3
            // return int.Parse(String.Concat(n.ToString().Select(a => (int)Math.Pow(char.GetNumericValue(a), 2))));
        }
    }
}