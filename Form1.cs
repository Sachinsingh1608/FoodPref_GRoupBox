using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Veg : Form
    {
        public Veg()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer1 = new Timer();
            timer1.Interval = 200; 
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        private void Gender_Enter(object sender, EventArgs e)
        {

        }
        private void LabelUpdate()
        {
            int lnCounter = 0;
            string lsOwns = "";
            if (Name.Text.Length > 0 && RollNoBut.Text.Length > 0 && DOB.Text.Length>0)
            {
                if (Car.Checked)
                {
                    lsOwns += 'Y';
                }
                else
                {
                    lsOwns += 'N';
                }

                if (Bike.Checked)
                {
                    lsOwns += 'Y';
                }
                else
                {
                    lsOwns += 'N';
                }


                if (Cycle.Checked)
                {
                    lsOwns += 'Y';
                }
                else
                {
                    lsOwns += 'N';
                }
                lnCounter++;
            }
            char lcFood='X' ;
            if (lnCounter == 1)
            {
                
               if(VegBut.Checked)
                {
                    lcFood = 'V';
                    lnCounter++;
                }
               if(Nonveg.Checked)
                {
                    lcFood = 'N';
                    lnCounter++;
                }
               if(omnivores.Checked)
                {
                    lcFood = 'O';
                    lnCounter++;
                }
              

            }

            char lcMotherToung='X' ;
          if(lnCounter == 2)
            {
               if(Hindi.Checked)
                {
                    lcMotherToung = 'H';
                    lnCounter++;
                }
               if(English.Checked)
                {
                    lcMotherToung = 'E';
                    lnCounter++;
                }
                if (Urdu.Checked)
                {
                    lcMotherToung = 'U';
                    lnCounter++;
                }
               
            }
            char lcgender = 'X';
          if(lnCounter == 3)
            {
                if(Male.Checked)
                {
                    lcgender = 'M';
                    lnCounter++;
                }
                if(Female.Checked)
                {
                    lcgender = 'F';
                    lnCounter++;
                }
                if(TransGender.Checked)
                {
                    lcgender = 'T';
                    lnCounter++;
                }
           
            }

           

            if (lnCounter == 4)
            {
                Data.Text = RollNoBut.Text + " , " + Name.Text + " , " + DOB.Text + " , " + lsOwns + " , " + lcFood + " , " + lcMotherToung+" , "+lcgender;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void Veg_Load(object sender, EventArgs e)
        {
           
        }

        private void Food_Enter(object sender, EventArgs e)
        {

        }
    }
}
