using libreriaclassi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace winformEx
{
    public partial class mainform : Form
    {
        Ring sveglia = new Ring();
        StateObj St = new StateObj();

        /// <summary>
        /// variabile temporanea per i minuti  ( in secondi)
        /// </summary>
        int tmpMin { get;  set; }
        /// <summary>
        /// variabile temporanea per i secondi
        /// </summary>
        int tmpSec { get; set; }
        public Ring Sveglia { get => sveglia; set => sveglia = value; }

        public mainform()
        {
            InitializeComponent();
            //here i declare the evnts used in the program 
            Sveglia.DisplayDate += Sveglia_DisplayDate;
            Sveglia.DisplayGap += Sveglia_DisplayGap;
        }
        /// <summary>
        /// event to display the time
        /// </summary>
        /// <param name="sender">stateobject class</param>
        /// <param name="e"></param>
        private void Sveglia_DisplayGap(object sender, EventArgs e)
        {

            //method to set the event
            DisplayThings();
            
            
        }

        /// <summary>
        /// method that will be used to save code and show the data in the events 
        /// </summary>
        private void DisplayThings()
        {
            //where has to be shown the time? in the cronometer label
            lblTime.Invoke((MethodInvoker)delegate
           {
               //set the things that have to be shown in the label 
               Sveglia.Alarm = tmpMin;
               Sveglia.Gap = tmpSec;
               Sveglia.Count++;
               if (Sveglia.Alarm == sveglia.Count)
               {
                   lblStatus.Text = St.Alert + "" + St.Message;
               }
     

           });
        }

        /// <summary>
        /// event to display the gap 
        /// </summary>
        /// <param name="sender">stateobject class</param>
        /// <param name="e"></param>
        private void Sveglia_DisplayDate(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //events that the button will handle 
           
        }

        /// <summary>
        /// what is inserted in the txtbox is added to a var 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtminutes_KeyUp(object sender, KeyEventArgs e)
        {
            //invoke 
            tmpMin = Convert.ToInt32(txtminutes.Text);
            
        }

        /// <summary>
        /// what is inserted in the txtbox is added to a var 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtseconds_KeyUp(object sender, KeyEventArgs e)
        {
            //invoke 
            tmpSec = Convert.ToInt32(txtseconds.Text);
        }
    }
}
