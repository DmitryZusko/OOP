//Створити клас Complex – комплексне число.Клас повинен містити функції: а)Додавання б)Віднімання в)Множення г)Піднесення до n-го степеня д)Отримання кореня n-го степеня 
//е)Задавання значень полів є)Зчитування(отримання значень полів) ж)Представлення в тригонометричній формі з)Введення комплексного числа з форми 
//и)Виведення комплексного числа на форму. При створенні класу повинен бути дотриманий принцип інкапсуляції. Створити конструктор за замовчуванням та хоча б два інших 
//конструктори для початкової ініціалізації об’єкта.

using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var complex1 = new ComplexNumber();
            var complex2 = new ComplexNumber(5, false);
            var complex3 = new ComplexNumber(-12, true);
            var complex4 = new ComplexNumber(6, 8);
            var complex5 = new ComplexNumber("2,18 + i7,32");

            Console.WriteLine($"First number: {complex1.ToString()},\nSecond number: {complex2.ToString()},\nThird number: {complex3.ToString()}" +
                $",\nFourth number: {complex4.ToString()},\nFifth number: {complex5.ToString()}");
            Console.WriteLine("\n\t\t=================================\n");

            var addition = complex1 + complex2;
            var substraction = complex3- complex4;
            var multiplication = complex5 * complex4;

            Console.WriteLine($"({complex1.ToString()}) + ({complex2.ToString()}) = {addition.ToString()}," +
                $"\n({complex3.ToString()}) - ({complex4.ToString()}) = {substraction.ToString()}," +
                $"\n({complex5.ToString()}) * ({complex4.ToString()}) = {multiplication.ToString()}");
            Console.WriteLine("\n\t\t=================================\n");

            byte power = 5;
            var trigonom = complex4.GetTrigonomForm();
            var pow = complex4.GetComplexPow(power);
            var root = complex4.GetComplexRoot(power);

            Console.WriteLine($"Triginometric form of {complex4.ToString()}: {trigonom},\nGet power of {power}: {pow},\nget root of {power}: {root}");
            Console.WriteLine("\n\t\t=================================\n");

            complex1.Real = 10;
            complex1.Imaginary = -10;
            Console.WriteLine($"First number now is: {complex1.ToString()}");

            Console.ReadLine();
        }
    }
}
