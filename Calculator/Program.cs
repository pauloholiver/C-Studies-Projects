using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Quanto tempo gostaria de cronometrar?");
            Console.WriteLine("S - Segundos - 10s - 10 Segundos");
            Console.WriteLine("M - Minutos - 2m - 2 Minutos");
            Console.WriteLine("0 - Sair");

            string data =  Console.ReadLine().ToLower();
            string type = data.Substring(data.Length -1, 1); //ignore all caracteres expect the last one (type)
            int time = int.Parse(data.Substring(0, data.Length -1)); //get the first caracteres and ignore the oters (last one)
            int multiplier = 1;

            if(type == "m") //in case of Minutes (2m) -> 120s
            
            multiplier = 60;

            if(type == "s") //in case of Seconds (45s)

            multiplier = 1;

            ReadySetGo(time * multiplier);
        }

        //main function, as long as the time is bigger than 0, keeps the loop active
        static void Countdown(int time)
        {
            Console.WriteLine("Certo, Contagem iniciando...");
                Console.WriteLine(time);
            while(time > 0){
                Console.Clear();
                Console.WriteLine(time);
                Thread.Sleep(1000); //The sleep function make the system interrupt the read by (timer/1000)
                time--;
            }
            Console.WriteLine("Contagem finalizada. Obrigado");
            Thread.Sleep(2500);
            Menu();
        }


        //pre function, just to animate and make that fluid, could be directly to Countdown
        static void ReadySetGo(int time){
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Go!!!");
            Thread.Sleep(3000);
            Console.Clear();
            Countdown(time);
            Console.Clear();
            Console.WriteLine("Contagem finalizada. Obrigado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
