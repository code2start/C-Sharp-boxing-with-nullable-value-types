using System;

namespace nullable_value_types_ar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int? a = 10;
             int? b = null;
             int? c = 10;
             //unary operators = lifted operators
             a++;// a is 11
             Console.WriteLine($"a = {a}");
             a = a * c; // a is 110
             Console.WriteLine($"a = {a}");
             a = a + b;// a is null
             Console.WriteLine($"a = {a}");*/


            //Boxing and unboxing nullable value types
            int a = 41;
            Object aBoxed = a;//Boxing
            Console.WriteLine($"value of aBoxed {aBoxed}");//41
            int? aNullable = (int?)aBoxed; 
            Console.WriteLine($"value of aNullable: {aNullable}");//41
            Object aNullableBoxed = aNullable;//boxing 41
            if (aNullableBoxed is int v)
                Console.WriteLine($"aNullableBoxed is boxed: {v}");
        }
    }
}
