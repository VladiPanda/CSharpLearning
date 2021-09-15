namespace SummaryOfAll
{
    public enum Enums : byte
    {
        /* при компиляции - компилятор подставляет вместо имен, установленные им в соответствие числовые значения.
           [имя] = [число] По умолчанию типом данных констант перечисления будет int. Можно использовать любой целый
           тип данных C# (byte, sbyte, short, ushort, int, uint, long, ulong*/
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3
    }
    
    enum EnumType
    {
        Zero,  // = 0 
        One,   // = 1
        one = One,
        Two = 2,
        Three, // = 3
        Four,  // = 4
        Five = 5,
        Six = Nine,
        //Seven,
        Eight = 8, // Если не указать значение явно, то на 13 строке будет ошибка!
        Nine,
        Ten = 10,
        Infinite = 255
    }
}