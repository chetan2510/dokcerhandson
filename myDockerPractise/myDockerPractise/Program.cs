using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace myDockerPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("Hello World!");
                Thread.Sleep(1000);
            }
        }
    }
}