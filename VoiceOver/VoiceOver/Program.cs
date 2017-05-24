using System;
using System.Speech.Synthesis;

namespace VoiceOver
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Volume = 100;
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synth.SpeakAsync("I love you");
            Console.ReadKey();
        }
    }
}
