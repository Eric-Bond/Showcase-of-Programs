namespace Project_1
{
    partial class B2CH6Form
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
            this.summaryBTN = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblEventDetected = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.variablesMethodsLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTickButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weatherStationClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(310, 24);
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
            this.variablesMethodsLoadToolStripMenuItem,
            this.timerTickButtonsToolStripMenuItem,
            this.weatherStationClassToolStripMenuItem});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // summaryBTN
            // 
            this.summaryBTN.Location = new System.Drawing.Point(166, 99);
            this.summaryBTN.Name = "summaryBTN";
            this.summaryBTN.Size = new System.Drawing.Size(115, 30);
            this.summaryBTN.TabIndex = 1;
            this.summaryBTN.Text = "Show Summary";
            this.summaryBTN.UseVisualStyleBackColor = true;
            this.summaryBTN.Click += new System.EventHandler(this.summaryBTN_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(208, 16);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "The following event was detected:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(29, 99);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start monitoring";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblEventDetected
            // 
            this.lblEventDetected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventDetected.Location = new System.Drawing.Point(18, 61);
            this.lblEventDetected.Name = "lblEventDetected";
            this.lblEventDetected.Size = new System.Drawing.Size(278, 22);
            this.lblEventDetected.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // variablesMethodsLoadToolStripMenuItem
            // 
            this.variablesMethodsLoadToolStripMenuItem.Name = "variablesMethodsLoadToolStripMenuItem";
            this.variablesMethodsLoadToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.variablesMethodsLoadToolStripMenuItem.Text = "Variables, Methods, Load";
            this.variablesMethodsLoadToolStripMenuItem.Click += new System.EventHandler(this.variablesMethodsLoadToolStripMenuItem_Click);
            // 
            // timerTickButtonsToolStripMenuItem
            // 
            this.timerTickButtonsToolStripMenuItem.Name = "timerTickButtonsToolStripMenuItem";
            this.timerTickButtonsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.timerTickButtonsToolStripMenuItem.Text = "Timer Tick, Buttons";
            this.timerTickButtonsToolStripMenuItem.Click += new System.EventHandler(this.timerTickButtonsToolStripMenuItem_Click);
            // 
            // weatherStationClassToolStripMenuItem
            // 
            this.weatherStationClassToolStripMenuItem.Name = "weatherStationClassToolStripMenuItem";
            this.weatherStationClassToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.weatherStationClassToolStripMenuItem.Text = "WeatherStation Class";
            this.weatherStationClassToolStripMenuItem.Click += new System.EventHandler(this.weatherStationClassToolStripMenuItem_Click);
            // 
            // B2CH6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 142);
            this.Controls.Add(this.summaryBTN);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblEventDetected);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "B2CH6Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Station Events";
            this.Load += new System.EventHandler(this.B2CH6Form_Load);
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
        internal System.Windows.Forms.Button summaryBTN;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.Label lblEventDetected;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem variablesMethodsLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerTickButtonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weatherStationClassToolStripMenuItem;
    }
}