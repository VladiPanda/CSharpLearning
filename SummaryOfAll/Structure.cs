using System;

namespace SummaryOfAll
{
     struct Structure
    {
     // Если в структуре имеются члены, которые обращаются к полю и нет пользовательского конструктора, то требуется
     // при создании экземпляра вызывать коснтруктор по умолчанию. (Иначе будет ошибка)
     private int field1;

     public int Field1
     {
         get { return field1; }
         set { field1 = value; }
     }

     public void Show()
     {
         Console.WriteLine(field1);
     }
    }

     struct MyStruct
     {
         public int field;
     }

     struct MyStruct2
     {
         public int field2;
         
         // Конструкторы по умолчанию нельзя задавать явно
         // public MyStruct2()
         // {
         //     
         // }
         
         // Если в структуре имеется пользовательский конструктор, то требуется в нем инициализировать все поля.

         public MyStruct2(int value)
         {
             Console.WriteLine("Constructor");
             this.field2 = value;
         }
     }
     
     // пример хорошего дизайна

     struct ZipCode
     {
         // Поля
         int fiveDigitCode;
         int plusFourExtension;
         
         // Конструкторы
         public ZipCode(int fiveDigitCode, int plusFourExtension)
         {
             this.fiveDigitCode = fiveDigitCode;
             this.plusFourExtension = plusFourExtension;
         }

         public ZipCode(int fiveDigitCode) : this(fiveDigitCode, 0)
         {
             
         }
         
         // Свойства
         public int FiveDigitCode
         {
             get { return fiveDigitCode; }
             
         }

         public int PlusFourExtension
         {
             get { return plusFourExtension; }
         }
     }
}