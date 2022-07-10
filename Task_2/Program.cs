//Створити клас Vector – вектор в просторі. Перевантажити операції, як функції члени: Додавання, Віднімання, Скалярний добуток, векторний добуток.
//Перевантажити операції, як дружні-функції: Добуток вектора на скаляр, Введення вектора з форми, Виведення вектора на форму, Більше, Менше, Рівне (порівнювати довжини векторів).
//Створити статичне поле, в якому б містилась інформація про кількість створених об’єктів, а також статичні функції для роботи з цим полем.


using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var vec1 = new Vector("(-1, -2, -3)");
            var vec2 = new Vector { x = -1, y = -2, z = -3 };

            Console.WriteLine($"Vec1: {vec1.GetVector()}\nvec2: {vec2.GetVector()}");
            Console.WriteLine($"vec1 + vec2 = {(vec1 + vec2).GetVector()}");
            Console.WriteLine($"vec1 - vec2 = {(vec1 - vec2).GetVector()}");
            Console.WriteLine($"vec1 * vec2 = {vec1 * vec2}");
            Console.WriteLine($"vec1 * 5 = {(vec1 * 5).GetVector()}");
            Console.WriteLine($"5 * vec1 = {(5 * vec1).GetVector()}");
            Console.WriteLine($"Is vec1 > vec2: {vec1 > vec2}");
            Console.WriteLine($"Is vec1 < vec2: {vec1 < vec2}");
            Console.WriteLine($"Is vec1 = vec2: {vec1 == vec2}");
            Console.WriteLine($"Is vec1 neq vec2: {vec1 != vec2}");
            Console.WriteLine($"The program created {Vector._vectorCount} vector(-s)");

            Console.ReadLine();
        }
    }
}
