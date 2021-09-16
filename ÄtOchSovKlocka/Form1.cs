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
        }
               
        private void workButton(object sender, EventArgs e)
        {
            breakTimer.Stop();
            ss = 3120;
            workTimer.Enabled = true;
        }

        private void stopOne(object sender, EventArgs e)
        {
            workTimer.Stop();
        }             

        private void breakButton(object sender, EventArgs e)
        {
            workTimer.Stop();
            ss = 960;
            breakTimer.Enabled = true;
        }

        private void stopTwo(object sender, EventArgs e)
        {
            breakTimer.Stop();
        }



        private void timer2_Tick(object sender, EventArgs e)
        {

            breakTimer.Stop();
            
            mm = ss / 60;
            ss--;
            mm = ss / 60;
            if (ss > 60)
            {
                temp = ss % 60;
            }
            if (ss % 60 < 10)
            {
                workValue.Text = ($"{mm}:0{temp}");
            }
            else
            {
                workValue.Text = ($"{mm}:{temp}");
            }
            if (ss == 0)
            {
               
                workTimer.Stop();
                for (int i = 0; i < 10; i++)
                {
                    AudioPlayer.PlaySound(selection);
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {


            workTimer.Stop();
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
                                
                breakTimer.Stop();
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
