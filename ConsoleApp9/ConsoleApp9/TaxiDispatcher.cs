using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp9
{
    /// <summary>
    /// Создаем класс Диспетчер такси
    /// </summary>
    class TaxiDispatcher
    {
        /// <summary>
        /// Этот метод отвечает за обработку процесса принятия заказа на такси от пользователя.
        /// </summary>
        public void ProcessTaxiOrder()
        {
            /// <summary>
            /// Взаимодействие Пользователя и Диспетчера через конслоль, слова Пользователя
            /// </summary>
            Console.Write("Пользователь: ");
            string talktion = Console.ReadLine();

            /// <summary>
            /// Взаимодействие Пользователя и Диспетчера через конслоль, слова Диспетчера
            /// </summary>
            Console.WriteLine("Диспетчер: Здравствуйте, укажите пожалуйста, адрес откуда вас нужно забрать.");

            /// <summary>
            /// Взаимодействие Пользователя и Диспетчера через конслоль, слова Пользователя
            /// </summary>
            Console.Write("Пользователь: ");
            string pickupLocation = Console.ReadLine();

            /// <summary>
            /// Взаимодействие Пользователя и Диспетчера через конслоль, слова Диспетчера
            /// </summary>
            Console.WriteLine("Диспетчер: И куда вас нужно отвезти?");

            /// <summary>
            /// Взаимодействие Пользователя и Диспетчера через конслоль, слова Пользователя
            /// </summary>
            Console.Write("Пользователь: ");
            string destination = Console.ReadLine();

            /// <summary>
            /// Взаимодействие Пользователя и Диспетчера через конслоль, слова Диспетчера
            /// </summary>
            Console.WriteLine("Диспетчер: Приблизительное время подачи такси?");

            /// <summary>
            /// Взаимодействие Пользователя и Диспетчера через конслоль, слова Пользователя
            /// </summary>
            Console.Write("Пользователь: ");
            string pickupTime = Console.ReadLine();

            /// <summary>
            /// Взаимодействие Пользователя и Диспетчера через конслоль, слова Диспетчера
            /// </summary>
            Console.WriteLine("Диспетчер: Хорошо, к вам будет отправлено свободное такси.");
            Console.WriteLine("Диспетчер: Вы получите уведомление на телефон, когда машина будет назначена.");

            /// <summary>
            /// Создаем объект такси, который хранит номер машины, цвет машины и имя водителя
            /// </summary>
            Taxi taxi = new Taxi
            {
                CarNumber = "789-CD-789",
                Color = "белый",
                DriverName = "Петров Петр Петрович"
            };

            /// <summary>
            /// Задержка потока которая приостанавливает выполнения программы на 2 секунды
            /// </summary>
            Thread.Sleep(2000);
            /// <summary>
            /// Появляется Уведомление
            /// </summary>
            Console.WriteLine($"Уведомление: Вам назначено такси. Номер: {taxi.CarNumber}, Цвет: {taxi.Color}. Водитель: {taxi.DriverName}.");
        }
    }
}
