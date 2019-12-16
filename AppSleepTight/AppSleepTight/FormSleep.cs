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
    public partial class FormSleep : Form
    {
        public FormSleep()
        {
            InitializeComponent();
            // Get the time right now
            var time0 = DateTime.Now;

            // Calculate the time you should wake up
            // How it works : The 1st time = the time right now + 105min
            //                The 2nd to n = the previous time + 90min 


            //TextBox 1
            DateTime date1 = DateTime.Now;
            TimeSpan time1 = new TimeSpan(1 , 45, 0);
            DateTime combined1 = date1.Add(time1);
            Console.WriteLine("{0:dddd}", combined1);
            //TextBox 2
            DateTime date2 = DateTime.Now;
            TimeSpan time2 = new TimeSpan(3, 0, 0);
            DateTime combined2 = date2.Add(time2);
            Console.WriteLine("{0:dddd}", combined2);
            //TextBox 3
            DateTime date3 = DateTime.Now;
            TimeSpan time3 = new TimeSpan(4, 15, 0);
            DateTime combined3 = date3.Add(time3);
            Console.WriteLine("{0:dddd}", combined3);
            //TextBox 4
            DateTime date4 = DateTime.Now;
            TimeSpan time4 = new TimeSpan(5, 20, 0);
            DateTime combined4 = date4.Add(time4);
            Console.WriteLine("{0:dddd}", combined4);
            //TextBox 5
            DateTime date5 = DateTime.Now;
            TimeSpan time5 = new TimeSpan(6, 35, 0);
            DateTime combined5 = date5.Add(time5);
            Console.WriteLine("{0:dddd}", combined5);
            //TextBox 6
            DateTime date6 = DateTime.Now;
            TimeSpan time6 = new TimeSpan(7, 50, 0);
            DateTime combined6 = date6.Add(time6);
            Console.WriteLine("{0:dddd}", combined6);
            

            //Change the type of the calculated number into String so we can put it in the textBox

            // the time right now
            string formattedTime = time0.ToString("h:mm:ss tt"); 

            // the time you should wake up
            string txt1 = combined1.ToString("h:mm:ss tt");
            string txt2 = combined2.ToString("h:mm:ss tt");
            string txt3 = combined3.ToString("h:mm:ss tt");
            string txt4 = combined4.ToString("h:mm:ss tt");
            string txt5 = combined5.ToString("h:mm:ss tt");
            string txt6 = combined6.ToString("h:mm:ss tt");


            //Put it in the textBox
            
            // the time right now
            txtHours1.Text = formattedTime;

            // the time you should wake up
            txtOne.Text = txt1;
            txtTwo.Text = txt2;
            txtThree.Text = txt3;
            txtFour.Text = txt4;
            txtFive.Text = txt5;
            txtSix.Text = txt6;

            //button
            btnExit.Click += btnExit_Click;
        }

        void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
