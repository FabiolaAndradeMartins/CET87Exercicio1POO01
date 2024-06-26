﻿using FormsExercicioCronometro;
namespace CronometroConsole
{
     class Program
    {
         static void Main(string[] args)
        {
            var relogio = new Cronometro();
            Console.WriteLine("Pressione ENTER para iniciar o cronómetro");
            Console.ReadLine();

            relogio.StartClock();
            Console.WriteLine("Pressione ENTER novamente para parar o cronómetro");

            while (relogio.ClockState())
            {
                var tempo = DateTime.Now - relogio.StartTime();
                Console.Write("\r Tempo Corrente: {0}", tempo);
                
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }

            relogio.StopClock();

            Console.WriteLine("\r Tempo Cronometrado: {0}", relogio.GetTimeSpan());
            Console.ReadLine() ;
        }
    }
}