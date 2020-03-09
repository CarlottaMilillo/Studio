using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Timers;
namespace ConsolleTimer
{
    class Program
    {
        static System.Timers.Timer _timer = new System.Timers.Timer();

        static int count = 0;
        static void Main(string[] args)
        {
            _timer.Interval = int.Parse(Console.ReadLine());
            _timer.Elapsed += _timer_Elapsed;

            _timer.Start();
            //int x = 0;
            //while(true)
            //{
            //    Thread.Sleep(500);
            //    Console.WriteLine("Thread : =>{0}", x++);
            //    if (x == 100)
            //        break;
            //}
            Console.WriteLine("PREMI UN TASTO PER USCIRE...");
            Console.ReadKey();
        }


        private static void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Timer : => {0}",count++);
            if (count > 50)
                _timer.Stop();
        }
    }
}
