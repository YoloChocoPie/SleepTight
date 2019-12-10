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
    public partial class FormBestSleep : Form
    {
        public FormBestSleep()
        {
            InitializeComponent();
            this.Load += FormBestSleep_Load;
        }

        void FormBestSleep_Load(object sender, EventArgs e)
        {
            this.ShowAll();
        }

        private void ShowAll()
        {

        }
    }
}
