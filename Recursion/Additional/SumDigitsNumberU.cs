namespace Recursion.Additional
{
    public static class SumDigitsNumberU
    {
        public static int Sdm(int number)
        {
            int sum = 0;
            for (int i = number; i > 0; i /= 10)
            {
                sum += i % 10;
            }
            return sum;
        }
    }
}