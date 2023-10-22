namespace Project_1
{
    partial class B2CH3Form
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
            this.balanceTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.outputLB = new System.Windows.Forms.ListBox();
            this.txtLBL4 = new System.Windows.Forms.Label();
            this.replaceBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.txtLBL3 = new System.Windows.Forms.Label();
            this.txtLBL2 = new System.Windows.Forms.Label();
            this.txtLBL1 = new System.Windows.Forms.Label();
            this.classMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAddButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
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
            this.classMethodToolStripMenuItem,
            this.loadAddButtonToolStripMenuItem,
            this.replaceButtonToolStripMenuItem});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // balanceTB
            // 
            this.balanceTB.Location = new System.Drawing.Point(122, 118);
            this.balanceTB.Name = "balanceTB";
            this.balanceTB.Size = new System.Drawing.Size(100, 22);
            this.balanceTB.TabIndex = 2;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(122, 76);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 22);
            this.nameTB.TabIndex = 1;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(122, 36);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 22);
            this.idTB.TabIndex = 0;
            // 
            // outputLB
            // 
            this.outputLB.FormattingEnabled = true;
            this.outputLB.ItemHeight = 16;
            this.outputLB.Location = new System.Drawing.Point(302, 60);
            this.outputLB.Name = "outputLB";
            this.outputLB.Size = new System.Drawing.Size(219, 132);
            this.outputLB.TabIndex = 10;
            // 
            // txtLBL4
            // 
            this.txtLBL4.AutoSize = true;
            this.txtLBL4.Location = new System.Drawing.Point(303, 38);
            this.txtLBL4.Name = "txtLBL4";
            this.txtLBL4.Size = new System.Drawing.Size(65, 16);
            this.txtLBL4.TabIndex = 9;
            this.txtLBL4.Text = "Accounts:";
            // 
            // replaceBTN
            // 
            this.replaceBTN.Location = new System.Drawing.Point(170, 156);
            this.replaceBTN.Name = "replaceBTN";
            this.replaceBTN.Size = new System.Drawing.Size(75, 38);
            this.replaceBTN.TabIndex = 4;
            this.replaceBTN.Text = "Replace";
            this.replaceBTN.UseVisualStyleBackColor = true;
            this.replaceBTN.Click += new System.EventHandler(this.replaceBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(47, 156);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(75, 38);
            this.addBTN.TabIndex = 3;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // txtLBL3
            // 
            this.txtLBL3.AutoSize = true;
            this.txtLBL3.Location = new System.Drawing.Point(58, 121);
            this.txtLBL3.Name = "txtLBL3";
            this.txtLBL3.Size = new System.Drawing.Size(60, 16);
            this.txtLBL3.TabIndex = 8;
            this.txtLBL3.Text = "Balance:";
            // 
            // txtLBL2
            // 
            this.txtLBL2.AutoSize = true;
            this.txtLBL2.Location = new System.Drawing.Point(20, 79);
            this.txtLBL2.Name = "txtLBL2";
            this.txtLBL2.Size = new System.Drawing.Size(98, 16);
            this.txtLBL2.TabIndex = 7;
            this.txtLBL2.Text = "Account Name:";
            // 
            // txtLBL1
            // 
            this.txtLBL1.AutoSize = true;
            this.txtLBL1.Location = new System.Drawing.Point(44, 39);
            this.txtLBL1.Name = "txtLBL1";
            this.txtLBL1.Size = new System.Drawing.Size(74, 16);
            this.txtLBL1.TabIndex = 6;
            this.txtLBL1.Text = "Account ID:";
            // 
            // classMethodToolStripMenuItem
            // 
            this.classMethodToolStripMenuItem.Name = "classMethodToolStripMenuItem";
            this.classMethodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.classMethodToolStripMenuItem.Text = "Class, Method";
            this.classMethodToolStripMenuItem.Click += new System.EventHandler(this.classMethodToolStripMenuItem_Click);
            // 
            // loadAddButtonToolStripMenuItem
            // 
            this.loadAddButtonToolStripMenuItem.Name = "loadAddButtonToolStripMenuItem";
            this.loadAddButtonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadAddButtonToolStripMenuItem.Text = "Load, Add Button";
            this.loadAddButtonToolStripMenuItem.Click += new System.EventHandler(this.loadAddButtonToolStripMenuItem_Click);
            // 
            // replaceButtonToolStripMenuItem
            // 
            this.replaceButtonToolStripMenuItem.Name = "replaceButtonToolStripMenuItem";
            this.replaceButtonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.replaceButtonToolStripMenuItem.Text = "Replace Button";
            this.replaceButtonToolStripMenuItem.Click += new System.EventHandler(this.replaceButtonToolStripMenuItem_Click);
            // 
            // B2CH3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 207);
            this.Controls.Add(this.balanceTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.outputLB);
            this.Controls.Add(this.txtLBL4);
            this.Controls.Add(this.replaceBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.txtLBL3);
            this.Controls.Add(this.txtLBL2);
            this.Controls.Add(this.txtLBL1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "B2CH3Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B2CH3Form";
            this.Load += new System.EventHandler(this.B2CH3Form_Load);
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
        private System.Windows.Forms.TextBox balanceTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.ListBox outputLB;
        private System.Windows.Forms.Label txtLBL4;
        private System.Windows.Forms.Button replaceBTN;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Label txtLBL3;
        private System.Windows.Forms.Label txtLBL2;
        private System.Windows.Forms.Label txtLBL1;
        private System.Windows.Forms.ToolStripMenuItem classMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAddButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceButtonToolStripMenuItem;
    }
}