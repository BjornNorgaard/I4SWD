using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace derpspace
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //// Parallel For
            //Parallel.For(0, 10, i =>
            //{
            //    Console.WriteLine(i);
            //});

            ////// Parallel Foreach
            ////string[] ord = {"Hej", "Hello", "Daws"};

            ////Parallel.ForEach(ord, derp =>
            ////{
            ////    Console.WriteLine(derp);
            ////});

            //// for med startnew
            //for (int i = 0; i < 10; i++)
            //{
            //    int tmp = i;
            //    Task.Factory.StartNew(() => Console.WriteLine("oji" + i));
            //}

            //Thread.Sleep(1000);

            Console.WriteLine(Environment.ProcessorCount);
        }
    }
}