using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//Here is jobana reverse matrix method
namespace test
{
    partial class Matrix
    {
        public Matrix GetReversed()
        {
            var determinante = GetDeterminante();
            if (determinante != 0)
            {
                var adjMatrix = GetAdjMatrix();
                return adjMatrix / determinante;
            }
            return this;
        }

        private Matrix GetAdjMatrix()
        {
            var minorMatrix = (GetMinorMatrix()).Transpose();
            return minorMatrix;
        }

        private Matrix GetMinorMatrix()
        {
            var minorMatrix = new Matrix { Rows = Rows, matrixValues = new List<double>() };
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    minorMatrix.matrixValues.Add((i + j) % 2 == 0 ? MatrixCutter(i, j).GetDeterminante() :
                        -MatrixCutter(i, j).GetDeterminante());
                }
            }
            return minorMatrix;
        }

        private Matrix MatrixCutter(int rowIndex, int columnIndex)
        {
            var cuttedMatrix = new Matrix { Rows = Rows - 1, Columns = Columns - 1, matrixValues = new List<double>() };
            var originArr = ToTwoDimArray();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (i != rowIndex && j != columnIndex)
                    {
                        cuttedMatrix.matrixValues.Add(originArr[i, j]);
                    }
                }
            }
            return cuttedMatrix;
        }

        private double GetDeterminante()
        {
            var determinante = 0.0;
            if (matrixValues.Count() > 1)
            {
                for (int index = 0; index < Columns; index++)
                {
                    determinante += index % 2 == 0 ? matrixValues[index] * MatrixCutter(0, index).GetDeterminante() :
                        -matrixValues[index] * MatrixCutter(0, index).GetDeterminante();
                }
                return determinante;
            }
            else
            {
                return matrixValues[0];
            }
        }

        private double[,] ToTwoDimArray()
        {
            var twoDimArr = new double[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    twoDimArr[i, j] = matrixValues[i * Rows + j];
                }
            }
            return twoDimArr;
        }


    }
}
