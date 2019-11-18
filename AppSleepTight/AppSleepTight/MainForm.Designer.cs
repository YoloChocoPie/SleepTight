namespace AppSleepTight
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTenApp = new System.Windows.Forms.Label();
            this.lbTenApp2 = new System.Windows.Forms.Label();
            this.lbWakeUp = new System.Windows.Forms.Label();
            this.btnWakeUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSleepNow = new System.Windows.Forms.Button();
            this.cbHours = new System.Windows.Forms.ComboBox();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.cbDayNight = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbTenApp
            // 
            this.lbTenApp.AutoSize = true;
            this.lbTenApp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTenApp.Font = new System.Drawing.Font("Nirmala UI Semilight", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenApp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTenApp.Location = new System.Drawing.Point(226, 37);
            this.lbTenApp.Name = "lbTenApp";
            this.lbTenApp.Size = new System.Drawing.Size(198, 50);
            this.lbTenApp.TabIndex = 0;
            this.lbTenApp.Text = "Sleep Tight";
            this.lbTenApp.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTenApp2
            // 
            this.lbTenApp2.AutoSize = true;
            this.lbTenApp2.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenApp2.Location = new System.Drawing.Point(84, 102);
            this.lbTenApp2.Name = "lbTenApp2";
            this.lbTenApp2.Size = new System.Drawing.Size(446, 27);
            this.lbTenApp2.TabIndex = 1;
            this.lbTenApp2.Text = "\'Cause You Deserve Better Sleep";
            // 
            // lbWakeUp
            // 
            this.lbWakeUp.AutoSize = true;
            this.lbWakeUp.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWakeUp.Location = new System.Drawing.Point(12, 159);
            this.lbWakeUp.Name = "lbWakeUp";
            this.lbWakeUp.Size = new System.Drawing.Size(256, 29);
            this.lbWakeUp.TabIndex = 2;
            this.lbWakeUp.Text = "I Want To Wake Up At";
            // 
            // btnWakeUp
            // 
            this.btnWakeUp.Location = new System.Drawing.Point(482, 166);
            this.btnWakeUp.Name = "btnWakeUp";
            this.btnWakeUp.Size = new System.Drawing.Size(131, 23);
            this.btnWakeUp.TabIndex = 4;
            this.btnWakeUp.Text = "Calculate";
            this.btnWakeUp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "If I Sleep Now";
            // 
            // btnSleepNow
            // 
            this.btnSleepNow.Location = new System.Drawing.Point(235, 242);
            this.btnSleepNow.Name = "btnSleepNow";
            this.btnSleepNow.Size = new System.Drawing.Size(131, 23);
            this.btnSleepNow.TabIndex = 6;
            this.btnSleepNow.Text = "Calculate";
            this.btnSleepNow.UseVisualStyleBackColor = true;
            // 
            // cbHours
            // 
            this.cbHours.FormattingEnabled = true;
            this.cbHours.Items.AddRange(new object[] {
            "(Hours)",
            "---------",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            ""});
            this.cbHours.Location = new System.Drawing.Point(289, 166);
            this.cbHours.Name = "cbHours";
            this.cbHours.Size = new System.Drawing.Size(58, 21);
            this.cbHours.TabIndex = 7;
            // 
            // cbMinute
            // 
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Items.AddRange(new object[] {
            "(Minute)",
            "----------",
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cbMinute.Location = new System.Drawing.Point(353, 166);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(57, 21);
            this.cbMinute.TabIndex = 8;
            this.cbMinute.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbDayNight
            // 
            this.cbDayNight.FormattingEnabled = true;
            this.cbDayNight.Items.AddRange(new object[] {
            "AM",
            "----",
            "PM"});
            this.cbDayNight.Location = new System.Drawing.Point(416, 167);
            this.cbDayNight.Name = "cbDayNight";
            this.cbDayNight.Size = new System.Drawing.Size(57, 21);
            this.cbDayNight.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 326);
            this.Controls.Add(this.cbDayNight);
            this.Controls.Add(this.cbMinute);
            this.Controls.Add(this.cbHours);
            this.Controls.Add(this.btnSleepNow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWakeUp);
            this.Controls.Add(this.lbWakeUp);
            this.Controls.Add(this.lbTenApp2);
            this.Controls.Add(this.lbTenApp);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenApp;
        private System.Windows.Forms.Label lbTenApp2;
        private System.Windows.Forms.Label lbWakeUp;
        private System.Windows.Forms.Button btnWakeUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSleepNow;
        private System.Windows.Forms.ComboBox cbHours;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.ComboBox cbDayNight;
    }
}

