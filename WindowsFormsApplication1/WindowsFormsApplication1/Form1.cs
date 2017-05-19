using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Tv tv;
        public Form1()
        {
            InitializeComponent();
            tv = new Tv();
            powLab.Text = "power: " + tv.state();
            volLab.Text = "volume: " + tv.getVol();
            chanLab.Text = "channel: " + tv.getChannel();

        }

        private void powBtn_Click(object sender, EventArgs e)
        {
            tv.changePower();
            powLab.Text = "power: " + tv.state();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tv.working()) 
            {
                tv.setChannel(1);
                chanLab.Text = "channel: " + tv.getChannel();
            }
            
        }

        private void muteBtn_Click(object sender, EventArgs e)
        {
            if (tv.working())
            {
                tv.mute();
                volLab.Text = "volume: " + tv.getVol();
            }
        }

        private void powBtn_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void muteBtn_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tv.working())
            {
                tv.setChannel(2);
                chanLab.Text = "channel: " + tv.getChannel();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tv.working())
            {
                tv.setChannel(3);
                chanLab.Text = "channel: " + tv.getChannel();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tv.working())
            {
                tv.setChannel(4);
                chanLab.Text = "channel: " + tv.getChannel();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tv.working())
            {
                tv.setChannel(5);
                chanLab.Text = "channel: " + tv.getChannel();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tv.working())
            {
                tv.setChannel(6);
                chanLab.Text = "channel: " + tv.getChannel();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tv.setChannel(7);
            chanLab.Text = "channel: " + tv.getChannel();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tv.working())
            {
                tv.setChannel(8);
                chanLab.Text = "channel: " + tv.getChannel();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tv.working())
            {
                tv.setChannel(9);
                chanLab.Text = "channel: " + tv.getChannel();
            }
        }

        private void plusChan_Click(object sender, EventArgs e)
        {
            if (tv.working())
            {
                tv.incChannel();
                chanLab.Text = "channel: " + tv.getChannel();
            }
        }

        private void minChan_Click(object sender, EventArgs e)
        {
            if (tv.working())
            {
                tv.decChannel();
                chanLab.Text = "channel: " + tv.getChannel();
            }
        }

        private void plusVol_Click(object sender, EventArgs e)
        {
            if (tv.working())
            {
                tv.incVol();
                volLab.Text = "volume: " + tv.getVol();
            }
        }

        private void minVol_Click(object sender, EventArgs e)
        {
            if (tv.working())
            {
                tv.decVol();
                volLab.Text = "volume: " + tv.getVol();
            }
        }


    }
}
