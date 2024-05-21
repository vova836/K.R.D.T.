using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    class TaxiDispatcher
    {
        private string[] dispatcherPhrases = {
        "Здравствуйте, укажите, пожалуйста, адрес откуда вас нужно забрать.",
        "Приветствую! Пожалуйста, укажите место встречи.",
        "Здравствуйте! Куда направимся сегодня?",
        "Добрый день! Ждем вашего заказа.",
        "Здравствуйте, и куда вас нужно отвезти?",
        "Добрый день, куда вы хотите ехать?",
        "Приветствую! Скажите, пожалуйста, куда вам надо приехать?",
        "Спасибо! Ваш заказ принят.",
        "Такси будет у вас через 10 минут.",
        "Ваше такси скоро приедет."
    };
        private string[] dispatcherGoing = {

        private string[] dispatcherTimadialog = {
        "Приблизительное время подачи такси?",
        "Пожалуйста укажите время подачи такси?",
        "Через сколько минут или часов вы хотите чтобы к вам подъехала такси?",
        "Через сколько времени к вам должно подъехать такси?"
    };
        private string[] dispatcherTaxidiases = {
        "Хорошо, к вам будет отправлено свободное такси.",
        "Принято к вам скоро приедет такси",
        "Понял, к вам скоро будет отправлен такси",
        " "
    };
        private string[] inappropriateResponses = {
        "Пожалуйста, не используйте ненормативную лексику.",
        "Попрошу вас говорить культурно.",
        "Давайте общаться без грубостей."
    };

        public void ProcessTaxiOrder()
        {
            Console.Write("Пользователь: ");
            string talktion = Console.ReadLine();

            if (ContainsInappropriateLanguage(talktion))
            {
                RespondWithInappropriateLanguageWarning();
                return;
            }

            Random rand = new Random();
            int index = rand.Next(dispatcherPhrases.Length);
            Console.WriteLine("Диспетчер: " + dispatcherPhrases[index]);

            Console.Write("Пользователь: ");
            string pickupLocation = Console.ReadLine();

            if (ContainsInappropriateLanguage(pickupLocation))
            {
                RespondWithInappropriateLanguageWarning();
                return;
            }

            index = rand.Next(dispatcherPhrases.Length);
            Console.WriteLine("Диспетчер: " + dispatcherTimadialog[index]);

            Console.Write("Пользователь: ");
            string destination = Console.ReadLine();

            if (ContainsInappropriateLanguage(destination))
            {
                RespondWithInappropriateLanguageWarning();
                return;
            }

            index = rand.Next(dispatcherPhrases.Length);
            Console.WriteLine("Диспетчер: " + dispatcherPhrases[index]);

            Console.Write("Пользователь: ");
            string pickupTime = Console.ReadLine();

            if (ContainsInappropriateLanguage(pickupTime))
            {
                RespondWithInappropriateLanguageWarning();
                return;
            }

            Console.WriteLine("Диспетчер: Хорошо, к вам будет отправлено свободное такси.");
            Console.WriteLine("Диспетчер: Вы получите уведомление на телефон, когда машина будет назначена.");

            Taxi taxi = new Taxi
            {
                CarNumber = "789-CD-789",
                Color = "белый",
                DriverName = "Петров Петр Петрович"
            };

            Thread.Sleep(2000);
            Console.WriteLine($"Уведомление: Вам назначено такси. Номер: {taxi.CarNumber}, Цвет: {taxi.Color}. Водитель: {taxi.DriverName}.");
        }

        private bool ContainsInappropriateLanguage(string input)
        {
            string[] inappropriateWords = { "badword1", "badword2", "badword3" }; // Replace with actual inappropriate words
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
            Console.WriteLine("Диспетчер: " + inappropriateResponses[index]);
        }
    }

}

