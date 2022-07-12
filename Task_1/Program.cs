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

            Console.WriteLine($"First number: {complex1.GetComplexNumber()},\nSecond number: {complex2.GetComplexNumber()},\nThird number: {complex3.GetComplexNumber()}" +
                $",\nFourth number: {complex4.GetComplexNumber()},\nFifth number: {complex5.GetComplexNumber()}");
            Console.WriteLine("\n\t\t=================================\n");

            var addition = ComplexNumber.Addition(complex1, complex2);
            var substraction = ComplexNumber.Substraction(complex3, complex4);
            var multiplication = ComplexNumber.Multiplication(complex5, complex4);

            Console.WriteLine($"({complex1.GetComplexNumber()}) + ({complex2.GetComplexNumber()}) = {addition.GetComplexNumber()}," +
                $"\n({complex3.GetComplexNumber()}) - ({complex4.GetComplexNumber()}) = {substraction.GetComplexNumber()}," +
                $"\n({complex5.GetComplexNumber()}) * ({complex4.GetComplexNumber()}) = {multiplication.GetComplexNumber()}");
            Console.WriteLine("\n\t\t=================================\n");

            byte power = 5;
            var trigonom = complex4.GetTrigonomForm();
            var pow = complex4.GetComplexPow(power);
            var root = complex4.GetComplexRoot(power);

            Console.WriteLine($"Triginometric form of {complex4.GetComplexNumber()}: {trigonom},\nGet power of {power}: {pow},\nget root of {power}: {root}");
            Console.WriteLine("\n\t\t=================================\n");

            complex1.Real = 10;
            complex1.Imaginary = -10;
            Console.WriteLine($"First number now is: {complex1.GetComplexNumber()}");

            Console.ReadLine();
        }
    }
}
