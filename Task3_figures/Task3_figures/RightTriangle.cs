using System;

namespace Task3_Figures
{
    /// <summary>
    /// Представляет прямоугольный треугольник.
    /// </summary>
    public class RightTriangle : Triangle
    {
        public double LegA { get; set; }
        public double LegB { get; set; }

        public RightTriangle(
            double legA,
            double legB)
        {
            if (legA <= 0)
            {
                throw new ArgumentException(
                    "Катет А должен быть больше нуля.");
            }
            if (legB <= 0)
            {
                throw new ArgumentException(
                    "Катет B должен быть больше нуля.");
            }
            LegA = legA;
            LegB = legB;
        }

        ~RightTriangle()
        {
            Console.WriteLine(
                "Прямоугольный треугольник удалён");
        }

        public override double Area()
        {
            return (LegA * LegB) / 2;
        }

        public override string GetInfo()
        {
            return $"Прямоугольный треугольник: " +
                   $"катет A = {LegA}, " +
                   $"катет B = {LegB}";
        }
    }
}