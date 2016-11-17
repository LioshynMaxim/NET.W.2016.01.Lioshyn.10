using System;

namespace Task2
{

    public class Circle : IGeometricShape
    {
        public double Radius { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="radius">Radius circle</param>

        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Circumference
        /// </summary>
        /// <returns>Circumference</returns>

        public double Perimeter() => 2 * Math.PI * Radius;

        /// <summary>
        /// Circle area
        /// </summary>
        /// <returns>Circle area</returns>

        public double Square() => Radius * Radius * Math.PI;

        double IGeometricShape.Length()
        {
            throw new NotImplementedException();
        }

        double IGeometricShape.Width()
        {
            throw new NotImplementedException();
        }
    }

    public class Triangle : IGeometricShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="a">First side</param>
        /// <param name="b">Second Side</param>
        /// <param name="c">Fird side</param>

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException();

            C = c;
            B = b;
            A = a;
        }

        /// <summary>
        /// Perimeter
        /// </summary>
        /// <returns>Perimeter</returns>

        public double Perimeter() => A + B + C;

        /// <summary>
        /// Triangle area
        /// </summary>
        /// <returns>Triangle area</returns>

        public double Square()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }


        double IGeometricShape.Length()
        {
            throw new NotImplementedException();
        }

        double IGeometricShape.Width()
        {
            throw new NotImplementedException();
        }
    }

    public class Quadrat : IGeometricShape
    {
        public double A { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="a">Side</param>

        public Quadrat(double a)
        {
            if (a < 0)
                throw new ArgumentException();

            A = a;
        }

        /// <summary>
        /// Perimetr quadrat
        /// </summary>
        /// <returns>Perimetr quadrat</returns>

        public double Perimeter() => 4 * A;

        /// <summary>
        /// Square quadrat
        /// </summary>
        /// <returns>Square quadrat</returns>

        public double Square() => A * A;

        /// <summary>
        /// Length quadrat
        /// </summary>
        /// <returns>Length quadrat</returns>

        public double Length() => A;

        /// <summary>
        /// Width quadrat
        /// </summary>
        /// <returns>Width quadrat</returns>

        public double Width() => A;
    }

    public class Rectangle : IGeometricShape
    {

        public double A { get; }
        public double B { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="a">Length</param>
        /// <param name="b">Width</param>

        public Rectangle(double a, double b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentException();

            A = a;
            B = b;
        }

        /// <summary>
        /// Perimetr rectangle
        /// </summary>
        /// <returns>Perimetr rectangle</returns>

        public double Perimeter() => 2 * (A + B);

        /// <summary>
        /// Square rectangle
        /// </summary>
        /// <returns>Square rectangle</returns>

        public double Square() => A * B;

        /// <summary>
        /// Length rectangle
        /// </summary>
        /// <returns>Length rectangle</returns>

        public double Length() => A;

        /// <summary>
        /// Width rectangle
        /// </summary>
        /// <returns>Width rectangle</returns>

        public double Width() => B;
    }
}
