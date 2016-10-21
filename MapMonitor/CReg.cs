using Microsoft.Win32;

namespace Com.Register
{
    /// <summary>
    /// 注册表控制函数
    /// </summary>
    internal class CReg
    {
        /// <summary>
        /// 读取参数
        /// </summary>
        /// <param name="appname">应用程序名</param>
        /// <param name="section">项</param>
        /// <param name="key">键</param>
        /// <returns>值</returns>
        public string GetSettings(string appname, string section, string key)
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("SoftWare\\" + appname + "\\" + section);

            string s = reg.GetValue(key, "").ToString();
            return s;
        }

        /// <summary>
        /// 读取参数
        /// </summary>
        /// <param name="appname">应用程序名</param>
        /// <param name="section">项</param>
        /// <param name="key">键</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>值</returns>
        public string GetSettings(string appname, string section, string key, ref string defaultValue)
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("SoftWare\\" + appname + "\\" + section);

            string s = reg.GetValue(key, defaultValue).ToString();
            return s;
        }

        /// <summary>
        /// 写入参数
        /// </summary>
        /// <param name="appname">应用程序名</param>
        /// <param name="section">项</param>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        public void SaveSettings(string appname, string section, string key, string value)
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("SoftWare\\" + appname + "\\" + section);

            reg.SetValue(key, value);
        }
    }
}
