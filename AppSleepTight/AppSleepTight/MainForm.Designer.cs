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
            this.SleepNow = new System.Windows.Forms.Label();
            this.btnSleepNow = new System.Windows.Forms.Button();
            this.lbSeemore = new System.Windows.Forms.Label();
            this.btnSeemore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTenApp
            // 
            this.lbTenApp.AutoSize = true;
            this.lbTenApp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTenApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenApp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTenApp.Location = new System.Drawing.Point(133, 23);
            this.lbTenApp.Name = "lbTenApp";
            this.lbTenApp.Size = new System.Drawing.Size(207, 42);
            this.lbTenApp.TabIndex = 0;
            this.lbTenApp.Text = "Sleep Tight";
            // 
            // lbTenApp2
            // 
            this.lbTenApp2.AutoSize = true;
            this.lbTenApp2.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenApp2.Location = new System.Drawing.Point(119, 94);
            this.lbTenApp2.Name = "lbTenApp2";
            this.lbTenApp2.Size = new System.Drawing.Size(236, 27);
            this.lbTenApp2.TabIndex = 1;
            this.lbTenApp2.Text = "Your Sleep Diary";
            // 
            // SleepNow
            // 
            this.SleepNow.AutoSize = true;
            this.SleepNow.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SleepNow.Location = new System.Drawing.Point(275, 140);
            this.SleepNow.Name = "SleepNow";
            this.SleepNow.Size = new System.Drawing.Size(167, 29);
            this.SleepNow.TabIndex = 5;
            this.SleepNow.Text = "If I Sleep Now";
            // 
            // btnSleepNow
            // 
            this.btnSleepNow.Location = new System.Drawing.Point(280, 185);
            this.btnSleepNow.Name = "btnSleepNow";
            this.btnSleepNow.Size = new System.Drawing.Size(131, 23);
            this.btnSleepNow.TabIndex = 6;
            this.btnSleepNow.Text = "Calculate";
            this.btnSleepNow.UseVisualStyleBackColor = true;
            // 
            // lbSeemore
            // 
            this.lbSeemore.AutoSize = true;
            this.lbSeemore.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeemore.Location = new System.Drawing.Point(30, 140);
            this.lbSeemore.Name = "lbSeemore";
            this.lbSeemore.Size = new System.Drawing.Size(152, 29);
            this.lbSeemore.TabIndex = 10;
            this.lbSeemore.Text = "Sleep History";
            // 
            // btnSeemore
            // 
            this.btnSeemore.Location = new System.Drawing.Point(35, 185);
            this.btnSeemore.Name = "btnSeemore";
            this.btnSeemore.Size = new System.Drawing.Size(131, 23);
            this.btnSeemore.TabIndex = 11;
            this.btnSeemore.Text = "See More";
            this.btnSeemore.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 220);
            this.Controls.Add(this.btnSeemore);
            this.Controls.Add(this.lbSeemore);
            this.Controls.Add(this.btnSleepNow);
            this.Controls.Add(this.SleepNow);
            this.Controls.Add(this.lbTenApp2);
            this.Controls.Add(this.lbTenApp);
            this.Name = "MainForm";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenApp;
        private System.Windows.Forms.Label lbTenApp2;
        private System.Windows.Forms.Label SleepNow;
        private System.Windows.Forms.Button btnSleepNow;
        private System.Windows.Forms.Label lbSeemore;
        private System.Windows.Forms.Button btnSeemore;
    }
}

