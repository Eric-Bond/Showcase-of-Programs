namespace Project_1
{
    partial class B1CH13Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputTotalLBL = new System.Windows.Forms.Label();
            this.infoTotalLBL = new System.Windows.Forms.Label();
            this.outputLB = new System.Windows.Forms.ListBox();
            this.instructionsLBL = new System.Windows.Forms.Label();
            this.findBTN = new System.Windows.Forms.Button();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(320, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // outputTotalLBL
            // 
            this.outputTotalLBL.Location = new System.Drawing.Point(229, 351);
            this.outputTotalLBL.Name = "outputTotalLBL";
            this.outputTotalLBL.Size = new System.Drawing.Size(55, 22);
            this.outputTotalLBL.TabIndex = 6;
            this.outputTotalLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoTotalLBL
            // 
            this.infoTotalLBL.AutoSize = true;
            this.infoTotalLBL.Location = new System.Drawing.Point(95, 354);
            this.infoTotalLBL.Name = "infoTotalLBL";
            this.infoTotalLBL.Size = new System.Drawing.Size(134, 16);
            this.infoTotalLBL.TabIndex = 5;
            this.infoTotalLBL.Text = "Total Prime numbers:";
            // 
            // outputLB
            // 
            this.outputLB.FormattingEnabled = true;
            this.outputLB.ItemHeight = 16;
            this.outputLB.Location = new System.Drawing.Point(100, 162);
            this.outputLB.Name = "outputLB";
            this.outputLB.Size = new System.Drawing.Size(120, 180);
            this.outputLB.TabIndex = 4;
            // 
            // instructionsLBL
            // 
            this.instructionsLBL.Location = new System.Drawing.Point(12, 32);
            this.instructionsLBL.Name = "instructionsLBL";
            this.instructionsLBL.Size = new System.Drawing.Size(296, 55);
            this.instructionsLBL.TabIndex = 3;
            this.instructionsLBL.Text = "Enter a number into the text box below, then press the \'Find\' button to see all t" +
    "he Prime numbers from 2 up to your number!";
            this.instructionsLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findBTN
            // 
            this.findBTN.Location = new System.Drawing.Point(121, 125);
            this.findBTN.Name = "findBTN";
            this.findBTN.Size = new System.Drawing.Size(78, 25);
            this.findBTN.TabIndex = 1;
            this.findBTN.Text = "Find";
            this.findBTN.UseVisualStyleBackColor = true;
            this.findBTN.Click += new System.EventHandler(this.findBTN_Click);
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(121, 91);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(78, 22);
            this.inputTB.TabIndex = 0;
            this.inputTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // B1CH13Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 383);
            this.Controls.Add(this.outputTotalLBL);
            this.Controls.Add(this.infoTotalLBL);
            this.Controls.Add(this.outputLB);
            this.Controls.Add(this.instructionsLBL);
            this.Controls.Add(this.findBTN);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "B1CH13Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prime Number Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.Label outputTotalLBL;
        private System.Windows.Forms.Label infoTotalLBL;
        private System.Windows.Forms.ListBox outputLB;
        private System.Windows.Forms.Label instructionsLBL;
        private System.Windows.Forms.Button findBTN;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
    }
}