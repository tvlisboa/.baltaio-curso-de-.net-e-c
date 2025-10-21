using System;

namespace StopWatch
{

    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Opções de uso a seguir");
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToUpper();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;

                if (time == 0) 
                    System.Environment.Exit(0);

                preStart(time * multiplier);
            

            Console.WriteLine(type);
            Console.WriteLine(time);
        }

        static void preStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Set...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Go...");
            System.Threading.Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                System.Threading.Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finished!");
            Console.WriteLine("Voltando para o menu");
            System.Threading.Thread.Sleep(2500);
            Menu();
        }
    }  
}