using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timerflow
/*Carlotta Milillo, 04/03/2020, version 1.0 
 * 
 * 

*/
{

    /// <summary>
    /// class that contains classes, methos and properties of system.timers.timer
    /// </summary>
    public class Sveglia

    {

        //callin the system class:
        static System.Timers.Timer _timer = new System.Timers.Timer(); //i inherit all the classes and methods 

        /// <summary>
        /// bool to test if the minute has passed  
        /// </summary>
        public bool IsDone { get; set; } = false; //set to false because i have to block the program as long as it's false; useless if in a while parentesis 
        /// <summary>
        /// int set by the user in input 
        /// </summary>
        private int Alarm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        private int gap { get; set; }
        /// <summary>
        /// index of how many minutes passed 
        /// </summary>
        private int Count { get; set; } = 0;

        #region constructor
        /// <summary>
        /// constructor to set the timer from the system class 
        /// </summary>
        public Sveglia()
        {
            //using event from timers.timer
            _timer.Elapsed += _timer_Elapsed;
            
            //setting the interval of one second 
            _timer.Interval = 1000;
        }



        #endregion

        #region events 
        /// <summary>
        /// event from timers timer that will be set with other paramethers 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
            //here i will put the parameters i need 
            StateObject obj = new StateObject
            {
                //inserting the datetime in the variable data
                data = DateTime.Now.ToString("HH.mm.ss")

            };
            Count++; //index 
            if (Alarm == Count / 60) //when the alarm that sets the minutes is equal to the count divided 60 which is equal to the minutes 
            {
                IsDone = true; //set isDone to true and break 
                _timer.Stop();
                Console.WriteLine("\nAllarme avvenuto!");
            }
            //inserting the class with the variables in the event that the user will call 
            ShowDate(obj, null);

            if(Count % gap == 0) //when the rest between the two values is 0 
            {
                string a = string.Format("\nSono passati {0} secondi!\n", Count);
                ShowGap(a, null);
            }
        }
        //event to show to the user 
        public event EventHandler ShowDate;
        
        //event to show an alert each tot seconds
        public event EventHandler ShowGap;
        #endregion

        #region methods 
        /// <summary>
        /// method for the user to add a gap  
        /// </summary>
        public void InputGap()
        {
            Console.WriteLine("Please, insert the gap between alarms in seconds...");
            gap = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// method to ask the minutes that have to pass before the alarm 
        /// </summary>
        /// <returns></returns>
        public void AskAlarm()
        {
            Console.WriteLine("please, insert the Alarm:");
            //setting the variable int created in the class with the input of the user 
            Alarm = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// method to start the timer 
        /// </summary>
        public void StartTime()
        {
            //method from system .timers to start the timer 
            //it has to be called from the main so it has to be public and static since we are working in console 
            _timer.Start();
        }
        #endregion 

    }
    #region class object
    /// <summary>
    /// class of structures for the setting of the parameters to give to the event 
    /// </summary>
    class StateObject
    {
        /// <summary>
        /// variable that will contain the datetime.now
        /// </summary>
        public string data { get; set; }

    }
    class StateMessage
    {
        /// <summary>
        /// distance between alarms in seconds 
        /// </summary>
        public int Gap { get; set; }
        /// <summary>
        /// counting the number of seconds to show the gap message 
        /// </summary>
        public int _count { get; set; }
        /// <summary>
        /// variable that contains the message shown in the gap event 
        /// </summary>
        public string Message { get; set; }
    }
    #endregion
}
