namespace MapMonitor
{
    partial class frmLineInfo
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
            this.pnlChart = new System.Windows.Forms.Panel();
            this.pnlCase = new System.Windows.Forms.Panel();
            this.picR = new System.Windows.Forms.PictureBox();
            this.picL = new System.Windows.Forms.PictureBox();
            this.pnlChart.SuspendLayout();
            this.pnlCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picL)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChart
            // 
            this.pnlChart.AutoScroll = true;
            this.pnlChart.Controls.Add(this.pnlCase);
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChart.Location = new System.Drawing.Point(0, 0);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(944, 205);
            this.pnlChart.TabIndex = 4;
            this.pnlChart.Visible = false;
            // 
            // pnlCase
            // 
            this.pnlCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCase.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlCase.Controls.Add(this.picR);
            this.pnlCase.Controls.Add(this.picL);
            this.pnlCase.Location = new System.Drawing.Point(0, 0);
            this.pnlCase.Name = "pnlCase";
            this.pnlCase.Size = new System.Drawing.Size(709, 205);
            this.pnlCase.TabIndex = 2;
            // 
            // picR
            // 
            this.picR.BackColor = System.Drawing.Color.Gainsboro;
            this.picR.Location = new System.Drawing.Point(655, 97);
            this.picR.Name = "picR";
            this.picR.Size = new System.Drawing.Size(32, 32);
            this.picR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picR.TabIndex = 1;
            this.picR.TabStop = false;
            // 
            // picL
            // 
            this.picL.BackColor = System.Drawing.Color.Gainsboro;
            this.picL.Location = new System.Drawing.Point(3, 97);
            this.picL.Name = "picL";
            this.picL.Size = new System.Drawing.Size(32, 32);
            this.picL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picL.TabIndex = 0;
            this.picL.TabStop = false;
            // 
            // frmLineInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 205);
            this.Controls.Add(this.pnlChart);
            this.Name = "frmLineInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "线路信息";
            this.Resize += new System.EventHandler(this.frmTrack_Resize);
            this.pnlChart.ResumeLayout(false);
            this.pnlCase.ResumeLayout(false);
            this.pnlCase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Panel pnlCase;
        private System.Windows.Forms.PictureBox picR;
        private System.Windows.Forms.PictureBox picL;

    }
}