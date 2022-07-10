using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task_1
{
    class ComplexNumber
    {
        public double real { get; set; }
        public double imaginary { get; set; }
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
                imaginary = number;
            }
            else
            {
                real = number;
            }
        }

        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public ComplexNumber(string complex)
        {
            //Should I use operation .ToList(), if Split returns array?
            var values = complex.Split(" + i");
            Double.TryParse(values[0], out double real);
            Double.TryParse(values[1], out double imaginary);
            this.real = real;
            this.imaginary = imaginary;

        }

        public string GetComplexNumber()
        {
            if (imaginary < 0)
            {
                return $"{real} - i{-imaginary}";
            }
            return $"{real} + i{imaginary}";
        }

        public static ComplexNumber Addition(ComplexNumber complex1, ComplexNumber complex2)
        {
            var complex3 = new ComplexNumber(complex1.real + complex2.real, complex1.imaginary + complex2.imaginary);
            return complex3;
        }

        public static ComplexNumber Substraction(ComplexNumber complex1, ComplexNumber complex2)
        {
            var complex3 = new ComplexNumber(complex1.real - complex2.real, complex1.imaginary - complex2.imaginary);
            return complex3;
        }

        public static ComplexNumber Multiplication(ComplexNumber complex1, ComplexNumber complex2)
        {
            var complex3 = new ComplexNumber();
            complex3.real = Math.Round(complex1.real * complex2.real - complex1.imaginary * complex2.imaginary, PRECISION);
            complex3.imaginary = Math.Round(complex1.real * complex2.imaginary + complex1.imaginary * complex2.real, PRECISION);
            return complex3;
        }

        private double GetABS()
        {
            if (real != 0 && imaginary != 0)
            {
                return Math.Round(Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2)), PRECISION);
            }
            return 0;

        }

        private double GetAngle()
        {
            if (real != 0 && imaginary != 0)
            {
                return Math.Round(Math.Asin(real / GetABS()), PRECISION);
            }
            return 0;
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

    }
}
