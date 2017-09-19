using System;
using System.Windows.Forms;
using System.IO;

namespace Character_Generator
{
    public partial class Form1 : Form
    {
        string filePath = "characters.info";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Vars & Arrays
            bool[] option;
            option = new bool[3];
            option[1] = true;
            option[2] = false;
            string[] optionName;
            optionName = new string[3];
            optionName[1] = "speed";
            optionName[2] = "endurance";
            int[] stat;
            stat = new int[3];
            int divide = 1;
            Random random = new Random();

            //check which checkbox selected
            if (rBSpeed.Checked == true)
            {
                option[1] = true;
                option[2] = false;
            }
            else if (rBEndurance.Checked == true)
            {
                option[1] = false;
                option[2] = true;
            }
            else
            {
                option[1] = false;
                option[2] = false;
            }
            //Does File Exist?
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");
            }
            //add name to file
            File.AppendAllText(filePath, "<character>" + Environment.NewLine);
            rtbOut.AppendText(tbName.Text + Environment.NewLine);
            File.AppendAllText(filePath, "<name>" + tbName.Text + "</name>" + Environment.NewLine);
            //generate values
            for (int i = 1; i <= 2; i++)
            {
                divide = random.Next(1, 4);
                stat[i] = random.Next(5, 20) / divide;
                if (option[i] == true)
                {
                    if (stat[i] <= 10)//if prefered stat is <= 10, increase by 10 to make it better
                    {
                        stat[i] += 10;
                    } 
                }
                else if (stat[i] == 1)
                {
                    stat[i] = 2; //stops bad values for actual code
                }
                rtbOut.AppendText(optionName[i] + ": " + stat[i].ToString() + Environment.NewLine);
                File.AppendAllText(filePath, "<" + optionName[i] + ">" + stat[i].ToString() + "</" + optionName[i] + ">" + Environment.NewLine);
            }
            File.AppendAllText(filePath, "</character>" + Environment.NewLine);
            btnGenerate.Enabled = false;
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine("");
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", filePath);
        }

        private void newCharactorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            btnGenerate.Enabled = true;
            rtbOut.Text = "";
        }
    }
}
