using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace timerflow
{
    class Program
    {
        /// <summary>
        /// entry point, user program 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //creating class reference 
            Sveglia _sveglia = new Sveglia();
            //using the event of the class i created (non static)
            _sveglia.ShowDate += _sveglia_ShowDate;
            _sveglia.AskAlarm(); //methos that asks the alarm 
            _sveglia.InputGap(); //metodo di inpput gap 
            _sveglia.ShowGap += _sveglia_ShowGap; //using the method 
            _sveglia.StartTime();//calling the method to start the timer (not static )  


            while (_sveglia.IsDone == false) //while the bool is false keep blocking the program 
            {
                Thread.Sleep(100); //wait for the program to start class system threading 
            }

            Console.WriteLine("Press a key to exit...");
            Console.ReadKey();

        }
        /// <summary>
        /// event show the gap of seconds 
        /// </summary>
        /// <param name="sender">object passed from the other class, inthis case's just a string </param>
        /// <param name="e"> int his case is null </param>
        private static void _sveglia_ShowGap(object sender, EventArgs e)
        {
            //class object 
            string obj = sender as string;
            //writing on console the varibales 
            Console.Write(obj);
        }

        #region evento

        /// <summary>
        /// event hadled by the user
        /// </summary>
        /// <param name="sender"> parameter datetime string from the StateObject Class </param>
        /// <param name="e"> null </param>
        private static void _sveglia_ShowDate(object sender, EventArgs e)
        {
            // assigning to a variable the parameter passed from the event
            StateObject obj = sender as StateObject;
            //writing on the console the passed parameter 
            Console.Write(obj.data + "\r");

        }
        #endregion
    }
}
