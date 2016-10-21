namespace MapMonitor
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.chkSavPwd = new DevExpress.XtraEditors.CheckEdit();
            this.txtPwd = new DevExpress.XtraEditors.TextEdit();
            this.txtLoginID = new DevExpress.XtraEditors.TextEdit();
            this.lblLoginID = new DevExpress.XtraEditors.LabelControl();
            this.lblPwd = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chkSavPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLogin.Location = new System.Drawing.Point(186, 117);
            this.btnLogin.LookAndFeel.SkinName = "Office 2013";
            this.btnLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 26);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "  登录";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkSavPwd
            // 
            this.chkSavPwd.Location = new System.Drawing.Point(31, 122);
            this.chkSavPwd.Name = "chkSavPwd";
            this.chkSavPwd.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSavPwd.Properties.Appearance.Options.UseFont = true;
            this.chkSavPwd.Properties.Caption = "记住密码";
            this.chkSavPwd.Properties.LookAndFeel.SkinName = "Office 2013";
            this.chkSavPwd.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chkSavPwd.Size = new System.Drawing.Size(83, 21);
            this.chkSavPwd.TabIndex = 4;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(85, 72);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Properties.Appearance.Options.UseFont = true;
            this.txtPwd.Properties.LookAndFeel.SkinName = "Office 2013";
            this.txtPwd.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtPwd.Properties.PasswordChar = '●';
            this.txtPwd.Size = new System.Drawing.Size(192, 24);
            this.txtPwd.TabIndex = 3;
            // 
            // txtLoginID
            // 
            this.txtLoginID.Location = new System.Drawing.Point(85, 26);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginID.Properties.Appearance.Options.UseFont = true;
            this.txtLoginID.Properties.LookAndFeel.SkinName = "Office 2013";
            this.txtLoginID.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtLoginID.Size = new System.Drawing.Size(192, 24);
            this.txtLoginID.TabIndex = 1;
            // 
            // lblLoginID
            // 
            this.lblLoginID.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginID.Location = new System.Drawing.Point(31, 29);
            this.lblLoginID.Name = "lblLoginID";
            this.lblLoginID.Size = new System.Drawing.Size(48, 17);
            this.lblLoginID.TabIndex = 0;
            this.lblLoginID.Text = "登录名：";
            // 
            // lblPwd
            // 
            this.lblPwd.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.Location = new System.Drawing.Point(31, 75);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(36, 17);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "密码：";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 161);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblLoginID);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.chkSavPwd);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkSavPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.CheckEdit chkSavPwd;
        private DevExpress.XtraEditors.TextEdit txtPwd;
        private DevExpress.XtraEditors.TextEdit txtLoginID;
        private DevExpress.XtraEditors.LabelControl lblLoginID;
        private DevExpress.XtraEditors.LabelControl lblPwd;
    }
}