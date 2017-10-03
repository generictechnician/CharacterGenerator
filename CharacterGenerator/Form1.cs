using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Character_Generator
{
    public partial class Form1 : Form
    {
        string filePath = "characters.info";
        bool OutInfo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Vars & Arrays
            string[] optionName = new string[4];
            optionName[1] = "minS";
            optionName[2] = "maxS";
            optionName[3] = "endu";
            int[] stat = new int[4];
            
            //Create empty File
            File.WriteAllText(filePath, "");
            //add name to file and textbox
            rtbOut.AppendText(tbName.Text + Environment.NewLine);
            File.AppendAllText(filePath, "<name>" + tbName.Text +  Environment.NewLine);

            //Get Values
            stat[1] = (int)numMin.Value;
            stat[2] = (int)numMax.Value;
            stat[3] = (int)numEndurance.Value;


            //error check values - greater than or smaller than each other
            if (stat[2] < stat[1] || stat[1] > stat[2])
            {
                string message = "The minimum speed was greater than the maximum speed" + Environment.NewLine + "That will break something." + Environment.NewLine + "Please try again!";
                string title = "No";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //add stats to file and Out Box
                for (int i = 1; i < optionName.Length; i++)
                {
                    rtbOut.AppendText(optionName[i] + ": " + stat[i].ToString() + Environment.NewLine);
                    File.AppendAllText(filePath, "<" + optionName[i] + ">" + stat[i].ToString() + Environment.NewLine);
                }
            }
            //Reset Values to allow easier creation of further chars
            tbName.Text = "";
            numMin.Value = 1;
            numMax.Value = 1;
            numEndurance.Value = 50;
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a blank text file. 
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine("");
            }
        }

        private void showOutputsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Expands the interface to show the output box. Mainly for debugging
            //based on a true/false var
            if (OutInfo == false)
            {
                this.Height = 425;
                OutInfo = true;
            }
            else
            {
                this.Height = 320;
                OutInfo = false;
            }
        }

        private void randomiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Generate computer random statistics based on the minimum and maximum values for the num boxes
            Random random = new Random();
            numMin.Value = random.Next((int)numMin.Minimum, ((int)numMin.Maximum - 1));//-1 to ensure there is a value to generate for max speed
            numMax.Value = random.Next((int)numMin.Value, (int)numMax.Maximum);//get the value of the minimum to ensure that the value is higher
            numEndurance.Value = random.Next((int)numEndurance.Minimum, (int)numEndurance.Maximum);
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            //open the second program and close this one!
            Process.Start("AnimalRacing.exe");
            this.Close();
        }

        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Remove the file
            File.Delete(filePath);
        }
    }
}
