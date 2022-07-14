using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    class GNumber<T> where T : IComparable<T>, IEquatable<T>
    {
        public T Number { get; set; }

        public static GNumber<T> operator +(GNumber<T> num1, GNumber<T> num2)
        {
            return new GNumber<T> { Number = (dynamic)num1.Number + num2.Number };
        }

        public static GNumber<T> operator -(GNumber<T> num1, GNumber<T> num2)
        {
            return new GNumber<T> { Number = (dynamic)num1.Number - num2.Number };
        }

        public static GNumber<T> operator *(GNumber<T> num1, GNumber<T> num2)
        {
            return new GNumber<T> { Number = (dynamic)num1.Number * num2.Number };
        }

        public static bool operator >(GNumber<T> num1, GNumber<T> num2)
        {
            return num1.Number.CompareTo(num2.Number) > 0;
        }

        public static bool operator <(GNumber<T> num1, GNumber<T> num2)
        {
            return num1.Number.CompareTo(num2.Number) < 0;
        }

        public static bool operator ==(GNumber<T> num1, GNumber<T> num2)
        {
            return num1.Number.Equals(num2.Number);
        }

        public static bool operator !=(GNumber<T> num1, GNumber<T> num2)
        {
            return !(num1.Number.Equals(num2.Number));
        }

        public string Print()
        {
            return Number.ToString();
        }


    }
}
