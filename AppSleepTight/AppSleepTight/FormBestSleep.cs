using AppSleepTight.BESTSLEEPQUALITY;
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
        private LogicLayer Business;
        public FormBestSleep()
        {
            InitializeComponent();
            this.Business = new LogicLayer();

            this.Load += FormBestSleep_Load;


            this.btnAdd.Click += btnAdd_Click;

            this.btnDel.Click += btnDel_Click;

            this.grdBestSleep.DoubleClick += grdBestSleep_DoubleClick;
        }

        void grdBestSleep_DoubleClick(object sender, EventArgs e)
        {
            
        }

        void btnDel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void FormBestSleep_Load(object sender, EventArgs e)
        {
            this.ShowAll();
        }

        private void ShowAll()
        {
            var bestsleeps = this.Business.GetData();
            var timebestsleep = new TimeBestSleep[bestsleeps.Length];

            for (int i = 0; i < bestsleeps.Length; i++)
            {
                timebestsleep[i] = new TimeBestSleep(bestsleeps[i]);
            }
            this.grdBestSleep.DataSource = timebestsleep;
        }
    }
}
