using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endassignment
{
    public partial class Form3 : Form
    {
        public object result;

        public Form3()
        {
            InitializeComponent();
        }
        

        private void StartTimer_Click(object sender, EventArgs e)
        {
            DateTime startTime;
            startTime = DateTime.Now;
            timer1.Tick += (s, ev) => { timeMinutes.Text = (DateTime.Now - startTime).ToString("hh\\:mm\\:ss\\.fff"); };
            startTime = DateTime.Now;
            timer1.Interval = 100;       // every 1/10 of a second
            timer1.Start();
        }

        private void StopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DateTime endTime;
            endTime = DateTime.Now;
            endTime = endTime.AddDays(1);
        }

        public void Calbutton_Click(object sender, EventArgs e)
        {
            TimeSpan time = TimeSpan.Parse(timeMinutes.Text);
            double seconds = time.TotalSeconds;
            Journey m_myClass = new Journey(double.Parse(txtInputKm.Text), seconds);


            label1.Text = String.Format("{0:0.00}", m_myClass.Result.ToString());
        }

        private void driverE_Click(object sender, EventArgs e)
        {
            string driver = txtdriverN.Text;
            int driverID = int.Parse(txtdriverD.Text);
            Taxis my_myClass = new Taxis(driver, int.Parse(txtdriverD.Text));
            
            lblDriver.Text = my_myClass.Title.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driver.SelectedIndex = 0;
        }

        private void Driver_MouseClick(object sender, MouseEventArgs e)
        {
            Driver.SelectedIndex = 1;
        }

        private void Drivertwo_MouseClick(object sender, MouseEventArgs e)
        {
            Driver.SelectedIndex = 2;
        }
    }
}
