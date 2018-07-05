using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Packman_Game
{
    public partial class Form1 : Form
    {

        public int leftPos = 4;
        public int topPos = 4;
        public int count = 0;
        public int findTimer = 0;

       

        public Form1()
        {
            InitializeComponent();
            packman.Left = 120;
            packman.Top = 100;
       
        }


       

        private void startGame_Click(object sender, EventArgs e)
        {
            count++;
            timer1.Start();

            if (count > 0)
            {
                startGame.Enabled = false;
            }  
             
        }

        public void Crash()
        {

            if (packman.Left <= obs.Left + obs.Width)
            {
                timer1.Stop();
            }
            else if (packman.Left + packman.Width >= obs2.Left)
            {
                timer1.Stop();
            }
            else if (packman.Top <= obs3.Bottom)
            {
                timer1.Stop();
            }
            else if (packman.Top + packman.Width >= obs4.Top)
            {
                timer1.Stop();
            }
           
        }

        public void CrashMiddle()
        {


            if (packman.Left <= midObs6.Left+midObs6.Width)
            {
                timer1.Stop();
            }
            if (packman.Bottom < midObs6.Top && packman.Top < midObs6.Bottom)
            {
                timer1.Start();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            packman.Left += leftPos;

            //Crash();
            //CrashMiddle();

            if (findTimer == 1)
            {
                packman.Left -= leftPos;
                packman.Top += topPos;
                //Crash();
                //CrashMiddle();
            }
            else if (findTimer == 2)
            {
                packman.Left -= leftPos;
                packman.Top -= topPos;
                //Crash();
                //CrashMiddle();
            }
            else if (findTimer == 3)
            {
                if ((packman.Right>=midObs1.Left)&&(packman.Bottom>midObs1.Top)&&(packman.Top<midObs1.Bottom))
                {
                    timer1.Enabled = false;

                }

                packman.Left += leftPos;
                //Crash();
                //CrashMiddle();


            }
            else if (findTimer == 4)
            {
                packman.Left -= leftPos + 4;
                //Crash();
                //CrashMiddle();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                findTimer = 1;

               

            }
            else if (e.KeyCode == Keys.Up)
            {
                findTimer = 2;

                
            }
            else if (e.KeyCode == Keys.Right)
            {
                findTimer = 3;


               
            }
            else if (e.KeyCode == Keys.Left)
            {
                findTimer = 4;

                
            }

          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
