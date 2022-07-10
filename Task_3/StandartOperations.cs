using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//Here are all standart operations, like +, -, *, T, Min/Max Values, etc
namespace test
{
    partial class Matrix
    {
        public double GetMaxValue()
        {
            return matrixValues.Max();
        }

        public double GetMinValue()
        {
            return matrixValues.Min();
        }

        public double GetAvarage()
        {
            var avarage = 0.0;
            foreach (var item in matrixValues)
            {
                avarage += item;
            }
            return Math.Round(avarage / matrixValues.Count, 3);
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            var matrix = new Matrix { Rows = matrix1.Rows, matrixValues = new List<double>() };
            for (int index = 0; index < matrix1.matrixValues.Count(); index++)
            {
                matrix.matrixValues.Add(matrix1.matrixValues[index] + matrix2.matrixValues[index]);
            }
            return matrix;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            var matrix = new Matrix { Rows = matrix1.Rows, matrixValues = new List<double>() };
            for (int index = 0; index < matrix1.matrixValues.Count(); index++)
            {
                matrix.matrixValues.Add(matrix1.matrixValues[index] - matrix2.matrixValues[index]);
            }
            return matrix;
        }

        public static Matrix operator *(Matrix matrix1, int number)
        {
            var matrix = new Matrix { Rows = matrix1.Rows, matrixValues = new List<double>() };
            for (int index = 0; index < matrix1.matrixValues.Count(); index++)
            {
                matrix.matrixValues.Add(matrix1.matrixValues[index] * number);
            }
            return matrix;
        }
        public static Matrix operator *(int number, Matrix matrix1)
        {
            var matrix = new Matrix { Rows = matrix1.Rows, matrixValues = new List<double>() };
            for (int index = 0; index < matrix1.matrixValues.Count(); index++)
            {
                matrix.matrixValues.Add(matrix1.matrixValues[index] * number);
            }
            return matrix;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            var matrix = new Matrix { Rows = matrix1.Rows, Columns = matrix2.Columns, matrixValues = new List<double>() };
            for (int matrixItem = 0; matrixItem < matrix2.Columns * matrix1.Rows; matrixItem++)
            {
                var matrixValue = 0.0;
                for (int matrixIndex = 0; matrixIndex < matrix2.Columns; matrixIndex++)
                {
                    matrixValue += matrix1.matrixValues[(matrixItem / matrix2.Columns) * matrix1.Columns + matrixIndex] * matrix2.matrixValues[matrixItem % matrix2.Columns + matrixIndex * matrix2.Columns];
                }
                matrix.matrixValues.Add(matrixValue);
            }
            return matrix;
        }
        public static Matrix operator /(Matrix matrix1, double number)
        {
            var matrix = new Matrix { Rows = matrix1.Rows, matrixValues = new List<double>() };
            for (int index = 0; index < matrix1.matrixValues.Count(); index++)
            {
                matrix.matrixValues.Add(Math.Round(matrix1.matrixValues[index] / number, 3));
            }
            return matrix;
        }
        public static Matrix operator /(double number, Matrix matrix1)
        {
            var matrix = new Matrix { Rows = matrix1.Rows, matrixValues = new List<double>() };
            for (int index = 0; index < matrix1.matrixValues.Count(); index++)
            {
                matrix.matrixValues.Add(Math.Round(matrix1.matrixValues[index] / number, 3));
            }
            return matrix;
        }

        public Matrix Transpose()
        {
            var matrix = new Matrix { Rows = Columns, matrixValues = new List<double>() };
            for (int index = 0; index < matrixValues.Count(); index++)
            {
                matrix.matrixValues.Add(matrixValues[index * Columns - index / Rows * (matrixValues.Count() - 1)]);
            }
            return matrix;
        }
    }
}
