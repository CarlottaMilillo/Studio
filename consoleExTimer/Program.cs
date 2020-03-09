using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace consoleExTimer
{
    class Program
    {
        /// <summary>
        /// entry point, user view 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //call the class with the methods and events the user needs 
            Ring ring = new Ring();
            ring.DisplayDate += Ring_DisplayDate; //active the event
            ring.DisplayGap += Ring_DisplayGap;
            ring.SetAlarm();//method to set the alarm 
            ring.SetGap();//method to set the gap message in seconds 
            ring.StartTime(); //method start 
            while (ring.IsFinished==false)
            {
                Thread.Sleep(100); //pause the program as long as the isfinished is false 
            }
            Console.WriteLine("Press a key to exit ...");
            Console.ReadKey();
        }
        /// <summary>
        /// event to show the gap message 
        /// </summary>
        /// <param name="sender"> string message </param>
        /// <param name="e"> null</param>
        private static void Ring_DisplayGap(object sender, EventArgs e)
        {
            StateObj obj = sender as StateObj;
            Console.Write(obj.Message + "\r");
        }

        /// <summary>
        /// event summoned by the class ring 
        /// </summary>
        /// <param name="sender"> string </param>
        /// <param name="e">null </param>
        private static void Ring_DisplayDate(object sender, EventArgs e)
        {

            //event in wich the parameter passed is shown 
            StateObj obj = sender as StateObj;
            Console.Write(obj.Data + "\r");
   
        }
    }
}
