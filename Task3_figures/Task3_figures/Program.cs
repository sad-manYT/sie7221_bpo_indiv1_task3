using System;

namespace Task3_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding =
                System.Text.Encoding.UTF8;

            Console.WriteLine(
                "=== Работа с фигурами ===\n");

            double squareSide =
                ReadDouble(
                    "Введите сторону квадрата: ");

            double isoBase =
                ReadDouble(
                    "Введите основание " +
                    "равнобедренного " +
                    "треугольника: ");

            double isoHeight =
                ReadDouble(
                    "Введите высоту " +
                    "равнобедренного " +
                    "треугольника: ");

            double rightA =
                ReadDouble(
                    "Введите катет A: ");

            double rightB =
                ReadDouble(
                    "Введите катет B: ");

            double equilateralSide =
                ReadDouble(
                    "Введите сторону " +
                    "равностороннего " +
                    "треугольника: ");

            Figure[] figures =
            {
                new Square(squareSide),

                new IsoscelesTriangle(
                    isoBase,
                    isoHeight),

                new RightTriangle(
                    rightA,
                    rightB),

                new EquilateralTriangle(
                    equilateralSide)
            };

            Console.WriteLine(
                "\nИнформация о фигурах:\n");

            foreach (Figure figure in figures)
            {
                Console.WriteLine(
                    figure.GetInfo());

                Console.WriteLine(
                    $"Площадь: " +
                    $"{figure.Area():F2}");

                Console.WriteLine(
                    new string('-', 40));
            }

            Console.WriteLine(
                "\nНажмите любую клавишу...");
            Console.ReadKey();
        }

        /// <summary>
        /// Считывает число
        /// с клавиатуры.
        /// </summary>
        /// <param name="message">
        /// Сообщение пользователю.
        /// </param>
        /// <returns>
        /// Введенное число.
        /// </returns>
        private static double ReadDouble(
            string message)
        {
            double result;

            while (true)
            {
                Console.Write(message);

                if (double.TryParse(
                    Console.ReadLine(),
                    out result)
                    && result > 0)
                {
                    return result;
                }

                Console.WriteLine(
                    "Ошибка ввода. " +
                    "Введите число больше нуля.");
            }
        }
    }
}