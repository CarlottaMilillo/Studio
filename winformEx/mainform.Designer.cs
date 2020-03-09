namespace winformEx
{
    partial class mainform
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.txtminutes = new System.Windows.Forms.TextBox();
            this.txtseconds = new System.Windows.Forms.TextBox();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.lblGap = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.stripS = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(92, 44);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(150, 47);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "00:00.00";
            // 
            // txtminutes
            // 
            this.txtminutes.Location = new System.Drawing.Point(100, 123);
            this.txtminutes.Name = "txtminutes";
            this.txtminutes.Size = new System.Drawing.Size(173, 20);
            this.txtminutes.TabIndex = 5;
            this.txtminutes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtminutes_KeyUp);
            // 
            // txtseconds
            // 
            this.txtseconds.Location = new System.Drawing.Point(99, 155);
            this.txtseconds.Name = "txtseconds";
            this.txtseconds.Size = new System.Drawing.Size(174, 20);
            this.txtseconds.TabIndex = 6;
            this.txtseconds.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtseconds_KeyUp);
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAlarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlarm.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarm.Location = new System.Drawing.Point(46, 127);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(48, 15);
            this.lblAlarm.TabIndex = 7;
            this.lblAlarm.Text = "Alarm";
            // 
            // lblGap
            // 
            this.lblGap.AutoSize = true;
            this.lblGap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGap.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGap.Location = new System.Drawing.Point(60, 155);
            this.lblGap.Name = "lblGap";
            this.lblGap.Size = new System.Drawing.Size(34, 15);
            this.lblGap.TabIndex = 8;
            this.lblGap.Text = "Gap";
            this.lblGap.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(128, 233);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(83, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // stripS
            // 
            this.stripS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.stripS.Location = new System.Drawing.Point(0, 284);
            this.stripS.Name = "stripS";
            this.stripS.Size = new System.Drawing.Size(338, 22);
            this.stripS.TabIndex = 10;
            this.stripS.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(292, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "...";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 306);
            this.Controls.Add(this.stripS);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblGap);
            this.Controls.Add(this.lblAlarm);
            this.Controls.Add(this.txtseconds);
            this.Controls.Add(this.txtminutes);
            this.Controls.Add(this.lblTime);
            this.Name = "mainform";
            this.Text = "Form1";
            this.stripS.ResumeLayout(false);
            this.stripS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtminutes;
        private System.Windows.Forms.TextBox txtseconds;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblGap;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.StatusStrip stripS;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

