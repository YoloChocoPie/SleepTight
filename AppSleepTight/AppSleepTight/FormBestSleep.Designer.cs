namespace AppSleepTight
{
    partial class FormBestSleep
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
            this.grdBestSleep = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdBestSleep)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBestSleep
            // 
            this.grdBestSleep.AllowUserToAddRows = false;
            this.grdBestSleep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBestSleep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBestSleep.Location = new System.Drawing.Point(0, 0);
            this.grdBestSleep.Name = "grdBestSleep";
            this.grdBestSleep.ReadOnly = true;
            this.grdBestSleep.Size = new System.Drawing.Size(284, 262);
            this.grdBestSleep.TabIndex = 0;
            // 
            // BESTSLEEPQUALITY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.grdBestSleep);
            this.Name = "BESTSLEEPQUALITY";
            this.Text = "BESTSLEEPQUALITY";
            ((System.ComponentModel.ISupportInitialize)(this.grdBestSleep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBestSleep;
    }
}