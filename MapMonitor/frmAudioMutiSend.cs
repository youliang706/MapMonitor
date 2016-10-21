using Com.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MapMonitor
{
    public partial class frmAudioMutiSend : Form
    {
        CDatabase db = Program.db;

        private string userCode;
        private Dictionary<string, string> phoneNumber = new Dictionary<string, string>();

        public event MsgEventHandler SendMsg;
        public void OnSendMsg(List<string> phoneNumbers, string content)
        {
            SendMsg?.Invoke(phoneNumbers, content);
        }

        public frmAudioMutiSend(string usercode)
        {
            InitializeComponent();

            this.userCode = usercode;

            Init();
        }

        private void Init()
        {
            this.Text = this.Text + "(" + this.phoneNumber.Count.ToString() + ")";

            //线路
            string sql = "SELECT B.lineID, B.lineName, B.lineID2 " + Environment.NewLine
                        + "FROM TB_User_Lines A INNER JOIN TB_Lines B ON A.lineID = B.lineID " + Environment.NewLine
                        + "WHERE upper(A.userCode) = upper('" + userCode + "') " + Environment.NewLine
                        + "AND b.stopsign = 0 " + Environment.NewLine
                        + "ORDER BY B.lineName";
            DataTable dt = db.GetRs(sql);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    LineInfo li = new LineInfo()
                    {
                        LineID = dt.Rows[i]["lineID"].ToString(),
                        LineID2 = int.Parse(dt.Rows[i]["lineID2"].ToString()),
                        Name = dt.Rows[i]["lineName"].ToString()
                    };

                    cboLines.Items.Add(li);
                }
            }

            //短语
            dt = db.GetRs("SELECT PHRASEID, PHRASENAME FROM TB_MANAGEPHRASE");
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
                MessageBox.Show("发送内容为空，请输入。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phoneNumber.Count == 0)
            {
                MessageBox.Show("请选择车辆。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> phones = new List<string>();
            foreach (KeyValuePair<string, string> kv in phoneNumber)
            {
                phones.Add(kv.Key);
            }
            OnSendMsg(phones, content);

            MessageBox.Show("语音下发成功", "语音下发", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_SendContent.Text = string.Empty;
        }

        private void comboBox_Example_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = comboBox_Example.SelectedIndex;

            textBox_SendContent.Text = comboBox_Example.Items[selIndex].ToString();
        }

        private void cboLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currSel = cboLines.SelectedIndex;

            if (currSel >= 0)
            {
                GetBusInfo();
                LineInfo li = (LineInfo)cboLines.SelectedItem;

                lstBuses.Items.Clear();
                for (int i = 0; i < li.BusList.Count; i++)
                {
                    lstBuses.Items.Add(li.BusList[i]);
                }
            }
        }

        private void GetBusInfo()
        {
            LineInfo li = (LineInfo)cboLines.SelectedItem;

            if (li.BusList.Count != 0)
            {
                return;
            }

            //获取线路车辆
            string sql = "SELECT B.busID, B.busID2, B.busNumber, B.plateNumber, B.busSIMNO " + Environment.NewLine
                        + " FROM TB_Line_Buses A INNER JOIN TB_Buses B ON A.busID = B.busID " + Environment.NewLine
                        + " WHERE A.lineID = '" + li.LineID + "' AND b.stopsign = 0 " + Environment.NewLine
                        + " ORDER BY B.busNumber";

            DataTable dt = db.GetRs(sql);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BusInfo bi = new BusInfo()
                    {
                        BusID = dt.Rows[i]["busID"].ToString(),
                        BusID2 = dt.Rows[i]["busID2"].ToString(),
                        BusNumber = dt.Rows[i]["busNumber"].ToString(),
                        PlateNumber = dt.Rows[i]["plateNumber"].ToString(),
                        PhoneNumber = dt.Rows[i]["busSIMNO"].ToString(),
                        LineID = li.LineID
                    };

                    li.BusList.Add(bi);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<lstBuses.SelectedItems.Count; i++)
            {
                BusInfo bi = (BusInfo)lstBuses.SelectedItems[i];

                if (!phoneNumber.ContainsKey(bi.PhoneNumber))
                {
                    lstBuses2.Items.Add(bi);
                    phoneNumber.Add(bi.PhoneNumber, bi.PhoneNumber);
                    lblNum.Text = "已选择 " + phoneNumber.Count.ToString() + " 辆车";
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstBuses2.SelectedItems.Count; i++)
            {
                BusInfo bi = (BusInfo)lstBuses2.SelectedItems[i];

                if (phoneNumber.ContainsKey(bi.PhoneNumber))
                {
                    lstBuses2.Items.Remove(bi);
                    phoneNumber.Remove(bi.PhoneNumber);
                    lblNum.Text = "已选择 " + phoneNumber.Count.ToString() + " 辆车";
                }
            }
        }
    }
}
