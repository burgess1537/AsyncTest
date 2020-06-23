using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World! Main Thread:  {Thread.CurrentThread.ManagedThreadId }");
            //AnotherMethod();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"i:  {i }");
                AnotherMethod(i);
            }
            Console.WriteLine($"Finish AnotherMethod():  {Thread.CurrentThread.ManagedThreadId }");
            Console.Read();
        }
        static async void AnotherMethod(int i)
        {
            //await Task.Delay(2000);
            //Console.WriteLine($"async await complete {Thread.CurrentThread.ManagedThreadId }");
            await Task.Delay(10);
            Console.WriteLine($"async await not complete {Thread.CurrentThread.ManagedThreadId + "  " + i.ToString() }");
            Console.WriteLine($"async await complete {Thread.CurrentThread.ManagedThreadId + "  " + i.ToString() + "  "+DateTime.Now.ToString("HH:mm:ss.ffff") }");
        }
    }
}
