using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Media;

namespace ÄtOchSovKlocka
{
    public partial class Timer : Form
    {


        int mm;
        int ss;
        int temp;
        int selection = 1;
        public Timer()
        {
            

            InitializeComponent();
            ClockValue.Text = DateTime.Now.ToString("HH:MM:ss");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClockValue.Text = DateTime.Now.ToString("HH:MM:ss");

        }

        private void workButton(object sender, EventArgs e)
        {
            ss = 3120;
            this.timer2.Enabled = true;

        }

        private void stopOne(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void breakButton(object sender, EventArgs e)
        {
            ss = 960;
            this.timer3.Enabled = true;
        }

        private void stopTwo(object sender, EventArgs e)
        {
            timer3.Stop();
        }



        private void timer2_Tick(object sender, EventArgs e)
        {

            timer3.Stop();
            ss--;
            mm = ss / 60;
            ss--;
            mm = ss / 60;
            if (ss > 60)
            {
                temp = ss % 60;
            }
            if (ss % 60 < 10)
            {
                breakValue.Text = ($"{mm}:0{temp}");
            }
            else
            {
                breakValue.Text = ($"{mm}:{temp}");
            }
            if (ss == 0)
            {
               
                timer3.Stop();
                for (int i = 0; i < 10; i++)
                {
                    AudioPlayer.PlaySound(selection);
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {


            timer2.Stop();
            ss--;
            mm = ss / 60;
            if (ss > 60)
            {
                temp = ss % 60;
            }
            if (ss % 60 < 10)
            {
                breakValue.Text = ($"{mm}:0{temp}");
            }
            else
            {
                breakValue.Text = ($"{mm}:{temp}");
            }
            if (ss == 0)
            {
                                
                timer3.Stop();
                for (int i = 0; i < 10; i++)
                {
                    AudioPlayer.PlaySound(selection);
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            selection = 1;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            selection = 2;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            selection = 3;
        }
    }
}
