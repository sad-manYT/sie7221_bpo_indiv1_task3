using System;

namespace Task3_Figures
{
    /// <summary>
    /// Представляет равносторонний треугольник.
    /// </summary>
    public class EquilateralTriangle : IsoscelesTriangle
    {
        public double Side { get; set; }

        public EquilateralTriangle(
            double side) : base(side, Math.Sqrt(3) / 2 * side)
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