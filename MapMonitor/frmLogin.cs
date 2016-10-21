using Com.Register;
using Com.SubClass;
using System;
using System.Windows.Forms;

namespace MapMonitor
{
    //定义委托
    public delegate void ChkLoginEvevt(string sUser, string sPwd, ref bool bln);

    public partial class frmLogin : Form
    {
        //注册表操作
        private CReg reg = Program.reg;

        //定义委托事件 
        public event ChkLoginEvevt ChkLogin;

        private bool blnRet;
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool ShowMe()
        {
            txtLoginID.Text = reg.GetSettings(Application.ProductName, "system", "loginid");
            txtPwd.Text = reg.GetSettings(Application.ProductName, "system", "loginpwd");

            if (txtPwd.Text != "")
            { chkSavPwd.Checked = true; }

            this.ShowDialog();

            return blnRet;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool bln = false;

            ChkLogin(txtLoginID.Text, txtPwd.Text, ref bln);

            if (bln == true)
            {
                reg.SaveSettings(Application.ProductName, "system", "loginid", txtLoginID.Text);
                if (chkSavPwd.Checked)
                { reg.SaveSettings(Application.ProductName, "system", "loginpwd", txtPwd.Text); }
                else
                { reg.SaveSettings(Application.ProductName, "system", "loginpwd", ""); }

                blnRet = true;
                this.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            CSubClass.SetXtraTxtMask(this);
        }
    }
}
