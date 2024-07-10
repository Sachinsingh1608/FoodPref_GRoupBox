using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
   
    public partial class Veg : Form
    {
        int lnidx = -1;
        bool lbAdd = false;
        private List<string> lobjRoll = new List<string>();
        private List<string> lobjName = new List<string>();
        private List<string> lobjbirthDate = new List<string>();

        private List<string> lobjOwns = new List<string>();
        private List<string> lobjfood = new List<string>();
        private List<string> lobjtongue = new List<string>();
        private List<string> lobjgender = new List<string>();
        private List<string> lobjStd = new List<string>();
        private bool lbCheck= false;
        public Veg()
        {
            InitializeComponent();
         
        }

       
        private void Gender_Enter(object sender, EventArgs e)
        {

        }
        private void LabelUpdate()
        {
            string lsAnsStr = "";
            string lsOwns = "";

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
       

            string lcFood="" ;

            if (VegBut.Checked)
            {
                lcFood = "V";
               
            }
            if (Nonveg.Checked)
            {
                lcFood = "N";
             
            }
            if (omnivores.Checked)
            {
                lcFood = "O";
               
            }




            string lcMotherToung="" ;

            if (Hindi.Checked)
            {
                lcMotherToung ="H";
           
            }
            if (English.Checked)
            {
                lcMotherToung = "E";
               
            }
            if (Urdu.Checked)
            {
                lcMotherToung = "U";
              
            }


            string lcgender="" ;

            if (Male.Checked)
            {
                lcgender = "M";
              
            }
            if (Female.Checked)
            {
                lcgender = "F";
               
            }
            if (TransGender.Checked)
            {
                lcgender = "T";
           
            }
         
            lsAnsStr +=RollNoBut.Text + "|" + Name.Text + "|" + DOB.Text + "|" + lsOwns + "|" + lcFood + "|" + lcMotherToung + "|" + lcgender;
            Data.Text = lsAnsStr;
           
            DataLoad();



        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
       
         
        }
        private void DataLoad()
        {
            if (lbCheck == true)
                Add.Enabled = true;
            else
                Add.Enabled = false;
        }
        public void FetchData()
        {
            FileStream IobjFS = new FileStream("C:\\Users\\singh\\Desktop\\Employee\\Food.txt",
                FileMode.Open, FileAccess.Read);
            StreamReader IobjSR = new StreamReader(IobjFS);
           
            while (!IobjSR.EndOfStream)
            {
                lobjStd.Add(IobjSR.ReadLine());
            }
            IobjSR.Close();

         
            foreach (string lobjStr in lobjStd)
            {
                lobjRoll.Add(lobjStr.Split('|')[0]);
                lobjName.Add(lobjStr.Split('|')[1]);
                lobjbirthDate.Add(lobjStr.Split('|')[2]);
                lobjOwns.Add(lobjStr.Split('|')[3]);
                lobjfood.Add(lobjStr.Split('|')[4]);
             
              
                lobjtongue.Add(lobjStr.Split('|')[5]);
                lobjgender.Add(lobjStr.Split('|')[6]);
               
            }
            foreach(string rollNo in lobjRoll)
            {
                if (lbCheck == false)
                {
                    RollNoBut.Items.Add(rollNo);
                   
                }
            }
            


           
            lbCheck = true;
            if (RollNoBut.Text.Length != 0 && lbAdd==false)
            {
                
                    int idx = lobjRoll.IndexOf(RollNoBut.Text);
                    Name.Text = lobjName[idx];
                    DOB.Text = lobjbirthDate[idx];
                    string lsowns = lobjOwns[idx];
                    if (lsowns[0] == 'Y')
                    {
                        Car.Checked = true;
                    }
                    else
                    {
                        Car.Checked = false;
                    }

                    if (lsowns[1] == 'Y')
                    {
                        Bike.Checked = true;
                    }
                    else
                    {
                        Bike.Checked = false;
                    }

                    if (lsowns[2] == 'Y')
                    {
                        Cycle.Checked = true;
                    }
                    else
                    {
                        Cycle.Checked = false;
                    }




                    string lsFood = lobjfood[idx];
                    if (lsFood == "O")
                    {
                        omnivores.Checked = true;
                    }
                    if (lsFood == "V")
                    {
                        VegBut.Checked = true;
                    }
                    if (lsFood == "N")
                    {
                        Nonveg.Checked = true;
                    }


                    string lsMotherTongue = lobjtongue[idx];
                    if (lsMotherTongue == "E")
                    {
                        English.Checked = true;
                    }
                    if (lsMotherTongue == "H")
                    {
                        Hindi.Checked = true;
                    }
                    if (lsMotherTongue == "U")
                    {
                        Urdu.Checked = true;
                    }



                    string lsGender = lobjgender[idx];
                    if (lsGender == "F")
                    {
                        Female.Checked = true;
                    }
                    if (lsGender == "M")
                    {
                        Male.Checked = true;
                    }

                    if (lsGender == "T")
                    {
                        TransGender.Checked = true;
                    }
                }
            



            
          
                

         







        }
        private void Veg_Load(object sender, EventArgs e)
        {
          
            FetchData();

        }
      

        private void Food_Enter(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DataReload()
        {
            string lsLastRoll = lobjRoll.Last();
            string lsLastRollNum = lsLastRoll.Split('-')[1];
            string lsFirstPartRoll = lsLastRoll.Split('-')[0];
            int lnRoll = int.Parse(lsLastRollNum);
            string lsNewRoll = "";
            if (lnRoll >= 1 && lnRoll < 9 && lbCheck == true)
            {
                lsNewRoll += lsFirstPartRoll + '-' + '0';
                lsNewRoll += (lnRoll + 1).ToString();
                RollNoBut.Items.Add(lsNewRoll);



            }
            else if (lnRoll >= 9 && lbCheck == true)
            {
                lsNewRoll += lsFirstPartRoll + '-';
                lsNewRoll += (lnRoll + 1).ToString();
                RollNoBut.Items.Add(lsNewRoll);
            }
            lbAdd = true;
            Name.Text = "";

            DOB.Text = "";
            Car.Checked = false;
            Cycle.Checked = false;
            Bike.Checked = false;
            VegBut.Checked = false;
            Nonveg.Checked = false;
            omnivores.Checked = false;
            Male.Checked = false;
            Female.Checked = false;
            TransGender.Checked = false;
            Hindi.Checked = false;
            English.Checked = false;
            Urdu.Checked = false;
            Data.Text = "";
            RollNoBut.Text = RollNoBut.Items[RollNoBut.Items.Count - 1].ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Name.Text = "";
           
            DOB.Text = "";
            Car.Checked = false;
            Cycle.Checked = false;
            Bike.Checked = false;
            VegBut.Checked= false;
            Nonveg.Checked = false;
            omnivores.Checked = false;
            Male.Checked= false;
            Female.Checked= false;
            TransGender.Checked = false;
            Hindi.Checked = false;
            English.Checked = false;
            Urdu.Checked = false;
            Data.Text = "";
           


        }

        private void Add_Click(object sender, EventArgs e)
        {
            DataReload();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

            LabelUpdate();
        }

        private void RollNoBut_SelectedIndexChanged(object sender, EventArgs e)
        {
            FetchData();
        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void Car_KeyPress(object sender, KeyPressEventArgs e)
        {
            LabelUpdate();
        }

        private void Car_CheckedChanged(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void Bike_CheckedChanged(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void Cycle_CheckedChanged(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void VegBut_CheckedChanged(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void Nonveg_CheckedChanged(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void omnivores_CheckedChanged(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void Hindi_CheckedChanged(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void English_CheckedChanged(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void Urdu_CheckedChanged(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void TransGender_CheckedChanged(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void Savedata_Click(object sender, EventArgs e)
        {
            FileStream IobjFS = new FileStream("C:\\Users\\singh\\Desktop\\Employee\\Food.txt",
                   FileMode.Append, FileAccess.Write);
            StreamWriter IobjSW = new StreamWriter(IobjFS);
            string lslabelText = Data.Text;
          
                IobjSW.WriteLine(lslabelText);
        
            IobjSW.Flush();
            IobjSW.Close();
            IobjFS.Close();





            Name.Text = "";
            RollNoBut.Text = "";
            DOB.Text = "";
            Car.Checked = false;
            Cycle.Checked = false;
            Bike.Checked = false;
            VegBut.Checked = false;
            Nonveg.Checked = false;
            omnivores.Checked = false;
            Male.Checked = false;
            Female.Checked = false;
            TransGender.Checked = false;
            Hindi.Checked = false;
            English.Checked = false;
            Urdu.Checked = false;
            Data.Text = "";
            Add.Enabled = false;
            MessageBox.Show("Data Saved!");

        }
        private void ReloadForm()
        {
           
            
        }
        private void LoadData_Click(object sender, EventArgs e)
        {
            
        }
    }
}
