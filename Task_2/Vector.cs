using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_2
{
    class Vector
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public static int _vectorCount { get; private set; }

        public Vector()
        {
            _vectorCount++;
        }

        public Vector(string vector)
        {
            var splitter = new[] { ' ', '(', ')' };
            var coordinates = String.Concat(vector.Split(splitter)).Split(',');
            int.TryParse(coordinates[0].ToString(), out int x);
            int.TryParse(coordinates[1].ToString(), out int y);
            int.TryParse(coordinates[2].ToString(), out int z);
            this.x = x;
            this.y = y;
            this.z = z;
            _vectorCount++;
        }

        public string GetVector()
        {
            return $"({x}, {y}, {z})";
        }

        public static Vector operator +(Vector vec1, Vector vec2)
        {
            return new Vector { x = vec1.x + vec2.x, y = vec1.y + vec2.y, z = vec1.z + vec2.z };
        }

        public static Vector operator -(Vector vec1, Vector vec2)
        {
            return new Vector { x = vec1.x - vec2.x, y = vec1.y - vec2.y, z = vec1.z - vec2.z };
        }

        public static double operator *(Vector vec1, Vector vec2)
        {
            return vec1.x * vec2.x + vec1.y * vec2.y + vec1.z * vec2.z;
        }

        public static Vector operator *(Vector vec1, int number)
        {
            return new Vector { x = vec1.x * number, y = vec1.y * number, z = vec1.z * number };
        }

        public static Vector operator *(int number, Vector vec1)
        {
            return new Vector { x = vec1.x * number, y = vec1.y * number, z = vec1.z * number };
        }

        private double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
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





    }
}
