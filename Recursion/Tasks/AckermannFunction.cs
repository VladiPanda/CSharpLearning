namespace Recursion.Tasks
{
    public static class AckermannFunction
    {
        public static int ComputableFunction(int valueM, int valueN)
        {
            if (valueM == 0)
            {
                return valueN + 1;
            }
            if (valueN == 0)
            {
                return ComputableFunction(valueM - 1, 1);
            }
            return ComputableFunction(valueM - 1, ComputableFunction(valueM, valueN - 1));
        }
    }
}