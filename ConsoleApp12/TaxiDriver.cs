using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp12
{
    class TaxiDriver
    {
        private string[] driverMetting = {
        "Здравствуйте, диспетчер сообщил мне куда нам надо ехать. Готовы ехать?",
        "Добрый день, мне диспетчер сообщил куда вам нужно ехать. Можем мы начать поездку?",
        "Здравствуйте, у меня уже есть информация о вашем пункте назначения. Начинаем выдвигаться?",
        "Здрастье, диспетчер указал мне информацию куда нам нужна ехать. Выдвигаемся?"
    };

        private string[] driverQuestion = {
        "Хотите музыку или радио?",
        "Включить вам радио или музыку?",
        "Вам включить радио или музыку?",
        "Радио или музыку вам включить?"
    };

        public void ProcessDriveTaxi()
        {
            Random rand = new Random();
            int index = rand.Next(driverMetting.Length);
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(1000);
            Console.WriteLine("Водитель: " + driverMetting[index]);

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
                    Console.WriteLine("Водитель: Хорошо я включу вам радио.");
                    // Здесь можно добавить код для включения радио
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(1000);
                Console.WriteLine("Водитель: Хорошо, как скажите вы решаете.");
            }
        }
    }
}
