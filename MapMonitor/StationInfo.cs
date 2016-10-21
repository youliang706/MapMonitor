using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapMonitor
{
    /// <summary>
    /// 站点信息
    /// </summary>
    public class StationInfo
    {
        /// <summary>
        /// 站点所属的线路号
        /// </summary>
        private string lineID;

        /// <summary>
        /// 站点名称
        /// </summary>
        private string name;

        /// <summary>
        /// 经度
        /// </summary>
        private double longitude;

        /// <summary>
        /// 纬度
        /// </summary>
        private double latitude;


        /// <summary>
        /// 站点所属的线路号
        /// </summary>
        public string LineID
        {
            get { return lineID; }
            set { lineID = value; }
        }

        /// <summary>
        /// 经度
        /// </summary>
        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        /// <summary>
        /// 纬度
        /// </summary>
        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        /// <summary>
        /// 站点名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
