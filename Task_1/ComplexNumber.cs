using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace Task_1
{
    class ComplexNumber : IComparable<ComplexNumber>, IEquatable<ComplexNumber>
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        private const int PRECISION = 3;

        //default constructor
        public ComplexNumber()
        {

        }

        //other constructors
        public ComplexNumber(double number, bool isComplex)
        {
            if (isComplex == true)
            {
                Imaginary = number;
            }
            else
            {
                Real = number;
            }
        }

        public ComplexNumber(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public ComplexNumber(string complex)
        {
            var values = complex.Split(" + i");
            Double.TryParse(values[0], out double real);
            Double.TryParse(values[1], out double imaginary);
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public override string ToString()
        {
            if (Imaginary < 0)
            {
                return $"{Real} - i{-Imaginary}";
            }
            return $"{Real} + i{Imaginary}";
        }

        public string GetTrigonomForm()
        {
            var z = GetABS();
            var phi = GetAngle();
            return $"{z}(cos({phi}) + i sin({phi}))";
        }

        public string GetComplexPow(byte n)
        {
            var z = Math.Pow(GetABS(), n);
            var phi = n * GetAngle();
            return $"{z}(cos({phi}) + i sin({phi}))";
        }

        public string GetComplexRoot(byte n)
        {
            var z = Math.Pow(GetABS(), 1 / n);
            var phi = GetAngle() / n;
            return $"{z}(cos({phi}) + i sin({phi}))";
        }

        public int CompareTo(ComplexNumber complex2)
        {
            switch (GetABS() - complex2.GetABS())
            {
                case > 0:
                    {
                        return 1;
                    }
                case < 0:
                    {
                        return -1;
                    }
                default:
                    {
                        return 0;
                    }

            }
        }

        public bool Equals(ComplexNumber complex2)
        {
            return Real == complex2.Real && Imaginary == complex2.Imaginary;
        }


        public static ComplexNumber operator +(ComplexNumber complex1, ComplexNumber complex2)
        {
            return new ComplexNumber { Real = complex1.Real + complex2.Real, Imaginary = complex1.Imaginary + complex2.Imaginary };
        }

        public static ComplexNumber operator -(ComplexNumber complex1, ComplexNumber complex2)
        {
            return new ComplexNumber { Real = complex1.Real - complex2.Real, Imaginary = complex1.Imaginary - complex2.Imaginary };
        }

        public static ComplexNumber operator *(ComplexNumber complex1, ComplexNumber complex2)
        {
            return new ComplexNumber
            {
                Real = Math.Round(complex1.Real * complex2.Real - complex1.Imaginary * complex2.Imaginary, PRECISION),
                Imaginary = Math.Round(complex1.Real * complex2.Imaginary + complex1.Imaginary * complex2.Real, PRECISION)
            };
        }


        private double GetABS()
        {
            if (Real != 0 && Imaginary != 0)
            {
                return Math.Round(Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2)), PRECISION);
            }
            return 0;

        }

        private double GetAngle()
        {
            if (Real != 0 && Imaginary != 0)
            {
                return Math.Round(Math.Asin(Real / GetABS()), PRECISION);
            }
            return 0;
        }
    }
}
