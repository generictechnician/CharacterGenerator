using System;
using System.Windows.Forms;
using System.IO;

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
            
            //Does File Exist? if No, Create it!
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");
            }
            //add name to file
            rtbOut.AppendText(tbName.Text + Environment.NewLine);
            File.AppendAllText(filePath, "<name>" + tbName.Text +  Environment.NewLine);

            //Get Values
            stat[1] = (int)numMin.Value;
            stat[2] = (int)numMax.Value;
            stat[3] = (int)numEndurance.Value;

            //add stats to file and Out Box
            for (int i = 1; i < optionName.Length; i++)
            {
                rtbOut.AppendText(optionName[i] + ": " + stat[i].ToString() + Environment.NewLine);
                File.AppendAllText(filePath, "<" + optionName[i] + ">" + stat[i].ToString() + Environment.NewLine);
            }

            //Reset Values
            tbName.Text = "";
            numMin.Value = 1;
            numMax.Value = 1;
            numEndurance.Value = 50;
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

        private void showOutputsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OutInfo == false)
            {
                this.Height = 370;
                OutInfo = true;
            }
            else
            {
                this.Height = 260;
                OutInfo = false;
            }
        }
    }
}
