﻿using System;

namespace Task3_Figures
{
    /// <summary>
    /// Абстрактный базовый класс фигуры.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса Figure.
        /// </summary>
        protected Figure()
        {
            Console.WriteLine(
                $"Создан объект {GetType().Name}");
        }

        /// <summary>
        /// Финализатор класса Figure.
        /// </summary>
        ~Figure()
        {
            Console.WriteLine(
                $"Удалён объект {GetType().Name}");
        }

        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public abstract double Area();

        /// <summary>
        /// Возвращает информацию о фигуре.
        /// </summary>
        /// <returns>Строка с информацией.</returns>
        public virtual string GetInfo()
        {
            return $"Тип фигуры: {GetType().Name}";
        }
    }
}