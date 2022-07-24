//Реалізувати програму для роботи з одновимірним масивом дійсних чисел. Масив повинен зчитуватися з файлу.
//Програма повинна надавати функціонал для знаходження максимального, мінімального числа масиву, а також середнього арифметичного чисел масиву.
//Результати записувати в інший файл. Вхідний і вихідний файли задаються користувачем.
//Роботу з масивами необхідно здійснювати за допомогою розробленого класу MyArray. Програма повинна перехоплювати та опрацьовувати такі виняткові ситуації:
//а) масив не містить жодного символу, б) введення користувачем літерного символу замість числа, в) переповнення,  г)не існують вхідний і вихідний файли,
//д) ще дві виняткові ситуації передбачити самостійно. 



namespace Task_6
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            var inputFile = "Input.txt";
            var outputFile = "Output.txt";

            var myArr = new MyArray();
            try
            {
                myArr.ReadFromFile(inputFile);
                Console.WriteLine($"User's array: {myArr.Print()}; max value = {myArr.GetMax()}, average value = {myArr.GetAverage()}, min value = {myArr.GetMin()}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(new FileNotFoundException("The input file specified in path was not found.").Message + ex.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
            }
            catch (TooManyDataException ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
            }

            myArr.WriteToFile(outputFile);


            Console.ReadLine();
        }
    }
}