using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Vamos contar?");
            Console.WriteLine("Atenção!");
            Console.WriteLine("s = segundos");
            Console.WriteLine("m = minutos");
            Console.WriteLine("h = horas");
            Console.WriteLine("f = finaliza contador");
            Console.WriteLine("Gostaria de contar em horas, minutos ou segundos?");
            string tipoTempo = Console.ReadLine().ToLower();
            if (tipoTempo == "f")
                End();
            switch (tipoTempo)
            {
                case "s" : Console.WriteLine("Por quantos segundos gostaria de contar?") ; break;
                case "m" : Console.WriteLine("Por quantos minutos gostaria de contar?") ; break;
                case "h" : Console.WriteLine("Por quantas horas gostaria de contar?"); break;
                default: Menu(); break;
            };            
            int time = int.Parse(Console.ReadLine());
            switch (tipoTempo)
            {
                case "s" : Start(time) ; break;
                case "m" : Start(time*60) ; break;
                case "h" : Start(time*3600); break;
                default: Menu(); break;
            };
        }

        static void Start(int time)
        {
            int currentTime = 0;
            while (time >= currentTime)
            {
                Console.Clear();
                Console.WriteLine("Contando...");
                Console.WriteLine(time);
                time --;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Fim da contagem!");
            Console.WriteLine("Tecle enter para voltar ao menu");
            Console.ReadKey();
            Menu();
        }

        static void End()
        {
            Console.WriteLine("Contador finalizado");
            System.Environment.Exit(0);
        }
    }
}
