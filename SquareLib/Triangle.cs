using System;

namespace SquareLib
{
    public class Triangle : IFigure
    {
        private const string SideError = "Сторона треугольника не может быть отрицательной.";
        private double _a, _b, _c;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A
        {
            get => _a;
            set
            {
                if (value < 0)
                    throw new ArgumentException(SideError);

                _a = value;
            }
        }

        public double B
        {
            get => _b;
            set
            {
                if (value < 0)
                    throw new ArgumentException(SideError);

                _b = value;
            }
        }

        public double C
        {
            get => _c;
            set
            {
                if (value < 0)
                    throw new ArgumentException(SideError);

                _c = value;
            }
        }

        public double Perimeter => A + B + C;
        public double HalfPerimeter => (A + B + C) / 2;

        public double Square()
            => Math.Sqrt(HalfPerimeter * (HalfPerimeter - A) * (HalfPerimeter - B) * (HalfPerimeter - C));

        public bool IsRectangular => Math.Abs(Math.Pow(C, 2) - (Math.Pow(A, 2) + Math.Pow(B, 2))) < 10e-6;
    }
}