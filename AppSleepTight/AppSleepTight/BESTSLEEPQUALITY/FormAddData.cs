using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSleepTight.BESTSLEEPQUALITY
{
    public partial class FormAddData : Form
    {
        private LogicLayer Business;
        public FormAddData()
        {
            InitializeComponent();
            this.Business = new LogicLayer();

            

            this.btnSave.Click += btnSave_Click;

            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var country = this.txtCountry.Text;

            var quality = this.txtQuality.Text;

            this.Business.CreateData(country, quality);

            MessageBox.Show("Save Successfully !");
            this.Close();
        }


    }
}
