using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExperiments
{
    public class Work
    {
        public int Data1;
        public string Data2;
        public void Run()
        {
            Console.WriteLine(Data1 + ": " + Data2);
        }
    }

    class Program
    {
        public static void Main()
        {
            Work w = new Work();
            w.Data1 = 42;
            w.Data2 = "The Answer to the Ultimate Question of ...";
            Task.Factory.StartNew(w.Run);

            Thread.Sleep(1000);
        }
    }
}
