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
using System.Drawing.Imaging;

namespace Focus_Timer
{

    public partial class Form1 : Form
    {
        //##############################################################
        // Globale Variablen
        // Coding 0-2  lerning 3-5  meeting 6-8  pause 9-11  sonstiges 12-14  orga 15-17
        int[] timeEvents = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int currentTimeStartIndex;
        int timeS, timeM, timeH;
        bool isActive;
        bool resetIsVisible = false;
        bool windowSizeIsBig = true;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (resetIsVisible == false)
            {
                btnReset.Visible = true;
                resetIsVisible = true;
            }
            else
            {
                btnReset.Visible = false;
                resetIsVisible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetTime();
            isActive = false;

            rndCoding.Checked = true;
            uncheckEventMenueItems();
            codenToolStripMenuItem.Checked = true;
        }

        void resetTime()
        {
            timeS = 0;
            timeM = 0;
            timeH = 0;
            timeEvents = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
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

        //##############################################################
        // Reset Button
        private void btnReset_Click(object sender, EventArgs e)
        {
            isActive = false;
            resetTime();
            btnReset.Visible = false;
            resetIsVisible = false;
        }


        //##############################################################
        //Entfärben

        void unselectColor()
        {
            rdbLerning.BackColor = Color.Transparent;
            rndCoding.BackColor = Color.Transparent;
            rndMeeting.BackColor = Color.Transparent;
            rndOrga.BackColor = Color.Transparent;
            rndPause.BackColor = Color.Transparent;
            rndSonstiges.BackColor = Color.Transparent;
        }

        //##############################################################
        // Radio Buttons
        private void rdbLerning_CheckedChanged(object sender, EventArgs e)
        {
            // Coding 0-2  lerning 3-5  meeting 6-8  pause 9-11  sonstiges 12-14  orga 15-17
            SetEvent("Lernen", 3);
            rdbLerning.BackColor = Color.CadetBlue;
            uncheckEventMenueItems();
            lernenToolStripMenuItem.Checked = true;
        }

        private void rndCoding_CheckedChanged(object sender, EventArgs e)
        {
            SetEvent("Coden", 0);
            rndCoding.BackColor = Color.CadetBlue;
            uncheckEventMenueItems();
            codenToolStripMenuItem.Checked = true;
        }

        private void rndOrga_CheckedChanged(object sender, EventArgs e)
        {
            SetEvent("Organisieren", 15);
            rndOrga.BackColor = Color.CadetBlue;
            uncheckEventMenueItems();
            organisiernToolStripMenuItem.Checked = true;
        }

        private void rndSonstiges_CheckedChanged(object sender, EventArgs e)
        {
            SetEvent("Sonstiges", 12);
            rndSonstiges.BackColor = Color.CadetBlue;
            uncheckEventMenueItems();
            sonstigesToolStripMenuItem.Checked = true;
        }

        private void rndPause_CheckedChanged(object sender, EventArgs e)
        {
            SetEvent("Pause", 9);
            rndPause.BackColor = Color.CadetBlue;
            uncheckEventMenueItems();
            pauseToolStripMenuItem.Checked = true;
        }

        private void rndMeeting_CheckedChanged(object sender, EventArgs e)
        {
            SetEvent("Meeting", 6);
            rndMeeting.BackColor = Color.CadetBlue;
            uncheckEventMenueItems();
            meetingToolStripMenuItem.Checked = true;
        }

        private void großToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeWindowBig();
        }

        private void kleinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeWindowSmall();
        }

        void makeWindowSmall()
        {
            if(windowSizeIsBig == true)
            {
                windowSizeIsBig = false;
                this.lblHr.Location = new Point(this.lblHr.Location.X - 111, this.lblHr.Location.Y - 12);
                this.label2.Location = new Point(this.label2.Location.X - 111, this.label2.Location.Y - 12);
                this.lblMin.Location = new Point(this.lblMin.Location.X - 111, this.lblMin.Location.Y - 12);
                this.label1.Location = new Point(this.label1.Location.X - 111, this.label1.Location.Y - 12);
                this.lblSec.Location = new Point(this.lblSec.Location.X - 111, this.lblSec.Location.Y - 12);
                this.btnStart.Location = new Point(this.btnStart.Location.X - 111, this.btnStart.Location.Y - 12);
                this.btnPause.Location = new Point(this.btnPause.Location.X - 111, this.btnPause.Location.Y - 12);
                this.Size = new Size(300, 150);
                this.SetDesktopLocation(0,0); // Setzt das Fenster in die obere linke ecke
            }
        }

        void makeWindowBig()
        {
            if (windowSizeIsBig == false)
            {
                windowSizeIsBig = true;
                this.lblHr.Location = new Point(this.lblHr.Location.X + 111, this.lblHr.Location.Y + 12);
                this.label2.Location = new Point(this.label2.Location.X + 111, this.label2.Location.Y + 12);
                this.lblMin.Location = new Point(this.lblMin.Location.X + 111, this.lblMin.Location.Y + 12);
                this.label1.Location = new Point(this.label1.Location.X + 111, this.label1.Location.Y + 12);
                this.lblSec.Location = new Point(this.lblSec.Location.X + 111, this.lblSec.Location.Y + 12);
                this.btnStart.Location = new Point(this.btnStart.Location.X + 111, this.btnStart.Location.Y + 12);
                this.btnPause.Location = new Point(this.btnPause.Location.X + 111, this.btnPause.Location.Y + 12);
                this.Size = new Size(501, 386);
            }
        }



        private void kleinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            makeWindowSmall();
        }

        private void großToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            makeWindowBig();
        }



        //##############################################################
        // Timer Tick
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

                // Array Incrementierung vom current event timer z.B. Coding, lernen etc
                timeEvents[currentTimeStartIndex] += 1;
                if(timeEvents[currentTimeStartIndex] >= 60)
                {
                    timeEvents[currentTimeStartIndex + 1] += 1;
                    timeEvents[currentTimeStartIndex] = 0;

                    if(timeEvents[currentTimeStartIndex + 1] >= 60)
                    {
                        timeEvents[currentTimeStartIndex + 1] = 0;
                        timeEvents[currentTimeStartIndex + 2] += 1;
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

        

        //##############################################################
        // Draw Time
        void drawTime()
        {
            lblHr.Text = String.Format("{0:00}", timeH);
            lblMin.Text = String.Format("{0:00}", timeM);
            lblSec.Text = String.Format("{0:00}", timeS);
            lbl_coding.Text = "Coding: " +  String.Format("{0:00}", timeEvents[2]) + ":" + String.Format("{0:00}", timeEvents[1]) + ":" + String.Format("{0:00}", timeEvents[0]);
            lbl_lerning.Text = "Lernen: " + String.Format("{0:00}", timeEvents[5]) + ":" + String.Format("{0:00}", timeEvents[4]) + ":" + String.Format("{0:00}", timeEvents[3]);
            lbl_meeting.Text = "Meeting: " + String.Format("{0:00}", timeEvents[8]) + ":" + String.Format("{0:00}", timeEvents[7]) + ":" + String.Format("{0:00}", timeEvents[6]);
            lbl_pause.Text = "Pause: " + String.Format("{0:00}", timeEvents[11]) + ":" + String.Format("{0:00}", timeEvents[10]) + ":" + String.Format("{0:00}", timeEvents[9]);
            lbl_orga.Text = "Orga: " + String.Format("{0:00}", timeEvents[17]) + ":" + String.Format("{0:00}", timeEvents[16]) + ":" + String.Format("{0:00}", timeEvents[15]);
            lbl_sonstiges.Text = "Sonstiges: " + String.Format("{0:00}", timeEvents[14]) + ":" + String.Format("{0:00}", timeEvents[13]) + ":" + String.Format("{0:00}", timeEvents[12]);
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void einToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            ausToolStripMenuItem.Checked = false;
            einToolStripMenuItem.Checked = true;
        }

        private void ausToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            einToolStripMenuItem.Checked = false;
            ausToolStripMenuItem.Checked = true;
        }

        private void hellblauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RoyalBlue;
        }

        private void schwarzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void grauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSlateGray;
        }

        private void dunkelgrünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOliveGreen;
        }

        private void tealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Teal;
        }

        private void midnightBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.MidnightBlue;
        }

        private void cornflowerBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CornflowerBlue;
        }

        // Menübutton Event
        private void lernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdbLerning.Checked = true;
        }

        private void codenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rndCoding.Checked = true;
        }

        private void organisiernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rndOrga.Checked = true;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rndPause.Checked = true;
        }

        private void meetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rndMeeting.Checked = true;
        }

        private void sonstigesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rndSonstiges.Checked = true;
        }

        private void screenshotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                // System.Reflection.Assembly.GetExecutingAssembly().Location
                
                DateTime thisDay = DateTime.Today;
                string imageName = "/Results/Ergebnis_" + thisDay.ToString("D") + ".jpg";
                string pathName = Application.StartupPath + imageName;
                bitmap.Save(pathName, ImageFormat.Jpeg);
                MessageBox.Show("Gespeichert unter: " + pathName);
                //bitmap.Save("D:/Neuer Ordner/test.jpg", ImageFormat.Jpeg);
            }

        }

        void SetEvent(string evnt, int strtIndx)
        {
            // Coding 0-2  lerning 3-5  meeting 6-8  pause 9-11  sonstiges 12-14  orga 15-17
            currentTimeStartIndex = strtIndx;
            unselectColor();
            this.Text = "Focus Timer - " + evnt;
        }

        void uncheckEventMenueItems()
        {
            codenToolStripMenuItem.Checked = false;
            lernenToolStripMenuItem.Checked = false;
            sonstigesToolStripMenuItem.Checked = false;
            meetingToolStripMenuItem.Checked = false;
            organisiernToolStripMenuItem.Checked = false;
            pauseToolStripMenuItem.Checked = false;
        }


    }


}
