using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp11
{
    class TaxiDriver
    {
        // Фразы водителя для разнообразия
        private string[] driverPhrases = {
        "Здравствуйте, диспетчер! Мне сообщили куда нам нужно ехать, так что садитесь, начинаем выезжать.",
        "Приветствую! Давайте выезжать, я уже готов.",
        "Привет! Пристегнитесь, поехали.",
        "Здравствуйте! Куда направимся сегодня?",
        // Добавьте еще фразы по вашему усмотрению
    };

        public void ProcessDriveTaxi()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Приезжает водитель такси:");

            Thread.Sleep(2000);
            Random rand = new Random();
            int index = rand.Next(driverPhrases.Length);
            Console.WriteLine($"Водитель: {driverPhrases[index]}");

            Console.Write("Пользователь: ");
            string undetion = Console.ReadLine();

            Console.WriteLine("В процессе поездки:");

            Thread.Sleep(2000);
            Console.Write("Пользователь: ");
            string question = Console.ReadLine();

            Console.WriteLine("Водитель: Мы уже в пути. Сможем доехать через 10 минут.");

            Console.Write("Пользователь: ");
            string thankstion = Console.ReadLine();

            Thread.Sleep(2000);
            Console.WriteLine("После завершения поездки:");

            Thread.Sleep(2000);
            Console.WriteLine("Водитель: Поездка завершена, с вас 58 рублей.");
            Console.WriteLine("Водитель: Платить будете картой или наличными");

            Console.Write("Пользователь: ");
            string payiting = Console.ReadLine();

            Thread.Sleep(1000);
            Console.WriteLine("Происходит оплата:");

            Console.WriteLine("Водитель: Теперь оцените, пожалуйста, мою работу по шкале от 1 до 5.");

            Console.Write("Пользователь: ");
            int userRating = int.Parse(Console.ReadLine());

            Console.WriteLine("Водитель: Спасибо за ваш отзыв");
        }
    }
}
