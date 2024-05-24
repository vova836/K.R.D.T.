using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp13
{
    class TaxiDriver
    {
        private string[] driverMetting = {
        "Здравствуйте, диспетчер сообщил мне куда нам надо ехать.",
        "Добрый день, мне диспетчер сообщил куда вам нужно ехать.",
        "Здравствуйте, у меня уже есть информация о вашем пункте назначения.",
        "Здрастье, диспетчер указал мне куда нам нужна ехать."
    };
        private string[] driverSaying = {
        "Так что садитесь начинаем выезжать.",
        "Садитесь мы сейчас выезжаем",
        "Садитесь, начинаем выезжать"
    };
        private string[] driverQuestion = {
        "Хотите музыку или радио?",
        "Включить вам радио или музыку?",
        "Вам включить радио или музыку?",
        "Радио или музыку вам включить?"
    };
        private string[] driverSayingAgtion = {
        "Может вам все таки включить музыку или радио",
        "Вам похоже скучно, включить вам все таки радио",
        "Выгледите уставшим, может включить вам музыку"
    };
        public void ProcessDriveTaxi()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            /// <summary>
            /// Задержка потока которая приостанавливает выполнения программы на 2 секунды
            /// </summary>
            Thread.Sleep(2000);
            /// <summary>
            /// Приезд водителя такси
            /// </summary>
            Console.WriteLine("Приезжает водитель такси:");

            Random rand = new Random();
            int index = rand.Next(driverMetting.Length);
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(1000);
            Console.WriteLine("Водитель: " + driverMetting[index]);

            Random rands = new Random();
            int indax = rand.Next(driverSaying.Length);
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(1000);
            Console.WriteLine("Водитель: " + driverSaying[index]);

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("Пользователь: ");
            string pickupLocation = Console.ReadLine();

            index = rand.Next(driverQuestion.Length);
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(1000);
            Console.WriteLine("Водитель: " + driverQuestion[index]);

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("Пользователь: ");
            string destination = Console.ReadLine();

            // Проверка на наличие слова "нет" в ответе пользователя
            if (!destination.ToLower().Contains("нет"))
            {
                if (destination.ToLower().Contains("музыка"))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: Хорошо я включу вам музыку.");
                    // Здесь можно добавить код для включения музыки
                }
                else if (destination.ToLower().Contains("музыку"))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: Хорошо я включу вам музыку.");
                }
                else if (destination.ToLower().Contains("радио"))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: Хорошо,включу вам радио.");
                    // Здесь можно добавить код для включения радио
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(1000);
                Console.WriteLine("Водитель: Хорошо, как скажите, вам решать.");
            }


            // В процессе поездки
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(2000);
            Console.WriteLine("В процессе поездки:");

        }
    }
}