namespace Project_1
{
    partial class PopupForm
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
            this.showBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLBL
            // 
            this.infoLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLBL.Location = new System.Drawing.Point(13, 9);
            this.infoLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLBL.Name = "infoLBL";
            this.infoLBL.Size = new System.Drawing.Size(335, 301);
            this.infoLBL.TabIndex = 0;
            this.infoLBL.Text = "label1";
            this.infoLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showBTN
            // 
            this.showBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBTN.Location = new System.Drawing.Point(117, 325);
            this.showBTN.Margin = new System.Windows.Forms.Padding(4);
            this.showBTN.Name = "showBTN";
            this.showBTN.Size = new System.Drawing.Size(127, 50);
            this.showBTN.TabIndex = 2;
            this.showBTN.Text = "Show me!";
            this.showBTN.UseVisualStyleBackColor = true;
            this.showBTN.Click += new System.EventHandler(this.showBTN_Click);
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 399);
            this.Controls.Add(this.showBTN);
            this.Controls.Add(this.infoLBL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopupForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PopupForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infoLBL;
        private System.Windows.Forms.Button showBTN;
    }
}