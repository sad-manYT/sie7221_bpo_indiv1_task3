using System;

namespace Task3_Figures
{
    /// <summary>
    /// Представляет квадрат.
    /// </summary>
    public class Square : Quadrilateral
    {
        /// <summary>
        /// Сторона квадрата.
        /// </summary>
        public double Side { get; set; }

        /// <summary>
        /// Инициализирует квадрат.
        /// </summary>
        /// <param name="side">Длина стороны.</param>
        public Square(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException(
                    "Сторона должна быть больше нуля.");
            }

            Side = side;
        }

        ~Square()
        {
            Console.WriteLine("Квадрат удалён");
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override string GetInfo()
        {
            return $"Квадрат: сторона = {Side}";
        }
    }
}