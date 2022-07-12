using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task_1
{
    class ComplexNumber
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

        public string GetComplexNumber()
        {
            if (Imaginary < 0)
            {
                return $"{Real} - i{-Imaginary}";
            }
            return $"{Real} + i{Imaginary}";
        }

        public static ComplexNumber Addition(ComplexNumber complex1, ComplexNumber complex2)
        {
            var complex3 = new ComplexNumber(complex1.Real + complex2.Real, complex1.Imaginary + complex2.Imaginary);
            return complex3;
        }

        public static ComplexNumber Substraction(ComplexNumber complex1, ComplexNumber complex2)
        {
            var complex3 = new ComplexNumber(complex1.Real - complex2.Real, complex1.Imaginary - complex2.Imaginary);
            return complex3;
        }

        public static ComplexNumber Multiplication(ComplexNumber complex1, ComplexNumber complex2)
        {
            var complex3 = new ComplexNumber();
            complex3.Real = Math.Round(complex1.Real * complex2.Real - complex1.Imaginary * complex2.Imaginary, PRECISION);
            complex3.Imaginary = Math.Round(complex1.Real * complex2.Imaginary + complex1.Imaginary * complex2.Real, PRECISION);
            return complex3;
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
