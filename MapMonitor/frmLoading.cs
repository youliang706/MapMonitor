using Com.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace MapMonitor
{
    public partial class frmLoading : Form
    {
        CDatabase db = Program.db;

        private string usercode;
        private bool blnRet = false;

        public frmLoading()
        {
            InitializeComponent();

            lblInfo.Text = "正在加载数据...";
            pgbInfo.Position = 1;
        }

        public bool ShowMe(string user)
        {
            usercode = user;
            tmr.Interval = 1;
            tmr.Enabled = true;

            this.ShowDialog();

            return blnRet;
        }

        private void InitLines()
        {
            GetLinesInfo();
            GetGrpInfo();
            GetTrackInfo();

            lblInfo.Text = "数据加载完毕，正在进入系统...";
            pgbInfo.Position = 100;
            this.Refresh();
        }

        /// <summary>
        /// 获取线路信息以及车辆信息
        /// </summary>
        private void GetLinesInfo()
        {
            try
            {
                lblInfo.Text = "正在读取线路数据...";
                pgbInfo.Position = 10;
                this.Refresh();

                string queryLineStr = "SELECT B.lineID, B.lineName, B.lineID2 " + Environment.NewLine
                                    + "FROM TB_User_Lines A INNER JOIN TB_Lines B ON B.lineID = A.lineID AND B.stopsign = 0 " + Environment.NewLine
                                    + "WHERE A.userCode = '" + usercode + "' " + Environment.NewLine
                                    + "ORDER BY B.lineName ";
                DataTable dt = db.GetRs(queryLineStr);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        LineInfo li = new LineInfo()
                        {
                            LineID = dt.Rows[i]["lineID"].ToString(),
                            Name = dt.Rows[i]["lineName"].ToString(),
                            LineID2 = int.Parse(dt.Rows[i]["lineID2"].ToString())
                        };
                        CLineList.LineInfo.Add(li);
                    }
                }

                for (int k = 0; k < CLineList.LineInfo.Count; k++)
                {
                    lblInfo.Text = "正在读取 " + CLineList.LineInfo[k].Name + " 车辆数据...";
                    pgbInfo.Position = (int)(20 + 10 * ((double)k / CLineList.LineInfo.Count));
                    this.Refresh();

                    string queryBusStr = "SELECT B.busID, B.busID2, B.busNumber, B.plateNumber, B.busSIMNO, NVL(C.equipType,0) AS equipType, NVL(C.busCode,B.busNumber) AS busCode " + Environment.NewLine
                                        + "FROM TB_Line_Buses A INNER JOIN TB_Buses B ON B.busID = A.busID AND B.stopsign = 0 " + Environment.NewLine
                                        + "LEFT JOIN TB_BusEquipType C ON C.busID2 = B.busID2 " + Environment.NewLine
                                        + "WHERE A.lineID = '" + CLineList.LineInfo[k].LineID + "' " + Environment.NewLine
                                        + "ORDER BY B.busNumber ";
                    dt = db.GetRs(queryBusStr);
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
                                EquipType = int.Parse(dt.Rows[i]["equipType"].ToString()),
                                BusCode = dt.Rows[i]["busCode"].ToString(),
                                LineID = CLineList.LineInfo[k].LineID,
                                Status = "offline"
                            };
                            CLineList.LineInfo[k].BusList.Add(bi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GetTrackInfo()
        {
            for (int j = 0; j < CLineList.LineInfo.Count; j++)
            {
                LineInfo li = CLineList.LineInfo[j];

                lblInfo.Text = "正在读取 " + li.Name + " 线路轨迹...";
                pgbInfo.Position = (int)(50 + 50 * ((double)j / CLineList.LineInfo.Count));
                this.Refresh();

                try
                {
                    //获取线路下上下行站点数据
                    string queryStationStr = "SELECT a.STATION_DIREC AS direct, a.STATION_POS as position, a.STATIONID, b.STATIONNAME, b.STATION_LON, b.STATION_LAT, b.STATIONID2 " + Environment.NewLine
                                            + "FROM TB_LINE_CASES c " + Environment.NewLine
                                            + "INNER JOIN TB_LINE_STATIONS a ON a.LINEID = c.LINEID AND a.CASEID = c.CASEID " + Environment.NewLine
                                            + "INNER JOIN TB_STATIONS b ON b.STATIONID = a.STATIONID AND b.stopsign = 0 " + Environment.NewLine
                                            + "WHERE c.LINEID = '" + li.LineID + "' AND c.ISDEFAULT = 1 AND c.stopsign = 0 " + Environment.NewLine
                                            + "ORDER BY a.STATION_DIREC ,a.STATION_POS";
                    DataTable dt = db.GetRs(queryStationStr);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        { 
                            StationInfo si = new StationInfo()
                            {
                                Latitude = double.Parse(dt.Rows[i]["STATION_LAT"].ToString()),
                                Longitude = double.Parse(dt.Rows[i]["STATION_LON"].ToString()),
                                Name = dt.Rows[i]["STATIONNAME"].ToString()
                            };

                            //上行
                            if (int.Parse(dt.Rows[i]["direct"].ToString()) == 0)
                            {
                                CLineList.LineInfo[j].UpStationList.Add(si);
                            }
                            //下行
                            else if (int.Parse(dt.Rows[i]["direct"].ToString()) == 1)
                            {
                                CLineList.LineInfo[j].DownStationList.Add(si);
                            }
                        }
                    }

                    //获取线路下标准轨迹数据
                    string queryTrackStr = "SELECT pointSn, lon, lat, direct " + Environment.NewLine
                                        + "FROM TB_Line_Tracks " + Environment.NewLine
                                        + "WHERE lineID = '" + li.LineID + "' " + Environment.NewLine
                                        + "ORDER BY pointSn";
                    dt = db.GetRs(queryTrackStr);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            TrackPoint tp = new TrackPoint(double.Parse(dt.Rows[i]["lon"].ToString()), double.Parse(dt.Rows[i]["lat"].ToString()));

                            //上行
                            if (int.Parse(dt.Rows[i]["direct"].ToString()) == 0)
                            {
                                CLineList.LineInfo[j].UpTrackPointList.Add(tp);
                            }
                            //下行
                            else if (int.Parse(dt.Rows[i]["direct"].ToString()) == 1)
                            {
                                CLineList.LineInfo[j].DownTrackPointList.Add(tp);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// 获取自定义分组以及车辆信息
        /// </summary>
        private void GetGrpInfo()
        {
            try
            {
                lblInfo.Text = "正在自定义分组数据...";
                pgbInfo.Position = 30;
                this.Refresh();

                string customGrpStr = "SELECT userCode, grpID, grpName " + Environment.NewLine
                                    + "FROM TB_CustomGrp " + Environment.NewLine
                                    + "WHERE userCode = '" + usercode + "' " + Environment.NewLine
                                    + "ORDER BY grpName ";
                DataTable dt = db.GetRs(customGrpStr);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        {
                            LineInfo li = new LineInfo()
                            {
                                LineID = dt.Rows[i]["lineID"].ToString(),
                                Name = dt.Rows[i]["lineName"].ToString(),
                                LineID2 = int.Parse(dt.Rows[i]["lineID2"].ToString())
                            };

                            CLineList.GrpInfo.Add(li);
                        }
                    }
                }

                //获取分组下公交车数据
                for (int k = 0; k < CLineList.GrpInfo.Count; k++)
                {
                    lblInfo.Text = "正在读取 " + CLineList.GrpInfo[k].Name + " 车辆数据...";
                    pgbInfo.Position = (int)(40 + 10 * ((double)k / CLineList.GrpInfo.Count));
                    this.Refresh();

                    string queryBusStr = "SELECT B.busID, B.busID2, B.busNumber, B.plateNumber, B.busSIMNO, NVL(C.equipType,0) AS equipType, NVL(C.busCode,B.busNumber) AS busCode " + Environment.NewLine
                                        + "FROM TB_CustomBuses A INNER JOIN TB_Buses B ON B.busID = A.busID AND B.stopsign = 0 " + Environment.NewLine
                                        + "LEFT JOIN TB_BusEquipType C ON C.busID2 = B.busID2 " + Environment.NewLine
                                        + "WHERE A.grpID = '" + CLineList.GrpInfo[k].LineID + "' " + Environment.NewLine
                                        + "ORDER BY B.busNumber ";
                    dt = db.GetRs(queryBusStr);
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
                                EquipType = int.Parse(dt.Rows[i]["equipType"].ToString()),
                                BusCode = dt.Rows[i]["busCode"].ToString(),
                                LineID = CLineList.LineInfo[k].LineID,
                                Status = "offline"
                            };

                            CLineList.GrpInfo[k].BusList.Add(bi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Enabled = false;
            InitLines();

            blnRet = true;
            this.Close();
        }
    }
}