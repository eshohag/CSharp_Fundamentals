using System;
using System.Timers;

namespace TimerExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer aTimer = new Timer(500);
            aTimer.Elapsed += ATimer_Elapsed;
            aTimer.Elapsed += ATimer_Elapsed1;
            aTimer.Start();
            Console.WriteLine("Press Enter to Remove the Red Event:");
            Console.ReadLine();
            aTimer.Elapsed -= ATimer_Elapsed1;


            Console.ReadKey();
        }

        private static void ATimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed Two: {0:HH:mm:ss}", e.SignalTime);
        }

        private static void ATimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed One: {0:HH:mm:ss}", e.SignalTime);
        }
    }
}
