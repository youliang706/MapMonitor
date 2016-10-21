namespace MapMonitor
{
    partial class frmLoading
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
            this.lblInfo = new DevExpress.XtraEditors.LabelControl();
            this.pgbInfo = new DevExpress.XtraEditors.ProgressBarControl();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pgbInfo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(16, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(24, 17);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "提示";
            // 
            // pgbInfo
            // 
            this.pgbInfo.EditValue = 100;
            this.pgbInfo.Location = new System.Drawing.Point(16, 40);
            this.pgbInfo.Name = "pgbInfo";
            this.pgbInfo.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.pgbInfo.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pgbInfo.Size = new System.Drawing.Size(468, 20);
            this.pgbInfo.TabIndex = 4;
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(500, 67);
            this.ControlBox = false;
            this.Controls.Add(this.pgbInfo);
            this.Controls.Add(this.lblInfo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLoading";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pgbInfo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblInfo;
        private DevExpress.XtraEditors.ProgressBarControl pgbInfo;
        private System.Windows.Forms.Timer tmr;
    }
}
