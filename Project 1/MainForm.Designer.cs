namespace Project_1
{
    partial class MainForm
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
            this.mainFormMS = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableOfContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initializeViewButtonMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookComboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chapterComboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chapterComboBox2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tOCCodeButtonExitButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.universalCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameCapitalizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxDrawItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCursorEventsOnControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookCB = new System.Windows.Forms.ComboBox();
            this.chapterCB = new System.Windows.Forms.ComboBox();
            this.detailsLBL = new System.Windows.Forms.Label();
            this.viewBTN = new System.Windows.Forms.Button();
            this.instructionLBL = new System.Windows.Forms.Label();
            this.bookLBL = new System.Windows.Forms.Label();
            this.chapterLBL = new System.Windows.Forms.Label();
            this.mainFormMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormMS
            // 
            this.mainFormMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mainFormMS.Location = new System.Drawing.Point(0, 0);
            this.mainFormMS.Name = "mainFormMS";
            this.mainFormMS.Size = new System.Drawing.Size(503, 24);
            this.mainFormMS.TabIndex = 3;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableOfContentsToolStripMenuItem,
            this.codeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // tableOfContentsToolStripMenuItem
            // 
            this.tableOfContentsToolStripMenuItem.Name = "tableOfContentsToolStripMenuItem";
            this.tableOfContentsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.tableOfContentsToolStripMenuItem.Text = "Table of contents";
            this.tableOfContentsToolStripMenuItem.Click += new System.EventHandler(this.tableOfContentsToolStripMenuItem_Click);
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeViewButtonMethodToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.bookComboBoxToolStripMenuItem,
            this.chapterComboBoxToolStripMenuItem,
            this.chapterComboBox2ToolStripMenuItem,
            this.viewButtonToolStripMenuItem,
            this.tOCCodeButtonExitButtonToolStripMenuItem,
            this.universalCodeToolStripMenuItem});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // initializeViewButtonMethodToolStripMenuItem
            // 
            this.initializeViewButtonMethodToolStripMenuItem.Name = "initializeViewButtonMethodToolStripMenuItem";
            this.initializeViewButtonMethodToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.initializeViewButtonMethodToolStripMenuItem.Text = "Initialize, View Button Method";
            this.initializeViewButtonMethodToolStripMenuItem.Click += new System.EventHandler(this.initializeViewButtonMethodToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // bookComboBoxToolStripMenuItem
            // 
            this.bookComboBoxToolStripMenuItem.Name = "bookComboBoxToolStripMenuItem";
            this.bookComboBoxToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.bookComboBoxToolStripMenuItem.Text = "Book ComboBox";
            this.bookComboBoxToolStripMenuItem.Click += new System.EventHandler(this.bookComboBoxToolStripMenuItem_Click);
            // 
            // chapterComboBoxToolStripMenuItem
            // 
            this.chapterComboBoxToolStripMenuItem.Name = "chapterComboBoxToolStripMenuItem";
            this.chapterComboBoxToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.chapterComboBoxToolStripMenuItem.Text = "Chapter ComboBox";
            this.chapterComboBoxToolStripMenuItem.Click += new System.EventHandler(this.chapterComboBoxToolStripMenuItem_Click);
            // 
            // chapterComboBox2ToolStripMenuItem
            // 
            this.chapterComboBox2ToolStripMenuItem.Name = "chapterComboBox2ToolStripMenuItem";
            this.chapterComboBox2ToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.chapterComboBox2ToolStripMenuItem.Text = "Chapter ComboBox (2)";
            this.chapterComboBox2ToolStripMenuItem.Click += new System.EventHandler(this.chapterComboBox2ToolStripMenuItem_Click);
            // 
            // viewButtonToolStripMenuItem
            // 
            this.viewButtonToolStripMenuItem.Name = "viewButtonToolStripMenuItem";
            this.viewButtonToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.viewButtonToolStripMenuItem.Text = "View Button";
            this.viewButtonToolStripMenuItem.Click += new System.EventHandler(this.viewButtonToolStripMenuItem_Click);
            // 
            // tOCCodeButtonExitButtonToolStripMenuItem
            // 
            this.tOCCodeButtonExitButtonToolStripMenuItem.Name = "tOCCodeButtonExitButtonToolStripMenuItem";
            this.tOCCodeButtonExitButtonToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.tOCCodeButtonExitButtonToolStripMenuItem.Text = "TOC, Code Button, Exit Button";
            this.tOCCodeButtonExitButtonToolStripMenuItem.Click += new System.EventHandler(this.tOCCodeButtonExitButtonToolStripMenuItem_Click);
            // 
            // universalCodeToolStripMenuItem
            // 
            this.universalCodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pictureFormToolStripMenuItem,
            this.nameCapitalizerToolStripMenuItem,
            this.comboBoxDrawItemToolStripMenuItem,
            this.setCursorEventsOnControlsToolStripMenuItem});
            this.universalCodeToolStripMenuItem.Name = "universalCodeToolStripMenuItem";
            this.universalCodeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.universalCodeToolStripMenuItem.Text = "Universal Code";
            // 
            // pictureFormToolStripMenuItem
            // 
            this.pictureFormToolStripMenuItem.Name = "pictureFormToolStripMenuItem";
            this.pictureFormToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.pictureFormToolStripMenuItem.Text = "Picture Form";
            this.pictureFormToolStripMenuItem.Click += new System.EventHandler(this.pictureFormToolStripMenuItem_Click);
            // 
            // nameCapitalizerToolStripMenuItem
            // 
            this.nameCapitalizerToolStripMenuItem.Name = "nameCapitalizerToolStripMenuItem";
            this.nameCapitalizerToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.nameCapitalizerToolStripMenuItem.Text = "Name Capitalizer";
            this.nameCapitalizerToolStripMenuItem.Click += new System.EventHandler(this.nameCapitalizerToolStripMenuItem_Click);
            // 
            // comboBoxDrawItemToolStripMenuItem
            // 
            this.comboBoxDrawItemToolStripMenuItem.Name = "comboBoxDrawItemToolStripMenuItem";
            this.comboBoxDrawItemToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.comboBoxDrawItemToolStripMenuItem.Text = "ComboBox_DrawItem";
            this.comboBoxDrawItemToolStripMenuItem.Click += new System.EventHandler(this.comboBoxDrawItemToolStripMenuItem_Click);
            // 
            // setCursorEventsOnControlsToolStripMenuItem
            // 
            this.setCursorEventsOnControlsToolStripMenuItem.Name = "setCursorEventsOnControlsToolStripMenuItem";
            this.setCursorEventsOnControlsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.setCursorEventsOnControlsToolStripMenuItem.Text = "SetCursorEventsOnControls";
            this.setCursorEventsOnControlsToolStripMenuItem.Click += new System.EventHandler(this.setCursorEventsOnControlsToolStripMenuItem_Click);
            // 
            // bookCB
            // 
            this.bookCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookCB.FormattingEnabled = true;
            this.bookCB.Location = new System.Drawing.Point(147, 120);
            this.bookCB.Name = "bookCB";
            this.bookCB.Size = new System.Drawing.Size(208, 24);
            this.bookCB.TabIndex = 0;
            this.bookCB.SelectedIndexChanged += new System.EventHandler(this.bookCB_SelectedIndexChanged);
            // 
            // chapterCB
            // 
            this.chapterCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chapterCB.FormattingEnabled = true;
            this.chapterCB.Location = new System.Drawing.Point(87, 186);
            this.chapterCB.Name = "chapterCB";
            this.chapterCB.Size = new System.Drawing.Size(328, 24);
            this.chapterCB.TabIndex = 1;
            this.chapterCB.SelectedIndexChanged += new System.EventHandler(this.chapterCB_SelectedIndexChanged);
            // 
            // detailsLBL
            // 
            this.detailsLBL.Location = new System.Drawing.Point(43, 234);
            this.detailsLBL.Name = "detailsLBL";
            this.detailsLBL.Size = new System.Drawing.Size(416, 114);
            this.detailsLBL.TabIndex = 7;
            this.detailsLBL.Text = "*Details Label*";
            this.detailsLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // viewBTN
            // 
            this.viewBTN.Enabled = false;
            this.viewBTN.Location = new System.Drawing.Point(209, 367);
            this.viewBTN.Name = "viewBTN";
            this.viewBTN.Size = new System.Drawing.Size(83, 34);
            this.viewBTN.TabIndex = 2;
            this.viewBTN.Text = "View";
            this.viewBTN.UseVisualStyleBackColor = true;
            this.viewBTN.Click += new System.EventHandler(this.viewBTN_Click);
            // 
            // instructionLBL
            // 
            this.instructionLBL.Location = new System.Drawing.Point(86, 40);
            this.instructionLBL.Name = "instructionLBL";
            this.instructionLBL.Size = new System.Drawing.Size(331, 33);
            this.instructionLBL.TabIndex = 4;
            this.instructionLBL.Text = "Select a book from the top ComboBox, and then select a chapter from the bottom Co" +
    "mboBox to get started!";
            this.instructionLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookLBL
            // 
            this.bookLBL.AutoSize = true;
            this.bookLBL.Location = new System.Drawing.Point(232, 99);
            this.bookLBL.Name = "bookLBL";
            this.bookLBL.Size = new System.Drawing.Size(39, 16);
            this.bookLBL.TabIndex = 5;
            this.bookLBL.Text = "Book";
            // 
            // chapterLBL
            // 
            this.chapterLBL.AutoSize = true;
            this.chapterLBL.Location = new System.Drawing.Point(224, 165);
            this.chapterLBL.Name = "chapterLBL";
            this.chapterLBL.Size = new System.Drawing.Size(54, 16);
            this.chapterLBL.TabIndex = 6;
            this.chapterLBL.Text = "Chapter";
            // 
            // MainForm
            // 
            this.AcceptButton = this.viewBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 430);
            this.Controls.Add(this.chapterLBL);
            this.Controls.Add(this.bookLBL);
            this.Controls.Add(this.instructionLBL);
            this.Controls.Add(this.viewBTN);
            this.Controls.Add(this.detailsLBL);
            this.Controls.Add(this.chapterCB);
            this.Controls.Add(this.bookCB);
            this.Controls.Add(this.mainFormMS);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainFormMS;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Showcase of Programs";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainFormMS.ResumeLayout(false);
            this.mainFormMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainFormMS;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ComboBox bookCB;
        private System.Windows.Forms.ComboBox chapterCB;
        private System.Windows.Forms.Label detailsLBL;
        private System.Windows.Forms.Button viewBTN;
        private System.Windows.Forms.Label instructionLBL;
        private System.Windows.Forms.Label bookLBL;
        private System.Windows.Forms.Label chapterLBL;
        private System.Windows.Forms.ToolStripMenuItem tableOfContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initializeViewButtonMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookComboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chapterComboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chapterComboBox2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tOCCodeButtonExitButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universalCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameCapitalizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxDrawItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCursorEventsOnControlsToolStripMenuItem;
    }
}

