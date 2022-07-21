using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Focus_Timer
{

    public partial class Form1 : Form
    {
        public int wholeTime = 0;
        public int codingTime = 0;
        public int lerningTime = 0;
        public int meetingTime = 0;
        public int orgaTime = 0;
        public int sonstigesTime = 0;
        public int pauseTime = 0;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            System.Console.WriteLine(timer1);
        }


       
    }
}
