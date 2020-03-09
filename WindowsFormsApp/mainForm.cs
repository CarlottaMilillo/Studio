using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreriaclassi;

namespace WindowsFormsApp
{
    public partial class mainForm : Form
    {
        Ring _sveglia = new Ring();


        #region variables 
        /// <summary>
        /// var that temporarly contains the minutes and the gap to showthe message 
        /// 
        /// </summary>
        int tmpmin { get; set; } = -1;
        int tmpgap { get; set; } = -1;
        #endregion

        #region contructor
        public mainForm()
        {
            InitializeComponent();
            _sveglia.DisplayDate += _sveglia_DisplayDate;
            _sveglia.DisplayGap += _sveglia_DisplayGap;
        }
        #endregion

        #region Methods
        /// <summary>
        /// method with strings to see in the label 
        /// </summary>
        /// <param name="sender"></param>
        private void DisplayUI(object sender)
        {
            StateObj st = (StateObj)sender;
            lblCronometro.Invoke((MethodInvoker)delegate
            { //the interface says that it's ready to riceve the object 
                // Running on the UI thread
                lblCronometro.Text = st.Data;
                sStatus.Text = st.Alert + " " + st.Message;
                if(st.isAlarm)
                {
                    if (MessageBox.Show("Vuoi continuare? \nyes/ reset app, no/close app", "Finito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {

                        Application.Exit(); //exit the application
                        
                    }
                    else
                    {
                        clearobject(); //method to clear every slot in the program 
                        
                    }
                }

            });
        }
        /// <summary>
        /// methonds that clears all trhe spaces occupied at the beginning of the program 
        /// </summary>
        private void clearobject()
        {
            //setting all the variables to empty or 0
            tmpgap = 0;
            tmpmin = 0;
            sStatus.Text = "";
            txtGap.Text = "";
            txtMinuti.Text = "";
            _sveglia._timeSpan = new TimeSpan(0, 0, 0);
            _sveglia.Count = 0;
            btnStart.Text = "Start";
            btnStart.Enabled = true;
            lblCronometro.Text = "00:00.00";
            txtMinuti.Focus(); //the insert cursor is focused on the minutes textbox 
        }
        #endregion

        #region events
        /// <summary>
        /// event that displays the gap 
        /// </summary>
        /// <param name="sender">class object that contains some variables </param>
        /// <param name="e"></param>
        private void _sveglia_DisplayGap(object sender, EventArgs e)
        {
            DisplayUI(sender);
        }

        /// <summary>
        /// event click on the button, that changes text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start" || btnStart.Text == "Restart")
            {
                _sveglia.Alarm = tmpmin;
                _sveglia.Gap = tmpgap;
                sStatus.Text = "Cronometro partito";

                _sveglia.StartTime();
                btnStart.Text = "Pause";
               
            }
            else
            {
                // method to stop the timer 
                _sveglia.StopTime();
                sStatus.Text = "Cronometro in pausa ";
                btnStart.Enabled = true;
                btnStart.Text = "Restart";
            }
        }
       

        /// <summary>
        /// event that shows the date 
        /// </summary>
        /// <param name="sender">class object </param>
        /// <param name="e"></param>
        private void _sveglia_DisplayDate(object sender, EventArgs e)
        {
            StateObj obj = sender as StateObj;
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                sStatus.Text = obj.Alert; //nella label scrivo il messaggio di alert 
            });
        }

        /// <summary>
        /// event that handles the tick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            DisplayUI(sender);
        }


        /// <summary>
        /// event of the text box of the minutes
        /// when a number is inserted the button is enabled 
        /// when a letter is inserted the button is disalbed and a message with the error is shown 
        /// </summary>
        /// <param name="sender">text box with the minutes</param>
        /// <param name="e"></param>
        private void txtMinuti_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            try
            {
                if (Convert.ToInt32(tb.Text) >= 0) //if what is inserted is a letter convert it 
                {
                    tmpmin = Convert.ToInt32(tb.Text);//set the converted element to the var 
                    if ((tmpmin >= 0) && (tmpgap >= 0))//if te variable value is more or equal 0 
                    {
                        btnStart.Enabled = true;//enable the button 
                    }
                }
            }
            catch (Exception)
            {
                tb.Text = ""; //the textbox is left empty so that can be filled again with the right paramenters 
                btnStart.Enabled = false; //the btn is disabled 
                MessageBox.Show("Devi inserire solo caratteri numerici", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error); //message shown with the string that says the error 
            }

        }

        /// <summary>
        /// event of the text box of the gap 
        /// when a number is inserted the button is enabled 
        /// when a letter is inserted the button is disalbed and a message with the error is shown 
        /// </summary>
        /// <param name="sender"> the text box with the gap </param>
        /// <param name="e"></param>
        private void txtGap_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            try
            {
                if (Convert.ToInt32(tb.Text) >= 0)
                {
                    tmpgap = Convert.ToInt32(tb.Text);
                    if ((tmpmin >= 0) && (tmpgap >= 0))
                    {
                        btnStart.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {
                tb.Text = "";
                btnStart.Enabled = false;
                MessageBox.Show("Devi inserire solo caratteri numerici", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
