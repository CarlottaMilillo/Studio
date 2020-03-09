using System;

namespace libreriaclassi
{
    /* Carlotta Milillo, 05-03-2020, version 1.1*/
    /* the program will show a datetime with the counting seconds in whch the user will set a gap and an Alarm to be shown once 
     the time's up and each time the seconds have passed */
    //WHAT DOES THE USER NEED TO SET ?
    /*1.ALARM
      2.GAP
      3. BOOL to block the program in a loop
      4. COUNT  to have the messages */

    #region class Ring
    /// <summary>
    /// main class with methods, events etc
    /// </summary>
    public class Ring
    {
        StateObj st = new StateObj();
         public TimeSpan _timeSpan = new TimeSpan(0, 0, 0);
       
        #region private class
        /*BEGIN*/
        System.Timers.Timer _timer = new System.Timers.Timer(); //call the class timers timer to use the event of the tick and then set the features of said event 

        #endregion

        #region variables 
        /// <summary>
        /// bool that tells if the alarm has been reached default false 
        /// </summary>
        public bool IsFinished { get; set; } = false;
        /// <summary>
        /// var to set the minutes for the alarm 
        /// </summary>
        public int Alarm { get; set; }
        /// <summary>
        /// variable to set the gap in seconds between  one message and the other 
        /// </summary>
        public int Gap { get; set; }
        /// <summary>
        /// index for counting 
        /// </summary>
        public int Count { get; set; } = 0;

        #endregion 

        #region contructor
        ///set the contructor to set the timer 
        public Ring()
        {
            _timer.Elapsed += _timer_Elapsed; //activate event handler 
            _timer.Interval = 1000;
        }
        #endregion

        #region events
        /// <summary>
        /// event to create the other that the user will use 
        /// </summary>
        /// <param name="sender"> string datetime or string with the gap </param>
        /// <param name="e"></param>
        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //create a class to which pass the parameter 
            Count++;
            _timeSpan = _timeSpan.Add(new TimeSpan(0, 0, 1));
            st.Data = _timeSpan.Hours.ToString("D2") + ":" + _timeSpan.Minutes.ToString("D2") + "." + _timeSpan.Seconds.ToString("D2"); //giving the parameter data the datetime
            
            if (Alarm == Count)
            {
                _timer.Stop();
                st.Alert = "\nAlarm! Time's Up!\n"; //variable set with the message of the finished event 
                IsFinished = true;
                st.isAlarm = true;
            }
            else
            {
                st.Alert = "";
         
            }
            DisplayDate(st, null);
            if (Count % Gap == 0) //when the module between gap and count has as a rest 0 
            {
                st.Message = string.Format("{0} seconds passed!\r", Count);

            }
            DisplayGap(st, null);
        }
        public event EventHandler DisplayGap; //event to see the gap 
        public event EventHandler DisplayDate;//event to show the datetime 
        #endregion

        #region methods 
        /// <summary>
        /// method that stops the clock 
        /// </summary>
        public void StopTime()
        {
            _timer.Stop();
        }
        /// <summary>
        /// method to start the timer 
        /// </summary>
        public void StartTime()
        {
            st.isAlarm = false;
            _timer.Start();
        }
        /// <summary>
        /// method to set the alarm 
        /// </summary>
        public void SetAlarm()
        {
            Console.WriteLine("Please, set an alarm in minutes...");
            Alarm = Convert.ToInt32(Console.ReadLine());

        }
        /// <summary>
        /// method to set the gap in seconds
        /// </summary>
        public void SetGap()
        {
            Console.WriteLine("Please insert Gap in seconds...");
            Gap = Convert.ToInt32(Console.ReadLine());
        }

        #endregion

    }
    #endregion

    #region class object
    /// <summary>
    /// class object with the data value 
    /// </summary>
    public class StateObj
    {
        /// <summary>
        /// string with the datatime , in order to allow the developer to add new parameters and pass them in the event later 
        /// i use a class instead of a single varible 
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// var that contains the string for the gap
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// variable that contains the message to show once the button's clicked 
        /// </summary>
        public string Alert { get; set; }
        public bool isAlarm { get; set; } = false;
    }
    #endregion
}
