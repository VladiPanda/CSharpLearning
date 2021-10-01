using System;

namespace StopwatchWPFtest
{
    class Model
    {
        public string AddNumber(string s)   // Метод, который инкрементирует значение счета таймера на одну единицу
        {
            int number = Convert.ToInt32(s);
            
            ++number;
            s = Convert.ToString(number);
            if (s.Length == 1)
            {
                s = "0" + s;
            }
            return s;
        }
    }
}