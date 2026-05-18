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
            if (baseSide <= 0)
            {
                throw new ArgumentException(
                    "Основание должно быть больше нуля.");
            }
            if (height <= 0)
            {
                throw new ArgumentException(
                    "Высота должна быть больше нуля.");
            }
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