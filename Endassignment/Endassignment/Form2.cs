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
    public partial class Form2 : Form
    {
        public Form2()
            
        {
            InitializeComponent();
        }
        public int second;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            loading.Increment(2);
            
            
            if (loading.Value == 100)
            {
                timer1.Enabled = false;
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();

            }
        }
    }
}
