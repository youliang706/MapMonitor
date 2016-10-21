using Com.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MapMonitor
{
    public partial class frmAudioSend : Form
    {
        CDatabase db = Program.db;

        private List<string> phoneNumber = new List<string>();

        public event MsgEventHandler SendMsg;
        public void OnSendMsg(List<string> phoneNumbers, string content)
        {
            SendMsg?.Invoke(phoneNumbers, content);
        }

        public frmAudioSend(string phone)
        {
            InitializeComponent();

            this.phoneNumber.Add(phone);

            Init();
        }
        public frmAudioSend(List<string> phones)
        {
            InitializeComponent();

            this.phoneNumber = phones;

            Init();
        }

        private void Init()
        {
            this.Text = this.Text + "(" + this.phoneNumber.Count.ToString() + ")";

            //短语
            DataTable dt = db.GetRs("SELECT PHRASEID, PHRASENAME FROM TB_MANAGEPHRASE");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox_Example.Items.Add(dt.Rows[i]["PHRASENAME"].ToString());
                }
            }
        }

        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Send_Click(object sender, EventArgs e)
        {
            string content = textBox_SendContent.Text;
            if (string.IsNullOrEmpty(content.Trim()))
            {
                MessageBox.Show("发送内容为空，请输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OnSendMsg(phoneNumber, content);

            MessageBox.Show("语音下发成功", "语音下发", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_SendContent.Text = string.Empty;
        }

        private void comboBox_Example_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = comboBox_Example.SelectedIndex;

            textBox_SendContent.Text = comboBox_Example.Items[selIndex].ToString();
        }
    }
}
