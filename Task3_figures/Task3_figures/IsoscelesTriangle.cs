using System;

namespace Task3_Figures
{
    /// <summary>
    /// Представляет равнобедренный треугольник.
    /// </summary>
    public class IsoscelesTriangle : Triangle
    {
        public double BaseSide { get; set; }
        public double Height { get; set; }

        public IsoscelesTriangle(
            double baseSide,
            double height)
        {
            BaseSide = baseSide;
            Height = height;
        }

        ~IsoscelesTriangle()
        {
            Console.WriteLine(
                "Равнобедренный треугольник удалён");
        }

        public override double Area()
        {
            return (BaseSide * Height) / 2;
        }

        public override string GetInfo()
        {
            return $"Равнобедренный треугольник: " +
                   $"основание = {BaseSide}, " +
                   $"высота = {Height}";
        }
    }
}