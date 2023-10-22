namespace Project_1
{
    partial class B1CH14Form
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
            this.eitherRB = new System.Windows.Forms.RadioButton();
            this.secondRB = new System.Windows.Forms.RadioButton();
            this.firstRB = new System.Windows.Forms.RadioButton();
            this.bothRB = new System.Windows.Forms.RadioButton();
            this.uniqueRB = new System.Windows.Forms.RadioButton();
            this.outputLB = new System.Windows.Forms.ListBox();
            this.instructionsLBL = new System.Windows.Forms.Label();
            this.variablesLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 5;
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
            this.variablesLoadToolStripMenuItem,
            this.radioButtonsToolStripMenuItem});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // eitherRB
            // 
            this.eitherRB.Location = new System.Drawing.Point(175, 308);
            this.eitherRB.Name = "eitherRB";
            this.eitherRB.Size = new System.Drawing.Size(237, 38);
            this.eitherRB.TabIndex = 4;
            this.eitherRB.TabStop = true;
            this.eitherRB.Text = "Show words that appear in either first or second file, but not both";
            this.eitherRB.UseVisualStyleBackColor = true;
            this.eitherRB.CheckedChanged += new System.EventHandler(this.eitherRB_CheckedChanged);
            // 
            // secondRB
            // 
            this.secondRB.AutoSize = true;
            this.secondRB.Location = new System.Drawing.Point(175, 267);
            this.secondRB.Name = "secondRB";
            this.secondRB.Size = new System.Drawing.Size(206, 20);
            this.secondRB.TabIndex = 3;
            this.secondRB.TabStop = true;
            this.secondRB.Text = "Show words in second file only";
            this.secondRB.UseVisualStyleBackColor = true;
            this.secondRB.CheckedChanged += new System.EventHandler(this.secondRB_CheckedChanged);
            // 
            // firstRB
            // 
            this.firstRB.AutoSize = true;
            this.firstRB.Location = new System.Drawing.Point(175, 215);
            this.firstRB.Name = "firstRB";
            this.firstRB.Size = new System.Drawing.Size(181, 20);
            this.firstRB.TabIndex = 2;
            this.firstRB.TabStop = true;
            this.firstRB.Text = "Show words in first file only";
            this.firstRB.UseVisualStyleBackColor = true;
            this.firstRB.CheckedChanged += new System.EventHandler(this.firstRB_CheckedChanged);
            // 
            // bothRB
            // 
            this.bothRB.AutoSize = true;
            this.bothRB.Location = new System.Drawing.Point(175, 167);
            this.bothRB.Name = "bothRB";
            this.bothRB.Size = new System.Drawing.Size(237, 20);
            this.bothRB.TabIndex = 1;
            this.bothRB.TabStop = true;
            this.bothRB.Text = "Show words that appear in both files";
            this.bothRB.UseVisualStyleBackColor = true;
            this.bothRB.CheckedChanged += new System.EventHandler(this.bothRB_CheckedChanged);
            // 
            // uniqueRB
            // 
            this.uniqueRB.Location = new System.Drawing.Point(175, 108);
            this.uniqueRB.Name = "uniqueRB";
            this.uniqueRB.Size = new System.Drawing.Size(163, 36);
            this.uniqueRB.TabIndex = 0;
            this.uniqueRB.TabStop = true;
            this.uniqueRB.Text = "Show all unique words contained in both files";
            this.uniqueRB.UseVisualStyleBackColor = true;
            this.uniqueRB.CheckedChanged += new System.EventHandler(this.uniqueRB_CheckedChanged);
            // 
            // outputLB
            // 
            this.outputLB.FormattingEnabled = true;
            this.outputLB.ItemHeight = 16;
            this.outputLB.Location = new System.Drawing.Point(16, 108);
            this.outputLB.Name = "outputLB";
            this.outputLB.Size = new System.Drawing.Size(144, 228);
            this.outputLB.TabIndex = 7;
            // 
            // instructionsLBL
            // 
            this.instructionsLBL.Location = new System.Drawing.Point(34, 40);
            this.instructionsLBL.Name = "instructionsLBL";
            this.instructionsLBL.Size = new System.Drawing.Size(358, 49);
            this.instructionsLBL.TabIndex = 6;
            this.instructionsLBL.Text = "This program reads the contents of two text files, and allows you to display diff" +
    "erent results. Select an option on the right of the ListBox to get started!";
            this.instructionsLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // variablesLoadToolStripMenuItem
            // 
            this.variablesLoadToolStripMenuItem.Name = "variablesLoadToolStripMenuItem";
            this.variablesLoadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.variablesLoadToolStripMenuItem.Text = "Variables, Load";
            this.variablesLoadToolStripMenuItem.Click += new System.EventHandler(this.variablesLoadToolStripMenuItem_Click);
            // 
            // radioButtonsToolStripMenuItem
            // 
            this.radioButtonsToolStripMenuItem.Name = "radioButtonsToolStripMenuItem";
            this.radioButtonsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radioButtonsToolStripMenuItem.Text = "Radio Buttons";
            this.radioButtonsToolStripMenuItem.Click += new System.EventHandler(this.radioButtonsToolStripMenuItem_Click);
            // 
            // B1CH14Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 367);
            this.Controls.Add(this.eitherRB);
            this.Controls.Add(this.secondRB);
            this.Controls.Add(this.firstRB);
            this.Controls.Add(this.bothRB);
            this.Controls.Add(this.uniqueRB);
            this.Controls.Add(this.outputLB);
            this.Controls.Add(this.instructionsLBL);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "B1CH14Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text File Analysis";
            this.Load += new System.EventHandler(this.B1CH14Form_Load);
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
        private System.Windows.Forms.RadioButton eitherRB;
        private System.Windows.Forms.RadioButton secondRB;
        private System.Windows.Forms.RadioButton firstRB;
        private System.Windows.Forms.RadioButton bothRB;
        private System.Windows.Forms.RadioButton uniqueRB;
        private System.Windows.Forms.ListBox outputLB;
        private System.Windows.Forms.Label instructionsLBL;
        private System.Windows.Forms.ToolStripMenuItem variablesLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radioButtonsToolStripMenuItem;
    }
}