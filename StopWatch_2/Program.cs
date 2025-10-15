using System;

namespace StopWatch
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tete stopwatch");
        }
        static void Start() 
        {
            double time = 10;
            double currentTime = 0;
            while ( currentTime != time) 
            { 
                Console.WriteLine(time);
                currentTime++;
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}