using System;
using System.Media; // For SoundPlayer


namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Play audio in the background
            PlayVoiceGreeting("greeting.wav");

            // 2. Show ASCII logo and styled welcome at the same time
            DisplayWelcomeArt();

            // 3. Start chatbot interaction
            StartChat();
        }

        static void PlayVoiceGreeting(string filePath)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(filePath);
                player.Play(); // Play asynchronously
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Warning] Audio greeting failed to play: {ex.Message}");
                Console.ResetColor();

                Console.WriteLine("Hello and welcome to the Cybersecurity Chatbot!");
            }
        }


        static void DisplayWelcomeArt()
        {

          //ASCII logo text          
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"
  
             __       ____      _               _               _     _       
  ___  __ _ / _| ___ / ___|   _| |__   ___ _ __| |__  _   _  __| | __| |_   _ 
 / __|/ _` | |_ / _ \ |  | | | | '_ \ / _ \ '__| '_ \| | | |/ _` |/ _` | | | |
 \__ \ (_| |  _|  __/ |__| |_| | |_) |  __/ |  | |_) | |_| | (_| | (_| | |_| |
 |___/\__,_|_|  \___|\____\__, |_.__/ \___|_|  |_.__/ \__,_|\__,_|\__,_|\__, |
                          |___/                                         |___/ 

    ");
                Console.ResetColor();

            //subtitle 
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================");
            Console.WriteLine("     WELCOME TO CYBERSECURITY BOT");
            Console.WriteLine("=======================================");
            Console.ResetColor();
        }

        static void StartChat()
        {
            Console.Write("\nWhat is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine($"\nHello, {userName}! I’m here to help you stay safe online.");
            Console.WriteLine("You can ask me about phishing, password safety, or safe browsing.");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
                    continue;
                }

                if (input.Contains("exit") || input.Contains("bye"))
                {
                    Console.WriteLine("Goodbye! Stay safe online.");
                    break;
                }

                // Basic responses
                if (input.Contains("how are you"))
                    Console.WriteLine("I'm doing well, thank you! Always alert for cyber threats.");
                else if (input.Contains("purpose"))
                    Console.WriteLine("I'm here to teach you how to stay safe online.");
                else if (input.Contains("phishing"))
                    Console.WriteLine("Phishing is a form of cybercrime in which perpetrators use misleading emails, texts, or websites to deceive individuals into disclosing sensitive information such as login credentials, credit card numbers, or other personal details. This type of social manipulation seeks to acquire important data or implement malware. Never click suspicious links!");
                else if (input.Contains("password"))
                    Console.WriteLine("Robust and safe passwords are essential for cybersecurity. Passwords safeguard accounts and sensitive information from unauthorized access, serving as the initial barrier against cyber threats. Developing robust, distinctive passwords and employing best practices such as multi-factor authentication can greatly improve security. Never reuse them.");
                else if (input.Contains("browsing"))
                    Console.WriteLine("Use secure sites (https), avoid popups, and don’t download unknown files.");
                else
                    Console.WriteLine("That’s an interesting question. Try asking me about phishing, passwords, or safe browsing.");
            }
        }
    }
}


// Code attribution A
// This method was taken from Stack Overflow

// https://stackoverflow.com/questions/35049491/soundplayer-play-doesnt-play-sound

// User: Matthew Watson  
// https://stackoverflow.com/users/87398/matthew-watson

// ASCII Art generated using: B
// Patorjk (n.d.) Text to ASCII Art Generator (TAAG). [online]
// Available at: https://patorjk.com/software/taag/ [Accessed 23 Apr. 2025]

// Code Attribution  C
// This method was taken from GeeksforGeeks  
// https://www.geeksforgeeks.org/c-sharp-if-else-statement/

// Author: GeeksforGeeks Editorial Team  
// https://www.geeksforgeeks.org

// Code Attribution D  
// This method was taken from W3Schools  
// https://www.w3schools.com/cs/cs_strings.php

// Author: W3Schools Editorial Team  
// https://www.w3schools.com