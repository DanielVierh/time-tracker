using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Focus_Timer
{

    public partial class Form1 : Form
    {
        public int codingTime = 0;
        public int lerningTime = 0;
        public int meetingTime = 0;
        public int orgaTime = 0;
        public int sonstigesTime = 0;
        public int pauseTime = 0;
        public string currentTimeEvent = "Lernen";
        public bool timerIsRunning = false;

        int timeS, timeM, timeH;
        bool isActive;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetTime();
            isActive = false;
        }

        void resetTime()
        {
            timeS = 0;
            timeM = 0;
            timeH = 0;
            drawTime();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }


        private void btnPause_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        void unselectColor()
        {
            rdbLerning.BackColor = Color.Transparent;
            rndCoding.BackColor = Color.Transparent;
            rndMeeting.BackColor = Color.Transparent;
            rndOrga.BackColor = Color.Transparent;
            rndPause.BackColor = Color.Transparent;
            rndSonstiges.BackColor = Color.Transparent;
        }

        private void rdbLerning_CheckedChanged(object sender, EventArgs e)
        {
            currentTimeEvent = "Lernen";
            unselectColor();
            rdbLerning.BackColor = Color.CadetBlue;
        }

        private void rndCoding_CheckedChanged(object sender, EventArgs e)
        {
            currentTimeEvent = "Coden";
            unselectColor();
            rndCoding.BackColor = Color.CadetBlue;
        }

        private void rndOrga_CheckedChanged(object sender, EventArgs e)
        {
            currentTimeEvent = "Orga";
            unselectColor();
            rndOrga.BackColor = Color.CadetBlue;
        }

        private void rndSonstiges_CheckedChanged(object sender, EventArgs e)
        {
            unselectColor();
            rndSonstiges.BackColor = Color.CadetBlue;
            currentTimeEvent = "Sonstiges";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isActive = false;
            resetTime();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isActive)
            {
                timeS++;
                if(timeS >= 60)
                {
                    timeM++;
                    timeS = 0;

                    if(timeM >= 60)
                    {
                        timeH++;
                        timeM = 0;
                    }
                }
                drawTime();
                lblHr.BackColor = Color.Green;
                lblMin.BackColor = Color.Green;
                lblSec.BackColor = Color.Green;
            }
            else
            {
                lblHr.BackColor = Color.Red;
                lblMin.BackColor = Color.Red;
                lblSec.BackColor = Color.Red;
            }
        }

        void drawTime()
        {
            lblHr.Text = String.Format("{0:00}", timeH);
            lblMin.Text = String.Format("{0:00}", timeM);
            lblSec.Text = String.Format("{0:00}", timeS);
        }

        private void rndPause_CheckedChanged(object sender, EventArgs e)
        {
            currentTimeEvent = "Pause";
            unselectColor();
            rndPause.BackColor = Color.CadetBlue;
        }

        private void rndMeeting_CheckedChanged(object sender, EventArgs e)
        {
            currentTimeEvent = "Meeting";
            unselectColor();
            rndMeeting.BackColor = Color.CadetBlue;
        }


    }
}
