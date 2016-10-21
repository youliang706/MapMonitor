using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Net.Sockets;

namespace MapMonitor
{
    /// <summary>
    /// 公交线路信息对象
    /// </summary>
    public class LineInfo
    {
        /// <summary>
        /// 线路名称
        /// </summary>
        private string name;

        /// <summary>
        /// 线路ID
        /// </summary>
        private string lineID;

        /// <summary>
        /// 线路ID2
        /// </summary>
        private int lineID2;

        /// <summary>
        /// 线路下面的公交车列表
        /// </summary>
        private List<BusInfo> busList;

        /// <summary>
        /// 上行线路轨迹点列表
        /// </summary>
        private List<TrackPoint> upTrackPointList;

        /// <summary>
        /// 下行线路轨迹点列表
        /// </summary>
        private List<TrackPoint> downTrackPointList;

        /// <summary>
        /// 上行站点列表
        /// </summary>
        private List<StationInfo> upStationList;

        /// <summary>
        /// 下行站点列表
        /// </summary>
        private List<StationInfo> downStationList;

        public LineInfo()
        {
            busList = new List<BusInfo>();
            upTrackPointList = new List<TrackPoint>();
            downTrackPointList = new List<TrackPoint>();
            upStationList = new List<StationInfo>();
            downStationList = new List<StationInfo>();
        }

        /// <summary>
        /// 线路编号
        /// </summary>
        public string LineID
        {
            get { return lineID; }
            set { lineID = value; }
        }

        /// <summary>
        /// 线路编号2
        /// </summary>
        public int LineID2
        {
            get { return lineID2; }
            set { lineID2 = value; }
        }

        /// <summary>
        /// 线路名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 线路下属的公交车列表
        /// </summary>
        public List<BusInfo> BusList
        {
            get { return busList; }
        }

        /// <summary>
        /// 线路的上行轨迹点列表
        /// </summary>
        public List<TrackPoint> UpTrackPointList
        {
            get { return upTrackPointList; }
        }

        /// <summary>
        /// 线路的下行轨迹点列表
        /// </summary>
        public List<TrackPoint> DownTrackPointList
        {
            get { return downTrackPointList; }
        }

        /// <summary>
        /// 线路的上行站点列表
        /// </summary>
        public List<StationInfo> UpStationList
        {
            get { return upStationList; }
        }

        /// <summary>
        /// 线路的下行站点列表
        /// </summary>
        public List<StationInfo> DownStationList
        {
            get { return downStationList; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
