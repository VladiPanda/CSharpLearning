namespace Recursion.Tasks
{
    public class SumDigitsNumber
    {
        public int SumDigits(int number)
        {
            // 1
            // if (number < 10)
            // {
            //     return number;
            // }
            //
            // return number % 10 + SumDigits(number / 10);
            
            //2
            return (number < 10) ? number : number % 10 + SumDigits(number / 10);
        }
    }
}