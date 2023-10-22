namespace Project_1
{
    partial class B2CH1Form
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floorNumberLBL = new System.Windows.Forms.Label();
            this.floorTxtLBL = new System.Windows.Forms.Label();
            this.elevatorPNL = new System.Windows.Forms.Panel();
            this.elevatorCapacityLBL = new System.Windows.Forms.Label();
            this.floor8 = new System.Windows.Forms.Label();
            this.floor7 = new System.Windows.Forms.Label();
            this.floor6 = new System.Windows.Forms.Label();
            this.floor5 = new System.Windows.Forms.Label();
            this.floor4 = new System.Windows.Forms.Label();
            this.floor3 = new System.Windows.Forms.Label();
            this.floor2 = new System.Windows.Forms.Label();
            this.floor1 = new System.Windows.Forms.Label();
            this.elevatorTimer = new System.Windows.Forms.Timer(this.components);
            this.classVariablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methods2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTickTimerMethodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.elevatorPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.classVariablesToolStripMenuItem,
            this.methodsToolStripMenuItem,
            this.methods2ToolStripMenuItem,
            this.timerTickTimerMethodsToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // floorNumberLBL
            // 
            this.floorNumberLBL.AutoSize = true;
            this.floorNumberLBL.Location = new System.Drawing.Point(270, 59);
            this.floorNumberLBL.Name = "floorNumberLBL";
            this.floorNumberLBL.Size = new System.Drawing.Size(14, 16);
            this.floorNumberLBL.TabIndex = 11;
            this.floorNumberLBL.Text = "1";
            // 
            // floorTxtLBL
            // 
            this.floorTxtLBL.AutoSize = true;
            this.floorTxtLBL.Location = new System.Drawing.Point(230, 59);
            this.floorTxtLBL.Name = "floorTxtLBL";
            this.floorTxtLBL.Size = new System.Drawing.Size(41, 16);
            this.floorTxtLBL.TabIndex = 10;
            this.floorTxtLBL.Text = "Floor:";
            // 
            // elevatorPNL
            // 
            this.elevatorPNL.BackColor = System.Drawing.Color.Silver;
            this.elevatorPNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elevatorPNL.Controls.Add(this.elevatorCapacityLBL);
            this.elevatorPNL.Location = new System.Drawing.Point(60, 285);
            this.elevatorPNL.Name = "elevatorPNL";
            this.elevatorPNL.Size = new System.Drawing.Size(73, 33);
            this.elevatorPNL.TabIndex = 9;
            // 
            // elevatorCapacityLBL
            // 
            this.elevatorCapacityLBL.AutoSize = true;
            this.elevatorCapacityLBL.Location = new System.Drawing.Point(29, 9);
            this.elevatorCapacityLBL.Name = "elevatorCapacityLBL";
            this.elevatorCapacityLBL.Size = new System.Drawing.Size(14, 16);
            this.elevatorCapacityLBL.TabIndex = 0;
            this.elevatorCapacityLBL.Text = "0";
            // 
            // floor8
            // 
            this.floor8.AutoSize = true;
            this.floor8.Location = new System.Drawing.Point(150, 43);
            this.floor8.Name = "floor8";
            this.floor8.Size = new System.Drawing.Size(44, 16);
            this.floor8.TabIndex = 1;
            this.floor8.Text = "label8";
            // 
            // floor7
            // 
            this.floor7.AutoSize = true;
            this.floor7.Location = new System.Drawing.Point(150, 79);
            this.floor7.Name = "floor7";
            this.floor7.Size = new System.Drawing.Size(44, 16);
            this.floor7.TabIndex = 2;
            this.floor7.Text = "label7";
            // 
            // floor6
            // 
            this.floor6.AutoSize = true;
            this.floor6.Location = new System.Drawing.Point(150, 115);
            this.floor6.Name = "floor6";
            this.floor6.Size = new System.Drawing.Size(44, 16);
            this.floor6.TabIndex = 3;
            this.floor6.Text = "label6";
            // 
            // floor5
            // 
            this.floor5.AutoSize = true;
            this.floor5.Location = new System.Drawing.Point(150, 151);
            this.floor5.Name = "floor5";
            this.floor5.Size = new System.Drawing.Size(44, 16);
            this.floor5.TabIndex = 4;
            this.floor5.Text = "label5";
            // 
            // floor4
            // 
            this.floor4.AutoSize = true;
            this.floor4.Location = new System.Drawing.Point(150, 187);
            this.floor4.Name = "floor4";
            this.floor4.Size = new System.Drawing.Size(44, 16);
            this.floor4.TabIndex = 5;
            this.floor4.Text = "label4";
            // 
            // floor3
            // 
            this.floor3.AutoSize = true;
            this.floor3.Location = new System.Drawing.Point(150, 223);
            this.floor3.Name = "floor3";
            this.floor3.Size = new System.Drawing.Size(44, 16);
            this.floor3.TabIndex = 6;
            this.floor3.Text = "label3";
            // 
            // floor2
            // 
            this.floor2.AutoSize = true;
            this.floor2.Location = new System.Drawing.Point(150, 259);
            this.floor2.Name = "floor2";
            this.floor2.Size = new System.Drawing.Size(44, 16);
            this.floor2.TabIndex = 7;
            this.floor2.Text = "label2";
            // 
            // floor1
            // 
            this.floor1.AutoSize = true;
            this.floor1.Location = new System.Drawing.Point(150, 295);
            this.floor1.Name = "floor1";
            this.floor1.Size = new System.Drawing.Size(44, 16);
            this.floor1.TabIndex = 8;
            this.floor1.Text = "label1";
            // 
            // elevatorTimer
            // 
            this.elevatorTimer.Enabled = true;
            this.elevatorTimer.Interval = 2000;
            this.elevatorTimer.Tick += new System.EventHandler(this.elevatorTimer_Tick);
            // 
            // classVariablesToolStripMenuItem
            // 
            this.classVariablesToolStripMenuItem.Name = "classVariablesToolStripMenuItem";
            this.classVariablesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.classVariablesToolStripMenuItem.Text = "Class, Variables";
            this.classVariablesToolStripMenuItem.Click += new System.EventHandler(this.classVariablesToolStripMenuItem_Click);
            // 
            // methodsToolStripMenuItem
            // 
            this.methodsToolStripMenuItem.Name = "methodsToolStripMenuItem";
            this.methodsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.methodsToolStripMenuItem.Text = "Methods";
            this.methodsToolStripMenuItem.Click += new System.EventHandler(this.methodsToolStripMenuItem_Click);
            // 
            // methods2ToolStripMenuItem
            // 
            this.methods2ToolStripMenuItem.Name = "methods2ToolStripMenuItem";
            this.methods2ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.methods2ToolStripMenuItem.Text = "Methods (2)";
            this.methods2ToolStripMenuItem.Click += new System.EventHandler(this.methods2ToolStripMenuItem_Click);
            // 
            // timerTickTimerMethodsToolStripMenuItem
            // 
            this.timerTickTimerMethodsToolStripMenuItem.Name = "timerTickTimerMethodsToolStripMenuItem";
            this.timerTickTimerMethodsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.timerTickTimerMethodsToolStripMenuItem.Text = "Timer Tick, Timer Methods";
            this.timerTickTimerMethodsToolStripMenuItem.Click += new System.EventHandler(this.timerTickTimerMethodsToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // B2CH1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 341);
            this.Controls.Add(this.floorNumberLBL);
            this.Controls.Add(this.floorTxtLBL);
            this.Controls.Add(this.elevatorPNL);
            this.Controls.Add(this.floor8);
            this.Controls.Add(this.floor7);
            this.Controls.Add(this.floor6);
            this.Controls.Add(this.floor5);
            this.Controls.Add(this.floor4);
            this.Controls.Add(this.floor3);
            this.Controls.Add(this.floor2);
            this.Controls.Add(this.floor1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "B2CH1Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator Simulation";
            this.Load += new System.EventHandler(this.B2CH1Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.elevatorPNL.ResumeLayout(false);
            this.elevatorPNL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.Label floorNumberLBL;
        private System.Windows.Forms.Label floorTxtLBL;
        private System.Windows.Forms.Panel elevatorPNL;
        private System.Windows.Forms.Label elevatorCapacityLBL;
        private System.Windows.Forms.Label floor8;
        private System.Windows.Forms.Label floor7;
        private System.Windows.Forms.Label floor6;
        private System.Windows.Forms.Label floor5;
        private System.Windows.Forms.Label floor4;
        private System.Windows.Forms.Label floor3;
        private System.Windows.Forms.Label floor2;
        private System.Windows.Forms.Label floor1;
        private System.Windows.Forms.Timer elevatorTimer;
        private System.Windows.Forms.ToolStripMenuItem classVariablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methods2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerTickTimerMethodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}