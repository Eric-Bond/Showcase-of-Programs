namespace Project_1
{
    partial class B1CH11Form
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
            this.infoLBL = new System.Windows.Forms.Label();
            this.magicBTN = new System.Windows.Forms.Button();
            this.outputLBL = new System.Windows.Forms.Label();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.instructionLBL = new System.Windows.Forms.Label();
            this.wordRB = new System.Windows.Forms.RadioButton();
            this.backwardsRB = new System.Windows.Forms.RadioButton();
            this.phoneRB = new System.Windows.Forms.RadioButton();
            this.dateRB = new System.Windows.Forms.RadioButton();
            this.arrayRB = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magicButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extensionMethodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extensionMethods2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoLBL
            // 
            this.infoLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoLBL.Location = new System.Drawing.Point(48, 279);
            this.infoLBL.Name = "infoLBL";
            this.infoLBL.Padding = new System.Windows.Forms.Padding(10);
            this.infoLBL.Size = new System.Drawing.Size(354, 76);
            this.infoLBL.TabIndex = 10;
            // 
            // magicBTN
            // 
            this.magicBTN.Location = new System.Drawing.Point(175, 371);
            this.magicBTN.Name = "magicBTN";
            this.magicBTN.Size = new System.Drawing.Size(100, 41);
            this.magicBTN.TabIndex = 6;
            this.magicBTN.Text = "Magic!";
            this.magicBTN.UseVisualStyleBackColor = true;
            this.magicBTN.Click += new System.EventHandler(this.magicBTN_Click);
            // 
            // outputLBL
            // 
            this.outputLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLBL.Location = new System.Drawing.Point(162, 171);
            this.outputLBL.Name = "outputLBL";
            this.outputLBL.Padding = new System.Windows.Forms.Padding(5);
            this.outputLBL.Size = new System.Drawing.Size(240, 88);
            this.outputLBL.TabIndex = 9;
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(162, 80);
            this.inputTB.Multiline = true;
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(240, 88);
            this.inputTB.TabIndex = 5;
            // 
            // instructionLBL
            // 
            this.instructionLBL.AutoSize = true;
            this.instructionLBL.Location = new System.Drawing.Point(10, 49);
            this.instructionLBL.Name = "instructionLBL";
            this.instructionLBL.Size = new System.Drawing.Size(431, 16);
            this.instructionLBL.TabIndex = 8;
            this.instructionLBL.Text = "Select one of the Radio Buttons on the left, then follow further instructions!";
            // 
            // wordRB
            // 
            this.wordRB.AutoSize = true;
            this.wordRB.Location = new System.Drawing.Point(48, 242);
            this.wordRB.Name = "wordRB";
            this.wordRB.Size = new System.Drawing.Size(101, 20);
            this.wordRB.TabIndex = 4;
            this.wordRB.Text = "word counter";
            this.wordRB.UseVisualStyleBackColor = true;
            this.wordRB.CheckedChanged += new System.EventHandler(this.wordRB_CheckedChanged);
            // 
            // backwardsRB
            // 
            this.backwardsRB.AutoSize = true;
            this.backwardsRB.Location = new System.Drawing.Point(48, 200);
            this.backwardsRB.Name = "backwardsRB";
            this.backwardsRB.Size = new System.Drawing.Size(91, 20);
            this.backwardsRB.TabIndex = 3;
            this.backwardsRB.Text = "backwards";
            this.backwardsRB.UseVisualStyleBackColor = true;
            this.backwardsRB.CheckedChanged += new System.EventHandler(this.backwardsRB_CheckedChanged);
            // 
            // phoneRB
            // 
            this.phoneRB.AutoSize = true;
            this.phoneRB.Location = new System.Drawing.Point(48, 160);
            this.phoneRB.Name = "phoneRB";
            this.phoneRB.Size = new System.Drawing.Size(111, 20);
            this.phoneRB.TabIndex = 2;
            this.phoneRB.Text = "phone number";
            this.phoneRB.UseVisualStyleBackColor = true;
            this.phoneRB.CheckedChanged += new System.EventHandler(this.phoneRB_CheckedChanged);
            // 
            // dateRB
            // 
            this.dateRB.AutoSize = true;
            this.dateRB.Location = new System.Drawing.Point(48, 120);
            this.dateRB.Name = "dateRB";
            this.dateRB.Size = new System.Drawing.Size(94, 20);
            this.dateRB.TabIndex = 1;
            this.dateRB.Text = "date splitter";
            this.dateRB.UseVisualStyleBackColor = true;
            this.dateRB.CheckedChanged += new System.EventHandler(this.dateRB_CheckedChanged);
            // 
            // arrayRB
            // 
            this.arrayRB.AutoSize = true;
            this.arrayRB.Location = new System.Drawing.Point(48, 81);
            this.arrayRB.Name = "arrayRB";
            this.arrayRB.Size = new System.Drawing.Size(85, 20);
            this.arrayRB.TabIndex = 0;
            this.arrayRB.Text = "char array";
            this.arrayRB.UseVisualStyleBackColor = true;
            this.arrayRB.CheckedChanged += new System.EventHandler(this.arrayRB_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 24);
            this.menuStrip1.TabIndex = 7;
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
            this.radioButtonsToolStripMenuItem,
            this.magicButtonToolStripMenuItem,
            this.extensionMethodsToolStripMenuItem,
            this.extensionMethods2ToolStripMenuItem});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // radioButtonsToolStripMenuItem
            // 
            this.radioButtonsToolStripMenuItem.Name = "radioButtonsToolStripMenuItem";
            this.radioButtonsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.radioButtonsToolStripMenuItem.Text = "Radio Buttons";
            this.radioButtonsToolStripMenuItem.Click += new System.EventHandler(this.radioButtonsToolStripMenuItem_Click);
            // 
            // magicButtonToolStripMenuItem
            // 
            this.magicButtonToolStripMenuItem.Name = "magicButtonToolStripMenuItem";
            this.magicButtonToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.magicButtonToolStripMenuItem.Text = "Magic Button";
            this.magicButtonToolStripMenuItem.Click += new System.EventHandler(this.magicButtonToolStripMenuItem_Click);
            // 
            // extensionMethodsToolStripMenuItem
            // 
            this.extensionMethodsToolStripMenuItem.Name = "extensionMethodsToolStripMenuItem";
            this.extensionMethodsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.extensionMethodsToolStripMenuItem.Text = "Extension Methods";
            this.extensionMethodsToolStripMenuItem.Click += new System.EventHandler(this.extensionMethodsToolStripMenuItem_Click);
            // 
            // extensionMethods2ToolStripMenuItem
            // 
            this.extensionMethods2ToolStripMenuItem.Name = "extensionMethods2ToolStripMenuItem";
            this.extensionMethods2ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.extensionMethods2ToolStripMenuItem.Text = "Extension Methods (2)";
            this.extensionMethods2ToolStripMenuItem.Click += new System.EventHandler(this.extensionMethods2ToolStripMenuItem_Click);
            // 
            // B1CH11Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 428);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.infoLBL);
            this.Controls.Add(this.magicBTN);
            this.Controls.Add(this.outputLBL);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.instructionLBL);
            this.Controls.Add(this.wordRB);
            this.Controls.Add(this.backwardsRB);
            this.Controls.Add(this.phoneRB);
            this.Controls.Add(this.dateRB);
            this.Controls.Add(this.arrayRB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "B1CH11Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Extension Methods";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLBL;
        private System.Windows.Forms.Button magicBTN;
        private System.Windows.Forms.Label outputLBL;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Label instructionLBL;
        private System.Windows.Forms.RadioButton wordRB;
        private System.Windows.Forms.RadioButton backwardsRB;
        private System.Windows.Forms.RadioButton phoneRB;
        private System.Windows.Forms.RadioButton dateRB;
        private System.Windows.Forms.RadioButton arrayRB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radioButtonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magicButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extensionMethodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extensionMethods2ToolStripMenuItem;
    }
}