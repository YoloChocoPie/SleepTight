namespace AppSleepTight
{
    partial class FormWakeUp
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
            this.lbShouldWU = new System.Windows.Forms.Label();
            this.txtHours1 = new System.Windows.Forms.TextBox();
            this.txtMinute1 = new System.Windows.Forms.TextBox();
            this.txtDayNight1 = new System.Windows.Forms.TextBox();
            this.txtDayNight2 = new System.Windows.Forms.TextBox();
            this.txtMinute2 = new System.Windows.Forms.TextBox();
            this.txtHours2 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbShouldWU
            // 
            this.lbShouldWU.AutoSize = true;
            this.lbShouldWU.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShouldWU.Location = new System.Drawing.Point(30, 41);
            this.lbShouldWU.Name = "lbShouldWU";
            this.lbShouldWU.Size = new System.Drawing.Size(433, 32);
            this.lbShouldWU.TabIndex = 0;
            this.lbShouldWU.Text = "Then You Should Sleep At These Times";
            // 
            // txtHours1
            // 
            this.txtHours1.Location = new System.Drawing.Point(64, 107);
            this.txtHours1.Name = "txtHours1";
            this.txtHours1.Size = new System.Drawing.Size(100, 20);
            this.txtHours1.TabIndex = 1;
            // 
            // txtMinute1
            // 
            this.txtMinute1.Location = new System.Drawing.Point(196, 107);
            this.txtMinute1.Name = "txtMinute1";
            this.txtMinute1.Size = new System.Drawing.Size(100, 20);
            this.txtMinute1.TabIndex = 2;
            // 
            // txtDayNight1
            // 
            this.txtDayNight1.Location = new System.Drawing.Point(326, 107);
            this.txtDayNight1.Name = "txtDayNight1";
            this.txtDayNight1.Size = new System.Drawing.Size(128, 20);
            this.txtDayNight1.TabIndex = 3;
            // 
            // txtDayNight2
            // 
            this.txtDayNight2.Location = new System.Drawing.Point(326, 155);
            this.txtDayNight2.Name = "txtDayNight2";
            this.txtDayNight2.Size = new System.Drawing.Size(128, 20);
            this.txtDayNight2.TabIndex = 6;
            // 
            // txtMinute2
            // 
            this.txtMinute2.Location = new System.Drawing.Point(196, 155);
            this.txtMinute2.Name = "txtMinute2";
            this.txtMinute2.Size = new System.Drawing.Size(100, 20);
            this.txtMinute2.TabIndex = 5;
            // 
            // txtHours2
            // 
            this.txtHours2.Location = new System.Drawing.Point(64, 155);
            this.txtHours2.Name = "txtHours2";
            this.txtHours2.Size = new System.Drawing.Size(100, 20);
            this.txtHours2.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(208, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "DONE";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // FormWakeUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 269);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDayNight2);
            this.Controls.Add(this.txtMinute2);
            this.Controls.Add(this.txtHours2);
            this.Controls.Add(this.txtDayNight1);
            this.Controls.Add(this.txtMinute1);
            this.Controls.Add(this.txtHours1);
            this.Controls.Add(this.lbShouldWU);
            this.Name = "FormWakeUp";
            this.Text = "FormWakeUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbShouldWU;
        private System.Windows.Forms.TextBox txtHours1;
        private System.Windows.Forms.TextBox txtMinute1;
        private System.Windows.Forms.TextBox txtDayNight1;
        private System.Windows.Forms.TextBox txtDayNight2;
        private System.Windows.Forms.TextBox txtMinute2;
        private System.Windows.Forms.TextBox txtHours2;
        private System.Windows.Forms.Button btnExit;
    }
}