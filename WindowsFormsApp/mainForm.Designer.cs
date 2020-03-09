namespace WindowsFormsApp
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMinuti = new System.Windows.Forms.Label();
            this.txtMinuti = new System.Windows.Forms.TextBox();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.txtGap = new System.Windows.Forms.TextBox();
            this.lblGap = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblmin = new System.Windows.Forms.Label();
            this.lblsec = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(102, 175);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblMinuti
            // 
            this.lblMinuti.AutoSize = true;
            this.lblMinuti.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMinuti.Location = new System.Drawing.Point(26, 96);
            this.lblMinuti.Name = "lblMinuti";
            this.lblMinuti.Size = new System.Drawing.Size(33, 13);
            this.lblMinuti.TabIndex = 1;
            this.lblMinuti.Text = "Alarm";
            // 
            // txtMinuti
            // 
            this.txtMinuti.Location = new System.Drawing.Point(69, 93);
            this.txtMinuti.Name = "txtMinuti";
            this.txtMinuti.Size = new System.Drawing.Size(142, 20);
            this.txtMinuti.TabIndex = 1;
            this.txtMinuti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinuti.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMinuti_KeyUp);
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.BackColor = System.Drawing.Color.White;
            this.lblCronometro.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometro.Location = new System.Drawing.Point(64, 24);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(150, 47);
            this.lblCronometro.TabIndex = 3;
            this.lblCronometro.Text = "00:00.00";
            // 
            // txtGap
            // 
            this.txtGap.Location = new System.Drawing.Point(69, 119);
            this.txtGap.Name = "txtGap";
            this.txtGap.Size = new System.Drawing.Size(142, 20);
            this.txtGap.TabIndex = 2;
            this.txtGap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGap_KeyUp);
            // 
            // lblGap
            // 
            this.lblGap.AutoSize = true;
            this.lblGap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblGap.Location = new System.Drawing.Point(26, 122);
            this.lblGap.Name = "lblGap";
            this.lblGap.Size = new System.Drawing.Size(27, 13);
            this.lblGap.TabIndex = 4;
            this.lblGap.Text = "Gap";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 235);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(271, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sStatus
            // 
            this.sStatus.Name = "sStatus";
            this.sStatus.Size = new System.Drawing.Size(256, 17);
            this.sStatus.Spring = true;
            this.sStatus.Text = "...";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Location = new System.Drawing.Point(217, 100);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(27, 13);
            this.lblmin.TabIndex = 7;
            this.lblmin.Text = "sec.";
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Location = new System.Drawing.Point(216, 126);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(27, 13);
            this.lblsec.TabIndex = 8;
            this.lblsec.Text = "sec.";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 257);
            this.Controls.Add(this.lblsec);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtGap);
            this.Controls.Add(this.lblGap);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.txtMinuti);
            this.Controls.Add(this.lblMinuti);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIA FINESTRA";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMinuti;
        private System.Windows.Forms.TextBox txtMinuti;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.TextBox txtGap;
        private System.Windows.Forms.Label lblGap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sStatus;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblsec;
    }
}

