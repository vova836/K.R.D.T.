using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;

namespace ConsoleApp12
{
    class TaxiDispatcher
    {
        private string[] dispatcherMetting = {
        "Здравствуйте, укажите пожалуйста, адрес откуда вас нужно забрать.",
        "Здраствуйте! Пожалуйста, укажите свое место назначения.",
        "Здраствуйте, укажите пожалуйста ваш адрес.",
        "Здраствуйте, пожалуйста укажите где вы сейчас находитесь."
    };
        private string[] dispatcherGoing = {
        "И куда вас нужно отвезти?",
        "Теперь скажите, куда вы хотите ехать?",
        "Скажите, пожалуйста, куда вам надо ехать?",
        "Куда вам нужно направиться сегодня?"
    };
        private string[] dispatcherTimadialog = {
        "Приблизительное время подачи такси?",
        "Пожалуйста укажите время подачи такси?",
        "Через сколько минут или часов вы хотите чтобы к вам подъехала такси?",
        "Через сколько времени к вам должно подъехать такси?"
    };
        private string[] dispatcherTaxidiases = {
        "Хорошо! Ваш заказ принят, к вам приедет свободное такси",
        "Хорошо, к вам будет отправлено свободное такси.",
        "Принято к вам скоро приедет такси",
        "Понял, к вам скоро будет отправлен такси"
    };
        private string[] inappropriateResponses = {
        "Пожалуйста, не используйте ненормативную лексику. Мы хотим вам помочь.",
        "Попрошу вас говорить культурно. Мы здесь, чтобы помочь вам.",
        "Давайте общаться без грубостей. Чтобы вы смоги нормально поехать.",
        "Пожалуйста ведите себя прилично."
    };

        public void ProcessTaxiOrder()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("Пользователь: ");
            string talktion = Console.ReadLine();

            if (ContainsInappropriateLanguage(talktion))
            {
                RespondWithInappropriateLanguageWarning();
                return;
            }

            Random rand = new Random();
            int index = rand.Next(dispatcherMetting.Length);
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(1000);
            Console.WriteLine("Диспетчер: " + dispatcherMetting[index]);

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("Пользователь: ");
            string pickupLocation = Console.ReadLine();

            if (ContainsInappropriateLanguage(pickupLocation))
            {
                RespondWithInappropriateLanguageWarning();
                return;
            }

            index = rand.Next(dispatcherGoing.Length);
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(1000);
            Console.WriteLine("Диспетчер: " + dispatcherGoing[index]);

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("Пользователь: ");
            string destination = Console.ReadLine();

            if (ContainsInappropriateLanguage(destination))
            {
                RespondWithInappropriateLanguageWarning();
                return;
            }

            index = rand.Next(dispatcherTimadialog.Length);
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(1000);
            Console.WriteLine("Диспетчер: " + dispatcherTimadialog[index]);

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("Пользователь: ");
            string pickupTime = Console.ReadLine();

            if (ContainsInappropriateLanguage(pickupTime))
            {
                RespondWithInappropriateLanguageWarning();
                return;
            }


            index = rand.Next(dispatcherTaxidiases.Length);
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(1000);
            Console.WriteLine("Диспетчер: " + dispatcherTaxidiases[index]);
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(1000);
            Console.WriteLine("Диспетчер: Также вы получите уведомление на телефон, какая машина к вам приедет и кто водитель.");
            
            Taxi taxi = new Taxi
            {
                CarNumber = "789-CD-789",
                Color = "белый",
                DriverName = "Петров Петр Петрович"
            };

            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(3000);
            Console.WriteLine($"Уведомление: Вам назначено такси.");
            Console.WriteLine($"Уведомление: Номер машины {taxi.CarNumber}");
            Console.WriteLine($"Уведомление: Цвет машины {taxi.Color}");
            Console.WriteLine($"Уведомление: Водитель такси {taxi.DriverName} ");
        }

        private bool ContainsInappropriateLanguage(string input)
        {
            string[] inappropriateWords = { "блядь", "сука", "нахуй", "хуй", "ебать", "пиздец" }; // Add more inappropriate words as needed
            foreach (string word in inappropriateWords)
            {
                if (Regex.IsMatch(input, @"\b" + Regex.Escape(word) + @"\b", RegexOptions.IgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void RespondWithInappropriateLanguageWarning()
        {
            Random rand = new Random();
            int index = rand.Next(inappropriateResponses.Length);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Диспетчер: " + inappropriateResponses[index]);
        }
    }
}


