using Com.Database;
using Com.Register;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MapMonitor
{
    //公开事件
    public delegate void MsgEventHandler(List<string> phoneNumbers, string content);

    static class Program
    {
        //全局数据库处理对象
        public static CDatabase db = new CDatabase();

        //注册表处理
        public static CReg reg = new CReg();

        //当前登录用户
        public static string usercode = null;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //处理UI线程异常
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            //处理非UI线程异常
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            //判断只能运行一个实例 
            bool createNew;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, Application.ProductName, out createNew);

            //建立数据库连接
            string sConn = ConfigurationManager.ConnectionStrings["dbconfig"].ConnectionString;
            db.CreateConn(sConn);

            bool bln = false;

            if (args.Length != 0)
            {
                bln = ChkPass(args[0], args[1]);
            }
            else
            {
                //注册登录窗体的事件     
                frmLogin LoginForm = new frmLogin();
                LoginForm.ChkLogin += new ChkLoginEvevt(ChkLogin);

                bln = LoginForm.ShowMe();
            }

            if (bln)
            {
                frmLoading LoadingForm = new frmLoading();
                if (LoadingForm.ShowMe(usercode))
                {
                    Application.Run(new frmMonitor());
                }
            }
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string str = GetExceptionMsg(e.ExceptionObject as Exception, e.ToString());
            MessageBox.Show(str, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string str = GetExceptionMsg(e.Exception, e.ToString());
            MessageBox.Show(str, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 生成自定义异常消息
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="backStr">备用异常消息：当ex为null时有效</param>
        /// <returns>异常字符串文本</returns>
        static string GetExceptionMsg(Exception ex, string backStr)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****************************异常文本****************************");
            sb.AppendLine("【出现时间】：" + DateTime.Now.ToString());
            if (ex != null)
            {
                sb.AppendLine("【异常类型】：" + ex.GetType().Name);
                sb.AppendLine("【异常信息】：" + ex.Message);
                sb.AppendLine("【堆栈调用】：" + ex.StackTrace);
                sb.AppendLine("【异常方法】：" + ex.TargetSite);

            }
            else
            {
                sb.AppendLine("【未处理异常】：" + backStr);
            }
            sb.AppendLine("***************************************************************");
            return sb.ToString();
        }

        static void ChkLogin(string sUser, string sPwd, ref bool bln)
        {
            bln = false;

            string sql = string.Format("SELECT password FROM TB_UPC_USER WHERE UPPER(usercode) = UPPER('{0}')", sUser);
            DataTable ds = db.GetRs(sql);

            if (ds.Rows.Count == 0)
            {
                MessageBox.Show("用户名不存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (ds.Rows[0]["password"].ToString().ToLower() != System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sPwd, "MD5").ToLower())
                {
                    MessageBox.Show("密码不正确。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    usercode = sUser;
                    bln = true;
                }
            }
        }

        static bool ChkPass(string sUser, string sMd5)
        {
            bool bln = false;

            string sql = string.Format("SELECT password FROM TB_UPC_USER WHERE UPPER(usercode) = UPPER('{0}')", sUser);
            DataTable ds = db.GetRs(sql);

            if (ds.Rows.Count == 0)
            {
                MessageBox.Show("用户名不存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (ds.Rows[0]["password"].ToString().ToLower() != sMd5.ToLower())
                {
                    MessageBox.Show("密码不正确。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    usercode = sUser;
                    bln = true;
                }
            }

            return bln;
        }
    }
}
