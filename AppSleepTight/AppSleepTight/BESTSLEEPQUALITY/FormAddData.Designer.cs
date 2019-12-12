namespace AppSleepTight.BESTSLEEPQUALITY
{
    partial class FormAddData
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
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.lbAddnew = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbQuality = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(12, 99);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(105, 20);
            this.txtCountry.TabIndex = 3;
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(163, 99);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(100, 20);
            this.txtQuality.TabIndex = 4;
            // 
            // lbAddnew
            // 
            this.lbAddnew.AutoSize = true;
            this.lbAddnew.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddnew.Location = new System.Drawing.Point(19, 34);
            this.lbAddnew.Name = "lbAddnew";
            this.lbAddnew.Size = new System.Drawing.Size(244, 25);
            this.lbAddnew.TabIndex = 7;
            this.lbAddnew.Text = "Add New Country, Qualities";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(12, 69);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(90, 17);
            this.lbCountry.TabIndex = 8;
            this.lbCountry.Text = "Country Name";
            // 
            // lbQuality
            // 
            this.lbQuality.AutoSize = true;
            this.lbQuality.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuality.Location = new System.Drawing.Point(185, 69);
            this.lbQuality.Name = "lbQuality";
            this.lbQuality.Size = new System.Drawing.Size(78, 17);
            this.lbQuality.TabIndex = 10;
            this.lbQuality.Text = "Quality ( % )";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(107, 133);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(107, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 188);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbQuality);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbAddnew);
            this.Controls.Add(this.txtQuality);
            this.Controls.Add(this.txtCountry);
            this.Name = "FormAddData";
            this.Text = "FormAddData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.Label lbAddnew;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbQuality;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}