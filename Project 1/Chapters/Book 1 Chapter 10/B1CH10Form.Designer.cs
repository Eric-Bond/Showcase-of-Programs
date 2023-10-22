namespace Project_1
{
    partial class B1CH10Form
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
            this.createObjectButton = new System.Windows.Forms.Button();
            this.objectPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.outputAgeLabel = new System.Windows.Forms.Label();
            this.outputTypeLabel = new System.Windows.Forms.Label();
            this.outputNameLabel = new System.Windows.Forms.Label();
            this.enterDataGroupBox = new System.Windows.Forms.GroupBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.promptAgeLabel = new System.Windows.Forms.Label();
            this.promptTypeLabel = new System.Windows.Forms.Label();
            this.promptNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectPropertiesGroupBox.SuspendLayout();
            this.enterDataGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createObjectButton
            // 
            this.createObjectButton.Location = new System.Drawing.Point(90, 281);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(75, 41);
            this.createObjectButton.TabIndex = 2;
            this.createObjectButton.Text = "Create Object";
            this.createObjectButton.UseVisualStyleBackColor = true;
            this.createObjectButton.Click += new System.EventHandler(this.createObjectButton_Click);
            // 
            // objectPropertiesGroupBox
            // 
            this.objectPropertiesGroupBox.Controls.Add(this.ageLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.typeLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.nameLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputAgeLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputTypeLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputNameLabel);
            this.objectPropertiesGroupBox.Location = new System.Drawing.Point(34, 145);
            this.objectPropertiesGroupBox.Name = "objectPropertiesGroupBox";
            this.objectPropertiesGroupBox.Size = new System.Drawing.Size(186, 124);
            this.objectPropertiesGroupBox.TabIndex = 1;
            this.objectPropertiesGroupBox.TabStop = false;
            this.objectPropertiesGroupBox.Text = "Object Properties";
            // 
            // ageLabel
            // 
            this.ageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageLabel.Location = new System.Drawing.Point(59, 85);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(100, 23);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeLabel
            // 
            this.typeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeLabel.Location = new System.Drawing.Point(59, 55);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(100, 23);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Location = new System.Drawing.Point(59, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputAgeLabel
            // 
            this.outputAgeLabel.AutoSize = true;
            this.outputAgeLabel.Location = new System.Drawing.Point(19, 88);
            this.outputAgeLabel.Name = "outputAgeLabel";
            this.outputAgeLabel.Size = new System.Drawing.Size(35, 16);
            this.outputAgeLabel.TabIndex = 5;
            this.outputAgeLabel.Text = "Age:";
            // 
            // outputTypeLabel
            // 
            this.outputTypeLabel.AutoSize = true;
            this.outputTypeLabel.Location = new System.Drawing.Point(14, 57);
            this.outputTypeLabel.Name = "outputTypeLabel";
            this.outputTypeLabel.Size = new System.Drawing.Size(42, 16);
            this.outputTypeLabel.TabIndex = 4;
            this.outputTypeLabel.Text = "Type:";
            // 
            // outputNameLabel
            // 
            this.outputNameLabel.AutoSize = true;
            this.outputNameLabel.Location = new System.Drawing.Point(10, 28);
            this.outputNameLabel.Name = "outputNameLabel";
            this.outputNameLabel.Size = new System.Drawing.Size(47, 16);
            this.outputNameLabel.TabIndex = 3;
            this.outputNameLabel.Text = "Name:";
            // 
            // enterDataGroupBox
            // 
            this.enterDataGroupBox.Controls.Add(this.ageTextBox);
            this.enterDataGroupBox.Controls.Add(this.typeTextBox);
            this.enterDataGroupBox.Controls.Add(this.nameTextBox);
            this.enterDataGroupBox.Controls.Add(this.promptAgeLabel);
            this.enterDataGroupBox.Controls.Add(this.promptTypeLabel);
            this.enterDataGroupBox.Controls.Add(this.promptNameLabel);
            this.enterDataGroupBox.Location = new System.Drawing.Point(34, 39);
            this.enterDataGroupBox.Name = "enterDataGroupBox";
            this.enterDataGroupBox.Size = new System.Drawing.Size(186, 100);
            this.enterDataGroupBox.TabIndex = 0;
            this.enterDataGroupBox.TabStop = false;
            this.enterDataGroupBox.Text = "Enter Pet Data";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(62, 74);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 22);
            this.ageTextBox.TabIndex = 2;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(62, 48);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 22);
            this.typeTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(62, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // promptAgeLabel
            // 
            this.promptAgeLabel.AutoSize = true;
            this.promptAgeLabel.Location = new System.Drawing.Point(22, 77);
            this.promptAgeLabel.Name = "promptAgeLabel";
            this.promptAgeLabel.Size = new System.Drawing.Size(35, 16);
            this.promptAgeLabel.TabIndex = 5;
            this.promptAgeLabel.Text = "Age:";
            // 
            // promptTypeLabel
            // 
            this.promptTypeLabel.AutoSize = true;
            this.promptTypeLabel.Location = new System.Drawing.Point(17, 51);
            this.promptTypeLabel.Name = "promptTypeLabel";
            this.promptTypeLabel.Size = new System.Drawing.Size(42, 16);
            this.promptTypeLabel.TabIndex = 4;
            this.promptTypeLabel.Text = "Type:";
            // 
            // promptNameLabel
            // 
            this.promptNameLabel.AutoSize = true;
            this.promptNameLabel.Location = new System.Drawing.Point(13, 25);
            this.promptNameLabel.Name = "promptNameLabel";
            this.promptNameLabel.Size = new System.Drawing.Size(47, 16);
            this.promptNameLabel.TabIndex = 3;
            this.promptNameLabel.Text = "Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(254, 24);
            this.menuStrip1.TabIndex = 3;
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
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // B1CH10Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 336);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.objectPropertiesGroupBox);
            this.Controls.Add(this.enterDataGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "B1CH10Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Class";
            this.objectPropertiesGroupBox.ResumeLayout(false);
            this.objectPropertiesGroupBox.PerformLayout();
            this.enterDataGroupBox.ResumeLayout(false);
            this.enterDataGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createObjectButton;
        private System.Windows.Forms.GroupBox objectPropertiesGroupBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label outputAgeLabel;
        private System.Windows.Forms.Label outputTypeLabel;
        private System.Windows.Forms.Label outputNameLabel;
        private System.Windows.Forms.GroupBox enterDataGroupBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label promptAgeLabel;
        private System.Windows.Forms.Label promptTypeLabel;
        private System.Windows.Forms.Label promptNameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
    }
}