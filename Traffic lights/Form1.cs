using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_lights
{
    public partial class Form1 : Form
    {
        int timer = 5;
        int timerY = 3;
        int t1_count = 0;
        int t2_count = 0;
        int t3_count = 0;

        int t1Y_count = 0;
        int t2Y_count = 0;
        int t3Y_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initial();
        }

        private void Initial()
        {
            btn1R.BackColor = Color.Red;
            btn2G.BackColor = Color.Green;
            btn3R.BackColor = Color.Red;

            t1.Start();

        }

        private void t1_Tick(object sender, EventArgs e)
        {
            t1_count++;
            if (t1_count == timer )
            {
                t1_count = 0;
                btn2G.BackColor = Color.Silver;

                btn2Y.BackColor = Color.Yellow;

                t1.Stop();
                t2Y.Start();
            }
        }

        private void t2_Tick(object sender, EventArgs e)
        {
            t2_count++;
            if (t2_count == timer)
            {
                t2_count = 0;

                btn3G.BackColor = Color.Silver;

                btn2R.BackColor = Color.Red;

                btn3Y.BackColor = Color.Yellow;

                t2.Stop();
                t3Y.Start();
            }
        }

        private void t3_Tick(object sender, EventArgs e)
        {
            t3_count++;
            if (t3_count == timer)
            {
                t3_count = 0;
                
                btn1G.BackColor = Color.Silver;

                btn1Y.BackColor = Color.Yellow;

                t3.Stop();
                t1Y.Start();
            }
        }

        private void t2Y_Tick(object sender, EventArgs e)
        {
            t2Y_count++;
            if (t2Y_count == timerY)
            {
                t2Y_count = 0;

                btn2Y.BackColor = Color.Silver;
                btn2R.BackColor = Color.Red;

                btn3R.BackColor = Color.Silver;
                btn3G.BackColor = Color.Green;

                t2Y.Stop();

                t2.Start();
            }
        }

        private void t3Y_Tick(object sender, EventArgs e)
        {
            t3Y_count++;
            if (t3Y_count == timerY)
            {
                t3Y_count = 0;

                btn1G.BackColor = Color.Green;
                btn1R.BackColor = Color.Silver;

                btn3Y.BackColor = Color.Silver;
                btn3R.BackColor = Color.Red;

                t3Y.Stop();
                t3.Start();
            }
        }

        private void t1Y_Tick(object sender, EventArgs e)
        {
            t1Y_count++;
            if (t1Y_count == timerY)
            {
                t1Y_count = 0;

                btn2G.BackColor = Color.Green;
                btn2R.BackColor = Color.Silver;

                btn1Y.BackColor = Color.Silver;
                btn1R.BackColor = Color.Red;

                t1.Start();
                t1Y.Stop();
            }
        }
    }
}
