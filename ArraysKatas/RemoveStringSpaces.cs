using System;
using System.Linq;

namespace ArraysKatas
{
    // Simple, remove the spaces from the string, then return the resultant string.
    public class RemoveStringSpaces
    {
        public string NoSpace(string input)
        {
            return input.Replace(" ", "");
        }  
    }
}