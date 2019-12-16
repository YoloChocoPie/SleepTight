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
            
            this.btnSleepNow.Click += btnSleepNow_Click;
            this.btnSeemore.Click += btnSeemore_Click;
            
        }

        void btnSeemore_Click(object sender, EventArgs e)
        {
            var form = new FormBestSleep();
            form.ShowDialog();
        }

        void btnSleepNow_Click(object sender, EventArgs e)
        {
            var form = new FormSleep();
            form.ShowDialog();
        }




    }
}
