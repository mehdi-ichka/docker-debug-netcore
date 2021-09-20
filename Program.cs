using System;
using System.Threading;

namespace DockerDebugApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread.Sleep(15000);
            Console.WriteLine("Place break point here");
        }
    }
}
