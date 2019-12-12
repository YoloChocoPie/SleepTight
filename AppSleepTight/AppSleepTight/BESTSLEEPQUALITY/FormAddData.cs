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
            this.Business = new LogicLayer();
            
            this.Load += FormAddData_Load;

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

            var Quality = this.txtQuality.Text;

            this.Business.CreateData(country, Quality);

            MessageBox.Show("done");
            this.Close();
        }

        void FormAddData_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
