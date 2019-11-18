using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSleepTight
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.btnWakeUp.Click +=btnWakeUp_Click;
            this.btnSleepNow.Click += btnSleepNow_Click;
            
        }

        void btnSleepNow_Click(object sender, EventArgs e)
        {
            var form = new FormSleep();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnWakeUp_Click(object sender, EventArgs e)
        {
            var form = new FormWakeUp();
            form.ShowDialog();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
