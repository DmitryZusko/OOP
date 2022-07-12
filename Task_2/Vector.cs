using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_2
{
    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public static int VectorCount { get; private set; }

        public Vector()
        {
            VectorCount++;
        }

        public Vector(string vector)
        {
            var splitter = new[] { ' ', '(', ')' };
            var coordinates = String.Concat(vector.Split(splitter)).Split(',');
            int.TryParse(coordinates[0].ToString(), out int x);
            int.TryParse(coordinates[1].ToString(), out int y);
            int.TryParse(coordinates[2].ToString(), out int z);
            this.X = x;
            this.Y = y;
            this.Z = z;
            VectorCount++;
        }

        public string GetVector()
        {
            return $"({X}, {Y}, {Z})";
        }

        public static Vector operator +(Vector vec1, Vector vec2)
        {
            return new Vector { X = vec1.X + vec2.X, Y = vec1.Y + vec2.Y, Z = vec1.Z + vec2.Z };
        }

        public static Vector operator -(Vector vec1, Vector vec2)
        {
            return new Vector { X = vec1.X - vec2.X, Y = vec1.Y - vec2.Y, Z = vec1.Z - vec2.Z };
        }

        public static double operator *(Vector vec1, Vector vec2)
        {
            return vec1.X * vec2.X + vec1.Y * vec2.Y + vec1.Z * vec2.Z;
        }

        public static Vector operator *(Vector vec1, int number)
        {
            return new Vector { X = vec1.X * number, Y = vec1.Y * number, Z = vec1.Z * number };
        }

        public static Vector operator *(int number, Vector vec1)
        {
            return new Vector { X = vec1.X * number, Y = vec1.Y * number, Z = vec1.Z * number };
        }

        public static bool operator >(Vector vec1, Vector vec2)
        {
            if (vec1.Length() > vec2.Length())
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Vector vec1, Vector vec2)
        {
            if (vec1.Length() < vec2.Length())
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Vector vec1, Vector vec2)
        {
            if (vec1.Length() == vec2.Length())
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Vector vec1, Vector vec2)
        {
            if (vec1.Length() != vec2.Length())
            {
                return true;
            }
            return false;
        }



        private double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }




    }
}
