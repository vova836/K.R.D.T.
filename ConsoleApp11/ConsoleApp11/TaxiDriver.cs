using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp11
{
    class TaxiDriver
    {

        private string[] driverMetting = {
        "Здраствуйте, диспетчер сообщил мне куда нам надо ехать. Готовы ехать?",
        "Добрый день, мне диспетчер сообщил куда вам нужно ехать. Можем мы начать поездку?",
        "Здраствуйте, у меня уже есть информация о вашем пункте назначения. Начинаем выдвигаться?",
        "Здрасьте, диспетчер указал мне информацию куда нам нужна ехать. Выдвигаемся?",

    };
        private string[] driverQuestion = {
        "Хoтите музыку или радио?",
        "Включить вам радио или музыку?",
        "Вам вклюсить радио или музыку?",
        "Радио или музыку вам включить?",
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

            // Проверка на отказ пользователя садиться в автомобиль
            if (pickupLocation.ToLower().Contains("нет") || pickupLocation.ToLower().Contains("нет не готов") || pickupLocation.ToLower().Contains("нет не хочу"))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(1000);
                Console.WriteLine("Водитель: Пожалуйста, сядьте в автомобиль, когда будете готовы.");
                return;
            }
            else if (pickupLocation.ToLower().Contains("нет"))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(1000);
                Console.WriteLine("Водитель: Хорошо, если у вас есть вопросы, я могу помочь вам.");
                return;
            }
            else if (pickupLocation.ToLower().Contains("нет"))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(1000);
                Console.WriteLine("Водитель: Хорошо я могу подождать вас пока не передумайте.");
                return;
            }
            else if (pickupLocation.ToLower().Contains("вещи"))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(1000);
                Console.WriteLine("Водитель: Хорошо я могу подождать пока вы не принесете свой багаж.");
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(1000);
                Console.WriteLine("Водитель: Простите я не могу терпеть ваши действия поэтому уезжаю.");
                Thread.Sleep(1000);
                Console.WriteLine("Водитель уезжает:");
                return;
            }

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
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: Простите не очень понимаю что вы хотите.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(1000);
                Console.WriteLine("Водитель: Хорошо я не включу вам радио или музыку.");
            }
        }
    }
}
