using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Character_Generator
{
    public partial class Form1 : Form
    {
        string path = "characters.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            bool[] option;
            option = new bool[3];
            option[1] = true;
            option[2] = false;

            string[] optionName;
            optionName = new string[3];
            optionName[1] = "Speed";
            optionName[2] = "Endurance";

            int divide = 1;
            int stat = 1;

            Random random = new Random();


            //Check if file exits and create if doesn't
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(" ");
                }
            }

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

            //add name to file
            rtbOut.AppendText(tbName.Text + Environment.NewLine);
            File.AppendAllText(path, tbName.Text + Environment.NewLine);

            //generate values
            for (int i = 1; i <= 2; i++)
            {
                divide = random.Next(1, 4);
                stat = random.Next(5, 20) / divide;

                if (option[i] == true)
                {
                    if (stat <= 10)//if prefered stat is <= 10, increase by 10 to make it better
                    {
                        stat += 10;
                    }
                    
                }
                else if (stat == 1)
                {
                    stat = 2; //stops bad values for actual code
                }

                rtbOut.AppendText(optionName[i] + ": " + stat.ToString() + Environment.NewLine);
                File.AppendAllText(path, optionName[i] + ": " + stat.ToString() + Environment.NewLine);
            }

            btnGenerate.Enabled = false;

        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(" ");
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", path);
        }

        private void newCharactorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            btnGenerate.Enabled = true;
            rtbOut.Text = "";
        }
    }
}
