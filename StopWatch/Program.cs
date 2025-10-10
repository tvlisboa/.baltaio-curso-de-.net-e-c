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
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Stop Watch");
            Console.WriteLine(" S = Second");
            Console.WriteLine(" M = Minute");
            Console.WriteLine("How long do you need to count?");

            string value = Console.ReadLine().ToLower();
            char type = char.Parse(value.Substring(value.Length - 1, 1));
            int time = int.Parse(value.Substring(0, value.Length - 1));
            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;
            if(time == 0 || time == null)
                System.Environment.Exit(0);
            PreStart(time * multiplier);
        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready in...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);
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
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stop Watch finalizado.");
            Thread.Sleep(2000);
            Menu();
        }
    }
}