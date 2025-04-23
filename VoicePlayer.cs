using System.Media;

namespace CyberAwarenessBot
{
    public static class VoicePlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.PlaySync(); // Waits for audio to finish
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Audio file not found or failed to play.");
                Console.ResetColor();

            // Online site
            // Title: SoundPlayer Class(System.Media)
            // Author: Microsoft
            // Date: 2024
            // URL: https://learn.microsoft.com/en-us/dotnet/api/system.media.soundplayer
            ///Accessed: 20 April 2025.

            }
        }
    }
}
