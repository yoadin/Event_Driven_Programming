using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb1.Checked = true;
            cb1.Text = "Students";
            bool result = cb1.Checked;
            DisplayDetails();
        }

        private void DisplayDetails()
        {
            lv.Items.Clear();
            for (int i = 0; i <= 10; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems[0].Text = i.ToString();
                lvi.SubItems.Add(i.ToString());
                if (i % 2 == 0)
                    lvi.SubItems.Add("Male");
                else
                    lvi.SubItems.Add("Female");

                lv.Items.Add(lvi);

            }
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            pbNum.Value++;
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            int year = dtp.Value.Year;
            int month = dtp.Value.Month;
            int date = dtp.Value.Day;
            TimeSpan ts = DateTime.Now.Date.Subtract(dtp.Value);
            rtb.Text = (ts.TotalDays / 365).ToString();
            //dtp.Value.Subtract(new TimeSpan(365, 0, 0, 0));
            //rtb.Text = year.ToString();
            //rtb.Text = ""
        }

        private void rbF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdop1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdop1.Checked)
            {
                rbF.Checked = true;
            }
            else
            {
                rbM.Checked = true;
            }
        }
    }
}
