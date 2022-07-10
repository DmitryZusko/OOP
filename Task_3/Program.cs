//Клас Matrix – матриця.Пам’ять під елементи масиву повинна виділятися динамічно. Елементи матриці повинні зберігатися у одновимірному масиві.
//Реалізувати такі функції члени: Знаходження максимального значення матриці, Знаходження мінімального значення матриці. Знаходження середнього арифметичного значення матриці.
//Зміна розмірів матриці. Транспонування матриці. Знаходження оберненої матриці до заданої.
//Перевантажити операції: Додавання, Віднімання, Множення, Множення на скаляр, Введення матриці, Виведення матриці

using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            using var matrix1 = new Matrix { Rows = 4, matrixValues = new List<double> { 5, 10, -2, 3, -6, 12, 1, 2, 3, 8, -10, 5, -6, 3, 7, 7 } };
            using var matrix2 = new Matrix { Rows = 4, matrixValues = new List<double> { -3, 6, 8, 12, -2, 0, 9, 8, 7, 5, 7, -5, 12, 0, 1, 22 } };
            using var reverseMatrix1 = matrix1.GetReversed();

            Console.WriteLine($"Matrix 1:\n{matrix1.Print()}\nMax value: {matrix1.GetMaxValue()}, avarage value: {matrix1.GetAvarage()}, min value: {matrix1.GetMinValue()}");
            Console.WriteLine('\n');
            Console.WriteLine($"Matrix 2:\n{matrix2.Print()}\nMax value: {matrix2.GetMaxValue()}, avarage value: {matrix2.GetAvarage()}, min value: {matrix2.GetMinValue()}");
            Console.WriteLine('\n');
            Console.WriteLine($"Matrix 1 + Matrix 2 :\n{(matrix1 + matrix2).Print()}\nMax value: {(matrix1 + matrix2).GetMaxValue()}, avarage value: {(matrix1 + matrix2).GetAvarage()}, min value: {(matrix1 + matrix2).GetMinValue()}");
            Console.WriteLine('\n');
            Console.WriteLine($"Matrix 1 - Matrix 2 :\n{(matrix1 - matrix2).Print()}\nMax value: {(matrix1 - matrix2).GetMaxValue()}, avarage value: {(matrix1 - matrix2).GetAvarage()}, min value: {(matrix1 - matrix2).GetMinValue()}");
            Console.WriteLine('\n');
            Console.WriteLine($"Matrix 1 * Matrix 2 :\n{(matrix1 * matrix2).Print()}\nMax value: {(matrix1 * matrix2).GetMaxValue()}, avarage value: {(matrix1 * matrix2).GetAvarage()}, min value: {(matrix1 * matrix2).GetMinValue()}");
            Console.WriteLine('\n');
            Console.WriteLine($"Matrix 1 * 10 :\n{(matrix1 * 10).Print()}\nMax value: {(matrix1 * 10).GetMaxValue()}, avarage value: {(matrix1 * 10).GetAvarage()}, min value: {(matrix1 * 10).GetMinValue()}");
            Console.WriteLine('\n');
            Console.WriteLine($"Matrix 1 transposed: :\n{matrix1.Transpose().Print()}\nMax value: {matrix1.Transpose().GetMaxValue()}, avarage value: {matrix1.Transpose().GetAvarage()}, min value: {matrix1.Transpose().GetMinValue()}");
            Console.WriteLine('\n');
            Console.WriteLine($"Matrix 1 reversed:\n{reverseMatrix1.Print()}\nMax value: {reverseMatrix1.GetMaxValue()}, avarage value: {reverseMatrix1.GetAvarage()}, min value: {reverseMatrix1.GetMinValue()}");
            Console.WriteLine('\n');
            Console.WriteLine($"Checker (matrix must be Diag(1)):\n{(matrix1 * reverseMatrix1).Print()}");

        }

    }
}
