namespace Project_1
{
    partial class B1CH2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B1CH2Form));
            this.showTailsButton = new System.Windows.Forms.Button();
            this.showHeadsButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tailsPicture = new System.Windows.Forms.PictureBox();
            this.headsPicture = new System.Windows.Forms.PictureBox();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // showTailsButton
            // 
            this.showTailsButton.Location = new System.Drawing.Point(213, 183);
            this.showTailsButton.Name = "showTailsButton";
            this.showTailsButton.Size = new System.Drawing.Size(93, 49);
            this.showTailsButton.TabIndex = 1;
            this.showTailsButton.Text = "Show Tails";
            this.showTailsButton.UseVisualStyleBackColor = true;
            this.showTailsButton.Click += new System.EventHandler(this.showTailsButton_Click);
            // 
            // showHeadsButton
            // 
            this.showHeadsButton.Location = new System.Drawing.Point(69, 183);
            this.showHeadsButton.Name = "showHeadsButton";
            this.showHeadsButton.Size = new System.Drawing.Size(93, 49);
            this.showHeadsButton.TabIndex = 0;
            this.showHeadsButton.Text = "Show Heads";
            this.showHeadsButton.UseVisualStyleBackColor = true;
            this.showHeadsButton.Click += new System.EventHandler(this.showHeadsButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(380, 24);
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
            // tailsPicture
            // 
            this.tailsPicture.Image = ((System.Drawing.Image)(resources.GetObject("tailsPicture.Image")));
            this.tailsPicture.Location = new System.Drawing.Point(204, 42);
            this.tailsPicture.Name = "tailsPicture";
            this.tailsPicture.Size = new System.Drawing.Size(117, 121);
            this.tailsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPicture.TabIndex = 7;
            this.tailsPicture.TabStop = false;
            this.tailsPicture.Visible = false;
            // 
            // headsPicture
            // 
            this.headsPicture.Image = ((System.Drawing.Image)(resources.GetObject("headsPicture.Image")));
            this.headsPicture.Location = new System.Drawing.Point(60, 42);
            this.headsPicture.Name = "headsPicture";
            this.headsPicture.Size = new System.Drawing.Size(117, 121);
            this.headsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPicture.TabIndex = 6;
            this.headsPicture.TabStop = false;
            this.headsPicture.Visible = false;
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // B1CH2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 258);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tailsPicture);
            this.Controls.Add(this.headsPicture);
            this.Controls.Add(this.showTailsButton);
            this.Controls.Add(this.showHeadsButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "B1CH2Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heads or Tails";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tailsPicture;
        private System.Windows.Forms.PictureBox headsPicture;
        private System.Windows.Forms.Button showTailsButton;
        private System.Windows.Forms.Button showHeadsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
    }
}