using Com.Database;
using RotateText;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MapMonitor
{
    public partial class frmLineInfo : Form
    {
        CDatabase db = Program.db;

        private Font _font = new Font("微软雅黑", 9);
        private Brush _brush = new SolidBrush(Color.Black);
        private const int _size = 12;

        DataTable dtStations = new DataTable();

        private int lstX = 0;
        private int pnlW = 0;

        private string LineID;

        public frmLineInfo(LineInfo li)
        {
            LineID = li.LineID;

            InitializeComponent();
            this.DoubleBuffered = true;

            CreateLine();
            ResizeCtl();
        }

        private void CreateLine()
        {
            string sql = "SELECT B.STATION_POS AS up_pos, B.STATIONID2 AS up_stationid, B.STATIONNAME AS up_stationname, C.STATION_POS AS dn_pos, C.STATIONID2 AS dn_stationid, C.STATIONNAME AS dn_stationname "
                        + "FROM ( "
                        + "	   SELECT A.CASEID,A.STATION_DIREC,A.STATION_POS,B.STATIONID2,B.STATIONNAME "
                        + "    FROM TB_LINE_CASES C INNER JOIN TB_LINE_STATIONS A ON A.LINEID = C.LINEID AND C.CASEID = A.CASEID INNER JOIN TB_STATIONS B ON B.STATIONID = A.STATIONID "
                        + "	   WHERE C.LINEID = '" + LineID + "' AND C.ISDEFAULT = 1 AND C.STOPSIGN = 0 AND A.STATION_DIREC = 0 "
                        + ") B "
                        + "FULL JOIN ( "
                        + "	   SELECT A.CASEID,A.STATION_DIREC,A.STATION_POS,B.STATIONID2,B.STATIONNAME "
                        + "    FROM TB_LINE_CASES C INNER JOIN TB_LINE_STATIONS A ON A.LINEID = C.LINEID AND C.CASEID = A.CASEID INNER JOIN TB_STATIONS B ON B.STATIONID = A.STATIONID "
                        + "	   WHERE C.LINEID = '" + LineID + "' AND C.ISDEFAULT = 1 AND C.STOPSIGN = 0 AND A.STATION_DIREC = 1 "
                        + ") C ON C.STATIONNAME = B.STATIONNAME "
                        + "ORDER BY B.STATION_POS, C.STATION_POS DESC";
            DataTable dt = db.GetRs(sql);

            dtStations = dt;

            //获取最小宽度
            DataRow[] dr_Up = dtStations.Select("up_stationid IS NOT NULL", "up_pos Asc");
            DataRow[] dr_Dn = dtStations.Select("dn_stationid IS NOT NULL", "dn_pos Desc");

            if (dr_Up.Length >= dr_Dn.Length)
            {
                pnlW = (dr_Up.Length - 1) * 24 + picL.Width + picR.Width - _size * 2;
            }
            else
            {
                pnlW = (dr_Dn.Length - 1) * 24 + picL.Width + picR.Width - _size * 2;
            }

            //PaintLine();
        }

        private void PaintLine()
        {
            if (dtStations.Rows.Count == 0)
            { return; }

            lstX = 0;

            //Graphics g = pnlCase.CreateGraphics();  //创建画板 
            Bitmap b = new Bitmap(pnlCase.Width, pnlCase.Height);
            pnlCase.BackgroundImage = b;
            Graphics g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;   //高质量绘图，防止毛刺
            g.Clear(pnlCase.BackColor);             //清除已绘图像

            //准备数据
            DataRow[] dr_Up = dtStations.Select("up_stationid IS NOT NULL", "up_pos Asc");
            DataRow[] dr_Dn = dtStations.Select("dn_stationid IS NOT NULL", "dn_pos Desc");

            int l = picL.Left + picL.Width - _size - 2;
            int r = picR.Left + _size + 1;
            double s;
            if (dr_Up.Length >= dr_Dn.Length)
            {
                s = Math.Round(((double)(r - l - _size)) / (dr_Up.Length - 1));
            }
            else
            {
                s = Math.Round(((double)(r - l - _size)) / (dr_Dn.Length - 1));
            }

            int t = picL.Top + (picL.Height - _size) / 2;
            int i = 0;
            int j = 0;
            int k = 0;
            bool bln = false;

            Pen pUp = new Pen(Color.LimeGreen, 2);
            Pen pDn = new Pen(Color.RoyalBlue, 2);
            Point tmpUp = new Point();
            Point tmpDn = new Point();

            //绘制站点
            while (true)
            {
                Point p;

                if (dr_Up[i]["up_stationname"].ToString() == dr_Dn[j]["dn_stationname"].ToString())
                {
                    p = new Point((int)((s * k) + l), t);
                    if (tmpUp.Y != 0)
                    { DrawLine(g, pUp, tmpUp, p, true); }
                    tmpUp = p;
                    if (tmpDn.Y != 0)
                    { DrawLine(g, pDn, tmpDn, p, false); }
                    tmpDn = p;
                    DrawDot(g, p);

                    if (bln)
                    {
                        PointF pf = new PointF(p.X - _size / 2, p.Y - 24);
                        string st = dr_Up[i]["up_stationname"].ToString();
                        if (st.IndexOf("（") != -1)
                        {
                            st = st.Substring(0, st.IndexOf("（")) + "\r\n" + st.Substring(st.IndexOf("（"));
                        }
                        DrawText(g, st, pf, StringAlignment.Near);
                    }
                    else
                    {
                        PointF pf = new PointF(p.X + _size + _size / 2, p.Y + _size + 24);
                        string st = dr_Up[i]["up_stationname"].ToString();
                        if (st.IndexOf("（") != -1)
                        {
                            st = st.Substring(0, st.IndexOf("（")) + "\r\n" + st.Substring(st.IndexOf("（"));
                        }
                        DrawText(g, st, pf, StringAlignment.Far);
                    }
                    bln = !bln;

                    i += 1;
                    j += 1;
                }
                else
                {
                    if (dr_Up[i].IsNull("dn_stationid"))
                    {
                        p = new Point((int)((s * k) + l), t - 24);
                        if (tmpUp.Y != 0)
                        { DrawLine(g, pUp, tmpUp, p, true); }
                        tmpUp = p;
                        DrawDot(g, p);

                        PointF pf = new PointF(p.X - _size / 2, p.Y - 24);
                        string st = dr_Up[i]["up_stationname"].ToString();
                        if (st.IndexOf("（") != -1)
                        {
                            st = st.Substring(0, st.IndexOf("（")) + "\r\n" + st.Substring(st.IndexOf("（"));
                        }
                        DrawText(g, st, pf, StringAlignment.Near);

                        i += 1;
                    }

                    if (dr_Dn[j].IsNull("up_stationid"))
                    {
                        p = new Point((int)((s * k) + l), t + 24);
                        if (tmpDn.Y != 0)
                        { DrawLine(g, pDn, tmpDn, p, false); }
                        tmpDn = p;
                        DrawDot(g, p);

                        PointF pf = new PointF(p.X + _size + _size / 2, p.Y + 24);
                        string st = dr_Dn[j]["dn_stationname"].ToString();
                        if (st.IndexOf("（") != -1)
                        {
                            st = st.Substring(0, st.IndexOf("（")) + "\r\n" + st.Substring(st.IndexOf("（"));
                        }
                        DrawText(g, st, pf, StringAlignment.Far);

                        j += 1;
                    }
                }

                k += 1;

                if (i == dr_Up.Length && j == dr_Dn.Length)
                {
                    picR.Left = lstX - 1;
                    break;
                }
            }
        }

        private void DrawDot(Graphics g, Point pf)
        {
            g.FillEllipse(Brushes.White, pf.X, pf.Y, _size, _size);       //绘制实心圆点
            Pen p = new Pen(Color.Gray, 2);             //创建画笔
            g.DrawEllipse(p, pf.X, pf.Y, _size, _size);       //绘制空心圆作为边框

            if (pf.X > lstX)
            {
                lstX = pf.X;
            }
        }

        private void DrawLine(Graphics g, Pen p, Point p1, Point p2, bool direct)
        {
            Point ps;
            Point pe;

            if (direct)
            {
                if (p1.Y == p2.Y)
                {
                    ps = new Point(p1.X + _size - 1, p1.Y + 2);
                    pe = new Point(p2.X + 1, p2.Y + 2);
                }
                else if (p1.Y > p2.Y)
                {
                    ps = new Point(p1.X + _size - 1, p1.Y + 2);
                    pe = new Point(p2.X + 1, p2.Y + _size / 2);
                }
                else
                {
                    ps = new Point(p1.X + _size - 1, p1.Y + _size / 2);
                    pe = new Point(p2.X + 1, p2.Y + 2);
                }
            }
            else
            {
                if (p1.Y == p2.Y)
                {
                    ps = new Point(p1.X + _size - 1, p1.Y + _size - 2);
                    pe = new Point(p2.X + 1, p2.Y + _size - 2);
                }
                else if (p1.Y < p2.Y)
                {
                    ps = new Point(p1.X + _size - 1, p1.Y + _size - 2);
                    pe = new Point(p2.X + 1, p2.Y + _size / 2);
                }
                else
                {
                    ps = new Point(p1.X + _size - 1, p1.Y + _size / 2);
                    pe = new Point(p2.X + 1, p2.Y + _size - 2);
                }
            }

            //if (ps.Y == pe.Y)
            //{
            g.DrawLine(p, ps, pe);
            //}
            //else
            //{
            //    g.DrawBezier(p, ps, new Point((int)(ps.X + (pe.X - ps.X) / 1.2), ps.Y), new Point((int)(pe.X - (pe.X - ps.X) / 1.2), pe.Y), pe);
            //}
        }

        private void DrawText(Graphics g, string s, PointF pf, StringAlignment r)
        {
            GraphicsText graphicsText = new GraphicsText();
            graphicsText.Graphics = g;

            // 绘制围绕点旋转的文本  
            StringFormat format = new StringFormat();
            format.Alignment = r;
            format.LineAlignment = r;

            graphicsText.DrawString(s, _font, _brush, pf, format, -45f);
        }

        private void ResizeCtl()
        {
            if (pnlChart.ClientSize.Width < pnlW)
            {
                pnlCase.Width = pnlW;
            }
            else
            {
                pnlCase.Width = pnlChart.ClientSize.Width;
            }

            picL.Location = new Point(40, (pnlCase.ClientSize.Height - picL.Height) / 2);
            picR.Location = new Point(pnlCase.ClientSize.Width - picR.Width - 40, picL.Top);

            PaintLine();
        }

        private void frmTrack_Resize(object sender, EventArgs e)
        {
            ResizeCtl();
        }
    }
}
