using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp10
{
    class TaxiDispatcher
    {
        public void ProcessTaxiOrder()

        {

            Console.WriteLine("Диспетчер: Здравствуйте, вы хотите заказать такси,");
            Console.WriteLine("теперь укажите, пожалуйста, адрес откуда вас нужно забрать.");

            Console.Write("Пользователь: ");
            string pickupLocation = Console.ReadLine();

            Console.WriteLine("Диспетчер: И куда вас нужно отвезти?");

            Console.Write("Пользователь: ");
            string destination = Console.ReadLine();

            Console.WriteLine("Диспетчер: Приблизительное время подачи такси?");

            Console.Write("Пользователь: ");
            string pickupTime = Console.ReadLine();

            Thread.Sleep(2000);

            Console.WriteLine("Диспетчер: Хорошо, к вам будет отправлено свободное такси.");
            Console.WriteLine("Вы получите уведомление на телефон, когда машина будет назначена.");

            Console.Write("Пользователь: ");
            string udertion = Console.ReadLine();

            Taxi taxi = new Taxi
            {
                CarNumber = "789-CD-789",
                Color = "белый",
                DriverName = "Петров Петр Петрович"
            };

            Thread.Sleep(2000);
            Console.WriteLine($"Диспетчер: Вам назначено такси. Номер машины: {taxi.CarNumber}, цвет: {taxi.Color}. Водитель: {taxi.DriverName}.");

            Console.Write("Пользователь: ");
            string thanktion = Console.ReadLine();

            Console.WriteLine("Приезжает водитель такси");

            Thread.Sleep(2000);
            Console.WriteLine($"Водитель: Здраствуйте диспетчер мне сообщил куда нам нужно ехать,");
            Console.WriteLine("так что садитесь начинаем выезжать");

            Console.Write("Пользователь: ");
            string undetion = Console.ReadLine();


            Console.WriteLine("В процессе поездки:");

            Thread.Sleep(2000);
            Console.Write("Пользователь: ");
            string question = Console.ReadLine();

            Console.WriteLine("Водитель: мы уже в пути. Прибытие ориентировочно через 10 минут.");

            Console.Write("Пользователь: ");
            string thankstion = Console.ReadLine();

            Thread.Sleep(2000);
            Console.WriteLine("По завершении поездки:");

            Thread.Sleep(2000);
            Console.WriteLine("Водитель: Поездка завершена. Оцените, пожалуйста, работу водителя по шкале от 1 до 5.");

            Console.Write("Пользователь: ");
            int userRating = int.Parse(Console.ReadLine());

            Console.WriteLine("Диспетчер: Спасибо за ваш отзыв!");
        }
    }
}
