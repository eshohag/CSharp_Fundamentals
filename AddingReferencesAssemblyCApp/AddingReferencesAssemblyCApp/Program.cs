using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace AddingReferencesAssemblyCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);      // to change VoiceGender and VoiceAge check out those links below
            synthesizer.Volume = 100;                                                // (0 - 100)
            synthesizer.Rate = 0;                                                    // (-10 - 10)
            // Synchronous
            synthesizer.Speak("Welcome to our Gossiping Apps");
            // Asynchronous
            synthesizer.SpeakAsync("I'm speaking your girl friend, May I gossiping you, BABY?");                                     // here args = pran



            Console.ReadKey();
        }
    }
}
