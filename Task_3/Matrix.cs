using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace test
{
    partial class Matrix : IDisposable
    {
        public List<double> matrixValues { get; set; }
        private bool isDisposed = false;
        private int rows;

        public int Rows
        {
            get { return rows; }
            set
            {
                if (value <= 0)
                {
                    rows = 1;
                }
                else
                {
                    rows = value;
                }
            }
        }

        private int columns;
        public int Columns
        {
            get { return matrixValues.Count() / Rows; }
            private set { columns = value; }
        }

        public Matrix()
        {
        }
        public Matrix(Matrix matrix)
        {
            Rows = matrix.Rows;
            matrixValues = matrix.matrixValues;
        }

        private List<string> MatrixToString()
        {
            var result = new List<string>();
            for (int index = 0; index < Rows; index++)
            {
                result.Add(String.Join(", ", matrixValues.GetRange(index * Columns, Columns).Select(i => i.ToString())));
            }
            return result;
        }

        public string Print()
        {
            var result = MatrixToString();
            return String.Join("\n", result);
        }

    }
}
