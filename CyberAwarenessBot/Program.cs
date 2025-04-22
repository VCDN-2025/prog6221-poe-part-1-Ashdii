using System;

namespace CyberAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            VoicePlayer.PlayGreeting();
            ConsoleUI.DisplayAsciiArt();

            ConsoleUI.TypeEffect("Hello! Welcome to the Cybersecurity Awareness Bot.");
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("Name cannot be empty. Please enter your name: ");
                userName = Console.ReadLine();
            }

            ConsoleUI.TypeEffect($"Welcome, {userName}! I'm here to help you stay safe online.");
            ConsoleUI.PrintDivider();

            Chatbot bot = new Chatbot(userName);
            bot.StartConversation();
        }
    }
}

