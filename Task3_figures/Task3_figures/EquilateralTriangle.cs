using System;

namespace Task3_Figures
{
    /// <summary>
    /// Представляет равносторонний треугольник.
    /// </summary>
    public class EquilateralTriangle : Triangle
    {
        public double Side { get; set; }

        public EquilateralTriangle(
            double side)
        {
            Side = side;
        }

        ~EquilateralTriangle()
        {
            Console.WriteLine(
                "Равносторонний треугольник удалён");
        }

        public override double Area()
        {
            return Math.Sqrt(3) / 4 *
                   Side * Side;
        }

        public override string GetInfo()
        {
            return $"Равносторонний " +
                   $"треугольник: сторона = {Side}";
        }
    }
}