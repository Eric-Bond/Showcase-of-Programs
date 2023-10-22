namespace Project_1
{
    partial class B1CH6Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B1CH6Form));
            this.tieLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.loseLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerScissorsPic = new System.Windows.Forms.PictureBox();
            this.playerPaperPic = new System.Windows.Forms.PictureBox();
            this.playerRockPic = new System.Windows.Forms.PictureBox();
            this.botScissorsPic = new System.Windows.Forms.PictureBox();
            this.botPaperPic = new System.Windows.Forms.PictureBox();
            this.botRockPic = new System.Windows.Forms.PictureBox();
            this.methodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methods2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPicClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picClicksPlayAgainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerScissorsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPaperPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRockPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botScissorsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botPaperPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botRockPic)).BeginInit();
            this.SuspendLayout();
            // 
            // tieLabel
            // 
            this.tieLabel.AutoSize = true;
            this.tieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieLabel.Location = new System.Drawing.Point(130, 273);
            this.tieLabel.Name = "tieLabel";
            this.tieLabel.Size = new System.Drawing.Size(68, 20);
            this.tieLabel.TabIndex = 5;
            this.tieLabel.Text = "It\'s a tie!";
            this.tieLabel.Visible = false;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.Location = new System.Drawing.Point(114, 269);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(104, 20);
            this.winLabel.TabIndex = 4;
            this.winLabel.Text = "Yay! You win!";
            this.winLabel.Visible = false;
            // 
            // loseLabel
            // 
            this.loseLabel.AutoSize = true;
            this.loseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseLabel.Location = new System.Drawing.Point(104, 277);
            this.loseLabel.Name = "loseLabel";
            this.loseLabel.Size = new System.Drawing.Size(126, 20);
            this.loseLabel.TabIndex = 3;
            this.loseLabel.Text = "Oh no! You lost..";
            this.loseLabel.Visible = false;
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(128, 315);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(75, 42);
            this.playAgainButton.TabIndex = 0;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(96, 47);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(134, 20);
            this.instructionLabel.TabIndex = 2;
            this.instructionLabel.Text = "Choose your pick!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(331, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.methodsToolStripMenuItem,
            this.methods2ToolStripMenuItem,
            this.loadPicClickToolStripMenuItem,
            this.picClicksPlayAgainToolStripMenuItem});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // playerScissorsPic
            // 
            this.playerScissorsPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playerScissorsPic.Image = ((System.Drawing.Image)(resources.GetObject("playerScissorsPic.Image")));
            this.playerScissorsPic.Location = new System.Drawing.Point(232, 92);
            this.playerScissorsPic.Name = "playerScissorsPic";
            this.playerScissorsPic.Size = new System.Drawing.Size(64, 64);
            this.playerScissorsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerScissorsPic.TabIndex = 17;
            this.playerScissorsPic.TabStop = false;
            this.playerScissorsPic.Click += new System.EventHandler(this.playerScissorsPic_Click);
            // 
            // playerPaperPic
            // 
            this.playerPaperPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playerPaperPic.Image = ((System.Drawing.Image)(resources.GetObject("playerPaperPic.Image")));
            this.playerPaperPic.Location = new System.Drawing.Point(134, 92);
            this.playerPaperPic.Name = "playerPaperPic";
            this.playerPaperPic.Size = new System.Drawing.Size(64, 64);
            this.playerPaperPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerPaperPic.TabIndex = 16;
            this.playerPaperPic.TabStop = false;
            this.playerPaperPic.Click += new System.EventHandler(this.playerPaperPic_Click);
            // 
            // playerRockPic
            // 
            this.playerRockPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playerRockPic.Image = ((System.Drawing.Image)(resources.GetObject("playerRockPic.Image")));
            this.playerRockPic.Location = new System.Drawing.Point(35, 92);
            this.playerRockPic.Name = "playerRockPic";
            this.playerRockPic.Size = new System.Drawing.Size(64, 64);
            this.playerRockPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerRockPic.TabIndex = 15;
            this.playerRockPic.TabStop = false;
            this.playerRockPic.Click += new System.EventHandler(this.playerRockPic_Click);
            // 
            // botScissorsPic
            // 
            this.botScissorsPic.Image = ((System.Drawing.Image)(resources.GetObject("botScissorsPic.Image")));
            this.botScissorsPic.Location = new System.Drawing.Point(232, 186);
            this.botScissorsPic.Name = "botScissorsPic";
            this.botScissorsPic.Size = new System.Drawing.Size(64, 64);
            this.botScissorsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.botScissorsPic.TabIndex = 14;
            this.botScissorsPic.TabStop = false;
            this.botScissorsPic.Visible = false;
            // 
            // botPaperPic
            // 
            this.botPaperPic.Image = ((System.Drawing.Image)(resources.GetObject("botPaperPic.Image")));
            this.botPaperPic.Location = new System.Drawing.Point(134, 186);
            this.botPaperPic.Name = "botPaperPic";
            this.botPaperPic.Size = new System.Drawing.Size(64, 64);
            this.botPaperPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.botPaperPic.TabIndex = 13;
            this.botPaperPic.TabStop = false;
            this.botPaperPic.Visible = false;
            // 
            // botRockPic
            // 
            this.botRockPic.Image = ((System.Drawing.Image)(resources.GetObject("botRockPic.Image")));
            this.botRockPic.Location = new System.Drawing.Point(35, 186);
            this.botRockPic.Name = "botRockPic";
            this.botRockPic.Size = new System.Drawing.Size(64, 64);
            this.botRockPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.botRockPic.TabIndex = 12;
            this.botRockPic.TabStop = false;
            this.botRockPic.Visible = false;
            // 
            // methodsToolStripMenuItem
            // 
            this.methodsToolStripMenuItem.Name = "methodsToolStripMenuItem";
            this.methodsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.methodsToolStripMenuItem.Text = "Methods";
            this.methodsToolStripMenuItem.Click += new System.EventHandler(this.methodsToolStripMenuItem_Click);
            // 
            // methods2ToolStripMenuItem
            // 
            this.methods2ToolStripMenuItem.Name = "methods2ToolStripMenuItem";
            this.methods2ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.methods2ToolStripMenuItem.Text = "Methods (2)";
            this.methods2ToolStripMenuItem.Click += new System.EventHandler(this.methods2ToolStripMenuItem_Click);
            // 
            // loadPicClickToolStripMenuItem
            // 
            this.loadPicClickToolStripMenuItem.Name = "loadPicClickToolStripMenuItem";
            this.loadPicClickToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.loadPicClickToolStripMenuItem.Text = "Load, Pic Click";
            this.loadPicClickToolStripMenuItem.Click += new System.EventHandler(this.loadPicClickToolStripMenuItem_Click);
            // 
            // picClicksPlayAgainToolStripMenuItem
            // 
            this.picClicksPlayAgainToolStripMenuItem.Name = "picClicksPlayAgainToolStripMenuItem";
            this.picClicksPlayAgainToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.picClicksPlayAgainToolStripMenuItem.Text = "Pic Clicks, Play Again";
            this.picClicksPlayAgainToolStripMenuItem.Click += new System.EventHandler(this.picClicksPlayAgainToolStripMenuItem_Click);
            // 
            // B1CH6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 379);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tieLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.loseLabel);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.playerScissorsPic);
            this.Controls.Add(this.playerPaperPic);
            this.Controls.Add(this.playerRockPic);
            this.Controls.Add(this.botScissorsPic);
            this.Controls.Add(this.botPaperPic);
            this.Controls.Add(this.botRockPic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "B1CH6Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.B1CH6Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerScissorsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPaperPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRockPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botScissorsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botPaperPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botRockPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tieLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label loseLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.PictureBox playerScissorsPic;
        private System.Windows.Forms.PictureBox playerPaperPic;
        private System.Windows.Forms.PictureBox playerRockPic;
        private System.Windows.Forms.PictureBox botScissorsPic;
        private System.Windows.Forms.PictureBox botPaperPic;
        private System.Windows.Forms.PictureBox botRockPic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methods2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPicClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem picClicksPlayAgainToolStripMenuItem;
    }
}