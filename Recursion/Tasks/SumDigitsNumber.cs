namespace Recursion.Tasks
{
    public class SumDigitsNumber
    {
        public int SumDigits(int number)
        {
            // E: Дано натуральное число N. Вычислите сумму его цифр.
            //    При решении этой задачи нельзя использовать строки, списки, массивы (ну и циклы, разумеется). (DONE) 
            
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