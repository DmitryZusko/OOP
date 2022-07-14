//Створити шаблон класу Chyslo. Шаблон класу повинен давати можливість вивести число на екран, додавати, віднімати, множити, а також порівнювати  числа. 
//Продемонструвати  функціонал шаблону на створеному користувацькому типі Complex – комплексне число. Для комплексних чисел за більше вважати те число, в якого більший модуль.


using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var cNum1 = new ComplexNumber { Real = 1, Imaginary = 1 };
            var cNum2 = new ComplexNumber { Real = -2, Imaginary = -1 };
            var gNum1 = new GNumber<ComplexNumber> { Number = cNum1 };
            var gNum2 = new GNumber<ComplexNumber> { Number = cNum2 };
            var gNum3 = gNum1 + gNum2;
            var gNum4 = gNum1 - gNum2;
            var gNum5 = gNum1 * gNum2;
            Console.WriteLine($"First number: {gNum1.Print()},\tsecond number: {gNum2.Print()}");
            Console.WriteLine("Sum = " + gNum3.Print());
            Console.WriteLine("Substraction = " + gNum4.Print());
            Console.WriteLine("Multiplication = " + gNum5.Print());
            Console.WriteLine("Num1 > Num2 : " + (gNum1 > gNum2));
            Console.WriteLine("Num1 < Num2 : " + (gNum1 < gNum2));
            Console.WriteLine("Num1 == Num2 : " + (gNum1 == gNum2));
            Console.WriteLine("Num1 != Num2 : " + (gNum1 != gNum2));

        }
    }
}
