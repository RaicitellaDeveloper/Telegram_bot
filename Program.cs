using System;
using System.Security.Cryptography;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;
using static System.Net.WebRequestMethods;

internal class Program
{
    private static string token { get; set; } = "7162891662:AAGJpUepEvYHaAYPBeENQnZGc54GNU175dA";
    private static TelegramBotClient client;

    static int[] list = new int[12];

    private static void Main(string[] args)
    {
        client = new TelegramBotClient(token);
        client.StartReceiving();
        client.OnMessage += OnMessageHandler;
        Console.ReadLine();
        client.StopReceiving();
    }

    private static async void OnMessageHandler(object? sender, MessageEventArgs e)
    {
        var msg = e.Message;
        if (msg.Text != null & msg.Text != "Привет" & msg.Text != "Привет!" & msg.Text != "Как дела?" & msg.Text != "/start"& msg.Text != "Какое сегодня число?")
        {
            Console.WriteLine($"Your msg: {msg.Text}");
            await client.SendTextMessageAsync(msg.Chat.Id, $"Ваше сообщение:  {msg.Text}", replyToMessageId: msg.MessageId);
        }

        else if (msg.Text == "Привет" | msg.Text == "Привет!")
        {
            Console.WriteLine($"Hello!");
            await client.SendTextMessageAsync(msg.Chat.Id, $"Приветствую!", replyToMessageId: msg.MessageId);
        }
        else if (msg.Text == "Как дела?")
        {
            Console.WriteLine($"norm");
            await client.SendTextMessageAsync(msg.Chat.Id, $"Норм", replyToMessageId: msg.MessageId);
        }
        else if (msg.Text == "/start")
        {
            Console.WriteLine($"START");
            await client.SendTextMessageAsync(msg.Chat.Id, $"ДОБРО ПОЖАЛОВАТЬ!");
            await client.SendTextMessageAsync(msg.Chat.Id, msg.Text, replyMarkup: GetButtons());
        }
        //январь
        list[0] = 31;
        //февраль
        list[1] = 29;
        //март
        list[2] = 31;
        //апрель
        list[3] = 30;
        //май
        list[4] = 31;
        //июнь
        list[5] = 30;
        //июль
        list[6] = 31;
        //август
        list[7] = 31;
        //сентябрь
        list[8] = 30;
        //октябрь
        list[9] = 31;
        //ноябрь
        list[10] = 30;
        //декбрь
        list[11] = 31;

        if (msg.Text == "Какое сегодня число?")
        {
            Console.WriteLine($"A");

            DateTime thisday = DateTime.Today;
            string s = thisday.ToString();
            //System.Console.WriteLine(thisday.ToString("D"));
            //месяц
            string t = $"{s[3]}{s[4]}";

            //число
            string a = $"{s[0]}{s[1]}";
            int b = Convert.ToInt32(a);
            //System.Console.WriteLine($"{t}");


            //await client.SendTextMessageAsync(msg.Chat.Id, $"сегодня число: {b}", replyToMessageId: msg.MessageId);

            if (t == "02")
            {
                int d = list[7] + list[8] + list[9] + list[10] + list[11] + list[0] + b;
                await client.SendTextMessageAsync(msg.Chat.Id, $"{d} августа", replyToMessageId: msg.MessageId);
                System.Console.WriteLine($"{d} августа");
            }
            else if (t == "01")
            {
                int d = list[7] + list[8] + list[9] + list[10] + list[11] + b;
                await client.SendTextMessageAsync(msg.Chat.Id, $"{d} августа", replyToMessageId: msg.MessageId);
                System.Console.WriteLine($"{d} августа");
            }
            else if (t == "03")
            {
                int d = list[7] + list[8] + list[9] + list[10] + list[11] + list[0] + list[1] + b;
                await client.SendTextMessageAsync(msg.Chat.Id, $"{d} августа", replyToMessageId: msg.MessageId);
                System.Console.WriteLine($"{d} августа");
            }
            else if (t == "04")
            {
                int d = list[7] + list[8] + list[9] + list[10] + list[11] + list[0] + list[1] + list[2] + b;
                await client.SendTextMessageAsync(msg.Chat.Id, $"{d} августа", replyToMessageId: msg.MessageId);
                System.Console.WriteLine($"{d} августа");
            }
            else if (t == "05")
            {
                int d = list[7] + list[8] + list[9] + list[10] + list[11] + list[0] + list[1] + list[2] + list[3] + b;
                await client.SendTextMessageAsync(msg.Chat.Id, $"{d} августа", replyToMessageId: msg.MessageId);
                System.Console.WriteLine($"{d} августа");
            }
            else if (t == "06")
            {
                int d = b;
                await client.SendTextMessageAsync(msg.Chat.Id, $"{d} июня", replyToMessageId: msg.MessageId);
                System.Console.WriteLine($"{d} июня");
            }
            else if (t == "07")
            {
                int d = b;
                await client.SendTextMessageAsync(msg.Chat.Id, $"{d} июля", replyToMessageId: msg.MessageId);
                System.Console.WriteLine($"{d} июля");
            }
            else if (t == "08")
            {
                int d = b;
                await client.SendTextMessageAsync(msg.Chat.Id, $"{d} августа", replyToMessageId: msg.MessageId);
                System.Console.WriteLine($"{d} августа");
            }
            else if (t == "09")
            {
                int d = list[7] + b;
                await client.SendTextMessageAsync(msg.Chat.Id, $"{d} августа", replyToMessageId: msg.MessageId);
                System.Console.WriteLine($"{d} августа");
            }
            else if (t == "10")
            {
                int d = list[7] + list[8] + b;
                await client.SendTextMessageAsync(msg.Chat.Id, $"{d} августа", replyToMessageId: msg.MessageId);
                System.Console.WriteLine($"{d} августа");
            }
            else if (t == "11")
            {
                int d = list[7] + list[8] + list[9] + b;
                await client.SendTextMessageAsync(msg.Chat.Id, $"{d} августа", replyToMessageId: msg.MessageId);
                System.Console.WriteLine($"{d} августа");
            }
            else if (t == "12")
            {
                int d = list[7] + list[8] + list[9] + list[10] + b;
                await client.SendTextMessageAsync(msg.Chat.Id, $"{d} августа", replyToMessageId: msg.MessageId);
                System.Console.WriteLine($"{d} августа");
            }


        }











    }

    private static IReplyMarkup GetButtons()
    {
        return new ReplyKeyboardMarkup
        {
            Keyboard = new List<List<KeyboardButton>>
            {
                new List<KeyboardButton>{ new KeyboardButton {Text = "Привет" }, new KeyboardButton { Text = "Как дела?" } },
                new List<KeyboardButton>{ new KeyboardButton {Text = "Какое сегодня число?" }, new KeyboardButton { Text = "/start" } }

            }
            
        };
    }
}