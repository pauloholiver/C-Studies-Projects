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
            string tipo = data.Substring(data.Length -1, 1);
            int tempo = int.Parse(data.Substring(0, data.Length -1));
            int multiplier = 1;

            if(tipo == "m")
            
            multiplier = 60;

            if(tipo == "s")

            multiplier = 1;

            ReadySetGo(tempo * multiplier);
        }

        static void Cronometrar(int tempo)
        {
            Console.WriteLine("Certo, Contagem iniciando...");
                Console.WriteLine(tempo);
            while(tempo > 0){
                Console.Clear();
                Console.WriteLine(tempo);
                Thread.Sleep(1000);
                tempo--;
            }
            Console.WriteLine("Contagem finalizada. Obrigado");
            Thread.Sleep(2500);
            Menu();
        }

        static void ReadySetGo(int tempo){
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
            Cronometrar(tempo);
            Console.Clear();
            Console.WriteLine("Contagem finalizada. Obrigado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
