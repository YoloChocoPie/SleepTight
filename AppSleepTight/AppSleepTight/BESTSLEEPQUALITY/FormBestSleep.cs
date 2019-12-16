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

        void FormBestSleep_Load(object sender, EventArgs e)
        {
            this.ShowAll();
        }

        void grdBestSleep_DoubleClick(object sender, EventArgs e)
        {
            
        }
        private void FormBestSleep_Load()
        {
            var bestsleep = this.Business.GetData();
            this.grdBestSleep.DataSource = bestsleep;
        } 
        void btnDel_Click(object sender, EventArgs e)
        {
            if (this.grdBestSleep.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("delete?", "confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var @bestsleep = (BestSleep)this.grdBestSleep.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteData(bestsleep.id);
                    MessageBox.Show("delete");
                    this.FormBestSleep_Load();
                }
            }
        }

    

        void btnAdd_Click(object sender, EventArgs e)
        {
            var createForm = new FormAddData();
            createForm.ShowDialog();
            this.FormBestSleep_Load();
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
