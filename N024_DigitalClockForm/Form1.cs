using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N024_DigitalClockForm
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.Text = "DigitalTimer_Form By 이수현34";

            t.Interval = 10;  //0.01초
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            //dClock.Text = DateTime.Now.ToString() + DateTime.Now.Millisecond;
            string s = string.Format("{0}:{1,3:000}", DateTime.Now.ToString(), DateTime.Now.Millisecond);
            dClock.Text = s;
        }
    }
}
