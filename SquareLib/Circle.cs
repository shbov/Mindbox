using System;

namespace SquareLib
{
    public class Circle : IFigure
    {
        public Circle(double r)
        {
            R = r;
        }

        private double _r;

        public double R
        {
            get => _r;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Радиус не может быть отрицательным.");

                _r = value;
            }
        }

        public double Square() => Math.PI * Math.Pow(R, 2);
    }
}