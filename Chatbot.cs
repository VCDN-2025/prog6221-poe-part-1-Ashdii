using System;

namespace CyberAwarenessBot
{
    public class Chatbot
    {
        private string userName;

        public Chatbot(string name)
        {
            userName = name;
        }

        public void StartConversation()
        {
            bool running = true;

            while (running)
            {
                ConsoleUI.PrintDivider();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n{userName}, you can either type a question or choose an option from the list below:");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1. How are you?");
                Console.WriteLine("2. What’s your purpose?");
                Console.WriteLine("3. What can I ask you about?");
                Console.WriteLine("4. Password Safety");
                Console.WriteLine("5. Phishing Scams");
                Console.WriteLine("6. Safe Browsing Practices");
                Console.WriteLine("0. Exit");
                Console.ResetColor();

                Console.Write("\nEnter your question or option number: ");
                string input = Console.ReadLine()?.ToLower().Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("⚠️ I didn’t quite understand that. Could you rephrase or choose a valid option?");
                    continue;
                }

                switch (input)
                {
                    case "1":
                    case "how are you":
                        Console.WriteLine("🤖 I'm just code, but I'm here to help you stay safe online!");
                        break;

                    case "2":
                    case "what’s your purpose":
                    case "whats your purpose":
                        Console.WriteLine("🎯 My purpose is to educate South Africans about cybersecurity threats and safe practices.");
                        break;

                    case "3":
                    case "what can i ask you about":
                        Console.WriteLine("💬 You can ask me about:\n- Password Safety\n- Phishing Scams\n- Safe Browsing Practices");
                        break;

                    case "4":
                    case "password safety":
                        Console.WriteLine("🔐 Tip: Use strong, unique passwords for each site. Enable two-factor authentication (2FA) when possible.");
                        break;

                    case "5":
                    case "phishing scams":
                        Console.WriteLine("🎣 Beware of emails asking for personal info. Check the sender address and don’t click suspicious links!");
                        break;

                    case "6":
                    case "safe browsing practices":
                        Console.WriteLine("🌐 Stick to secure websites (look for HTTPS), avoid pirated content, and use antivirus software.");
                        break;

                    case "0":
                    case "exit":
                        Console.WriteLine($"👋 Goodbye, {userName}. Stay safe online!");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("⚠️ I didn’t quite understand that. Try selecting an option from the list or rephrasing your question.");
                        break;

                        // Online site
                        //Title: Cybersecurity Awareness Tips
                        //Author: South African Government
                        //Date: 2023
                        //URL: https://www.cybersecurityhub.gov.za/
                        //Accessed: 20 April 2025.

                        // Online site
                        //Title: Creating A Simple Bot Application Using Microsoft Bot Framework
                        //Author: C# Corner
                        //Date: 2024
                        //URL: https://www.c-sharpcorner.com/article/creating-a-simple-bot-application-using-microsoft-bot-framew/
                        //Accessed: 19 April 2025.
                }
            }
        }
    }
}

