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
            }
        }
    }
}
