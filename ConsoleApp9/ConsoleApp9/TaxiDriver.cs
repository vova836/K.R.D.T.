﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp9
{
    /// <summary>
    /// Создаем класс Водителя такси
    /// </summary>
    class TaxiDriver
    {
        /// <summary>
        /// Этот метод отвечает за поездку и диалог с водителем.
        /// </summary>
        public void ProcessDriveTaxi()
        {
            /// <summary>
            /// Задержка потока которая приостанавливает выполнения программы на 2 секунды
            /// </summary>
            Thread.Sleep(2000);
            /// <summary>
            /// Приезд водителя такси
            /// </summary>
            Console.WriteLine("Приезжает водитель такси:");

            /// <summary>
            /// Задержка потока которая приостанавливает выполнения программы на 2 секунды
            /// </summary>
            Thread.Sleep(2000);
            /// <summary>
            /// Взаимодействие Пользователя и Водителя через конслоль, слова Водителя
            /// </summary>
            Console.WriteLine($"Водитель: Здраствуйте диспетчер мне сообщили куда нам нужно ехать,");
            Console.WriteLine("так что садитесь начинаем выезжать");

            /// <summary>
            /// Взаимодействие Пользователя и Диспетчера через конслоль, слова Пользователя
            /// </summary>
            Console.Write("Пользователь: ");
            string undetion = Console.ReadLine();

            /// <summary>
            /// Сейчас происходит время поездки
            /// </summary>
            Console.WriteLine("В процессе поездки:");

            /// <summary>
            /// Задержка потока которая приостанавливает выполнения программы на 2 секунды
            /// </summary>
            Thread.Sleep(2000);
            /// <summary>
            /// Взаимодействие Пользователя и Водителя через конслоль, слова Пользователя
            /// </summary>
            Console.Write("Пользователь: ");
            string question = Console.ReadLine();

            /// <summary>
            /// Взаимодействие Пользователя и Водителя через конслоль, слова Водителя
            /// </summary>
            Console.WriteLine("Водитель: Мы уже в пути. Сможем доехать через 10 минут.");

            /// <summary>
            /// Взаимодействие Пользователя и Водителя через конслоль, слова Пользователя
            /// </summary>
            Console.Write("Пользователь: ");
            string thankstion = Console.ReadLine();

            /// <summary>
            /// Задержка потока которая приостанавливает выполнения программы на 2 секунды
            /// </summary>
            Thread.Sleep(2000);
            /// <summary>
            /// Происходит завершение поездки
            /// </summary>
            Console.WriteLine("После завершении поездки:");

            /// <summary>
            /// Задержка потока которая приостанавливает выполнения программы на 2 секунды
            /// </summary>
            Thread.Sleep(2000);
            /// <summary>
            /// Взаимодействие Пользователя и Водителя через конслоль, слова Водителя
            /// </summary>
            Console.WriteLine("Водитель: Поездка завершена, с вас 58 рублей.");
            Console.WriteLine("Водитель: Платить будете картой или наличными");

            /// <summary>
            /// Взаимодействие Пользователя и Водителя через конслоль, слова Пользователя
            /// </summary>
            Console.Write("Пользователь: ");
            string payiting = Console.ReadLine();

            /// <summary>
            /// Задержка потока которая приостанавливает выполнения программы на 1 секунды
            /// </summary>
            Thread.Sleep(1000);
            /// <summary>
            /// Происходит оплата водителю
            /// </summary>
            Console.WriteLine("Происходит оплата:");

            /// <summary>
            /// Взаимодействие Пользователя и Водителя через конслоль, слова Водителя
            /// </summary>
            Console.WriteLine("Водитель: Теперь оцените пожалуйста, мою работу по шкале от 1 до 5.");

            /// <summary>
            /// Взаимодействие Пользователя и Водителя через конслоль, слова Пользователя
            /// </summary>
            Console.Write("Пользователь: ");
            int userRating = int.Parse(Console.ReadLine());

            /// <summary>
            /// Взаимодействие Пользователя и Водителя через конслоль, слова Водителя
            /// </summary>
            Console.WriteLine("Водитель: Спасибо за ваш отзыв");
        }
    }
}
