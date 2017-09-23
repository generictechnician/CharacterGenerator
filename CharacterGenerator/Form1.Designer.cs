namespace Character_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.numEndurance = new System.Windows.Forms.NumericUpDown();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblEndurance = new System.Windows.Forms.Label();
            this.showOutputsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndurance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(16, 167);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(266, 51);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(13, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 23);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 23);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Character Generator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbOut
            // 
            this.rtbOut.Location = new System.Drawing.Point(46, 224);
            this.rtbOut.MaxLength = 65535;
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.ReadOnly = true;
            this.rtbOut.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbOut.Size = new System.Drawing.Size(203, 93);
            this.rtbOut.TabIndex = 6;
            this.rtbOut.Text = "";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(57, 54);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(214, 20);
            this.tbName.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.showOutputsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(151, 89);
            this.numMin.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(120, 20);
            this.numMin.TabIndex = 2;
            this.numMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(151, 115);
            this.numMax.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(120, 20);
            this.numMax.TabIndex = 3;
            this.numMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numEndurance
            // 
            this.numEndurance.Location = new System.Drawing.Point(151, 141);
            this.numEndurance.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numEndurance.Name = "numEndurance";
            this.numEndurance.Size = new System.Drawing.Size(120, 20);
            this.numEndurance.TabIndex = 4;
            this.numEndurance.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblMin
            // 
            this.lblMin.Location = new System.Drawing.Point(43, 91);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(100, 18);
            this.lblMin.TabIndex = 25;
            this.lblMin.Text = "Minimum Speed";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMax
            // 
            this.lblMax.Location = new System.Drawing.Point(45, 115);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(100, 18);
            this.lblMax.TabIndex = 26;
            this.lblMax.Text = "Maximum Speed";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndurance
            // 
            this.lblEndurance.Location = new System.Drawing.Point(45, 143);
            this.lblEndurance.Name = "lblEndurance";
            this.lblEndurance.Size = new System.Drawing.Size(100, 18);
            this.lblEndurance.TabIndex = 27;
            this.lblEndurance.Text = "Endurance";
            this.lblEndurance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showOutputsToolStripMenuItem
            // 
            this.showOutputsToolStripMenuItem.Name = "showOutputsToolStripMenuItem";
            this.showOutputsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showOutputsToolStripMenuItem.Text = "Show Outputs";
            this.showOutputsToolStripMenuItem.Click += new System.EventHandler(this.showOutputsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 221);
            this.Controls.Add(this.lblEndurance);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.numEndurance);
            this.Controls.Add(this.numMax);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rtbOut);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(310, 370);
            this.MinimumSize = new System.Drawing.Size(310, 260);
            this.Name = "Form1";
            this.Text = "Character Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndurance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.NumericUpDown numEndurance;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblEndurance;
        private System.Windows.Forms.ToolStripMenuItem showOutputsToolStripMenuItem;
    }
}

