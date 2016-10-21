using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Xml;
using System.Text;
using System.IO;

namespace GMap.Extend
{

    #region WGS84与墨卡托转换

    public class gpsPoint
    {
        public gpsPoint()
        { }
        public gpsPoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }
    }

    /// <summary>
    /// WGS84/GCJ02/BD09与墨卡托转换
    /// </summary>
    public class GpsTranslate
    {
        public static string GetAddress(string lng, string lat)
        {
            try
            {
                string url = @"http://api.map.baidu.com/geocoder/v2/?ak=YBjRNBchUS06g7qov8aHOyjf&callback=renderReverse&location=" + lat + "," + lng + @"&output=xml&pois=1";
                WebRequest request = WebRequest.Create(url);
                request.Method = "POST";
                XmlDocument xmlDoc = new XmlDocument();
                string sendData = xmlDoc.InnerXml;
                byte[] byteArray = Encoding.Default.GetBytes(sendData);

                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream, System.Text.Encoding.GetEncoding("utf-8"));
                string responseXml = reader.ReadToEnd();

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(responseXml);
                string status = xml.DocumentElement.SelectSingleNode("status").InnerText;
                if (status == "0")
                {

                    XmlNodeList nodes = xml.DocumentElement.GetElementsByTagName("formatted_address");
                    if (nodes.Count > 0)
                    {
                        return nodes[0].InnerText;
                    }
                    else
                        return "未获取到位置信息,错误码3";
                }
                else
                {
                    return "未获取到位置信息,错误码1";
                }
            }
            catch (System.Exception ex)
            {
                return "未获取到位置信息,错误码2";
            }
        }

        /// <summary>
        /// 经纬度转换
        /// </summary>
        /// <param name="lonlat"></param>
        /// <returns></returns>
        public static gpsPoint lonlat2mercator(gpsPoint lonlat)
        {
            gpsPoint mercator = new gpsPoint();
            double X = lonlat.X * 20037508.34 / 180;
            double Y = Math.Log(Math.Tan((90 + lonlat.Y) * Math.PI / 360)) / (Math.PI / 180);
            Y = Y * 20037508.34 / 180;
            mercator.X = X;
            mercator.Y = Y;
            return mercator;
        }
        /// <summary>
        /// 墨卡托转经纬度
        /// </summary>
        /// <param name="mercator"></param>
        /// <returns></returns>
        public static gpsPoint mercator2lonlat(gpsPoint mercator)
        {
            gpsPoint lonlat = new gpsPoint();
            double X = mercator.X / 20037508.34 * 180;
            double Y = mercator.Y / 20037508.34 * 180;
            Y = 180 / Math.PI * (2 * Math.Atan(Math.Exp(Y * Math.PI / 180)) - Math.PI / 2);
            lonlat.X = X;
            lonlat.Y = Y;
            return lonlat;
        }

        /// <summary>
        /// 火星坐标转地球坐标
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static gpsPoint GCJ02ToWGS84(gpsPoint point)
        {
            double jd = 0;
            double wd = 0;
            EvilTransform.GCJ02ToWGS84(point.Y, point.X, out wd, out jd);
            return new gpsPoint() { X = jd, Y = wd };
        }

        /// <summary>
        /// 地球坐标转火星坐标
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static gpsPoint WGS84ToGCJ02(gpsPoint point)
        {
            double jd = 0;
            double wd = 0;
            EvilTransform.transform(point.Y, point.X, out wd, out jd);
            return new gpsPoint() { X = jd, Y = wd };
        }
    }
    /// <summary>
    /// 地球坐标系 (WGS-84) 到火星坐标系 (GCJ-02) 的转换算法
    /// WGS-84 到 GCJ-02 的转换（即 GPS 加偏）算法 火星坐标与地图坐标转换 
    /// 参考：http://blog.csdn.net/yorling/article/details/9175913#
    /// </summary>
    public class EvilTransform
    {
        const double pi = 3.14159265358979324;
        const double a = 6378245.0;
        const double ee = 0.00669342162296594323;
        /// <summary>
        /// 地球坐标转火星坐标
        /// </summary>
        /// <param name="wgLat">转换前纬度坐标</param>
        /// <param name="wgLon">转换前经度坐标</param>
        /// <param name="mgLat">转换后纬度坐标</param>
        /// <param name="mgLon">转换后经度坐标</param>
        public static void transform(double wgLat, double wgLon, out double mgLat, out double mgLon)
        {
            //if (outOfChina(wgLat, wgLon))
            //{
            //    mgLat = wgLat;
            //    mgLon = wgLon;
            //    return;
            //}
            double dLat = transformLat(wgLon - 105.0, wgLat - 35.0);
            double dLon = transformLon(wgLon - 105.0, wgLat - 35.0);
            double radLat = wgLat / 180.0 * pi;
            double magic = Math.Sin(radLat);
            magic = 1 - ee * magic * magic;
            double sqrtMagic = Math.Sqrt(magic);
            dLat = (dLat * 180.0) / ((a * (1 - ee)) / (magic * sqrtMagic) * pi);
            dLon = (dLon * 180.0) / (a / sqrtMagic * Math.Cos(radLat) * pi);
            mgLat = wgLat + dLat;//
            mgLon = wgLon + dLon;
        }

        /// <summary>
        /// 坐标是否在国外
        /// </summary>
        /// <param name="lat">纬度</param>
        /// <param name="lon">经度</param>
        /// <returns></returns>
        public static bool outOfChina(double lat, double lon)
        {
            if (lon < 72.004 || lon > 137.8347)
            {
                return true;
            }
            if (lat < 0.8293 || lat > 55.8271)
            {
                return true;
            }
            return false;
        }
        static double transformLat(double x, double y)
        {
            double ret = -100.0 + 2.0 * x + 3.0 * y + 0.2 * y * y + 0.1 * x * y + 0.2 * Math.Sqrt(Math.Abs(x));
            ret += (20.0 * Math.Sin(6.0 * x * pi) + 20.0 * Math.Sin(2.0 * x * pi)) * 2.0 / 3.0;
            ret += (20.0 * Math.Sin(y * pi) + 40.0 * Math.Sin(y / 3.0 * pi)) * 2.0 / 3.0;
            ret += (160.0 * Math.Sin(y / 12.0 * pi) + 320 * Math.Sin(y * pi / 30.0)) * 2.0 / 3.0;
            return ret;
        }
        static double transformLon(double x, double y)
        {
            double ret = 300.0 + x + 2.0 * y + 0.1 * x * x + 0.1 * x * y + 0.1 * Math.Sqrt(Math.Abs(x));
            ret += (20.0 * Math.Sin(6.0 * x * pi) + 20.0 * Math.Sin(2.0 * x * pi)) * 2.0 / 3.0;
            ret += (20.0 * Math.Sin(x * pi) + 40.0 * Math.Sin(x / 3.0 * pi)) * 2.0 / 3.0;
            ret += (150.0 * Math.Sin(x / 12.0 * pi) + 300.0 * Math.Sin(x / 30.0 * pi)) * 2.0 / 3.0;
            return ret;
        }

        /// <summary>
        /// 火星坐标转地球坐标，误差1米内，没有二分法准确
        /// </summary>
        /// <param name="wgLat">转换前纬度坐标</param>
        /// <param name="wgLon">转换前经度坐标</param>
        /// <param name="mgLat">转换后纬度坐标</param>
        /// <param name="mgLon">转换后经度坐标</param>
        public static void GCJ02ToWGS84(double wgLat, double wgLon, out double mgLat, out double mgLon)
        {
            double jd = 0;
            double wd = 0;
            EvilTransform.transform(wgLat, wgLon, out wd, out jd);
            double d_jd = jd - wgLon;
            double d_wd = wd - wgLat;
            mgLon = wgLon - d_jd;
            mgLat = wgLat - d_wd;
        }
    }
    /// <summary>
    /// 火星坐标系 (GCJ-02) 与百度坐标系 (BD-09) 的转换算法，其中 bd_encrypt 将 GCJ-02 坐标转换成 BD-09 坐标， bd_decrypt 反之。
    /// </summary>
    public class BD_GCJTransform
    {
        const double x_pi = 3.14159265358979324 * 3000.0 / 180.0;
        /// <summary>
        /// 火星坐标系 (GCJ-02) 与百度坐标系 (BD-09) 的转换算法
        /// </summary>
        /// <param name="gg_lat"></param>
        /// <param name="gg_lon"></param>
        /// <param name="bd_lat"></param>
        /// <param name="bd_lon"></param>
        public void bd_encrypt(double gg_lat, double gg_lon, ref double bd_lat, ref double bd_lon)
        {
            double x = gg_lon, y = gg_lat;
            double z = Math.Sqrt(x * x + y * y) + 0.00002 * Math.Sin(y * x_pi);
            double theta = Math.Atan2(y, x) + 0.000003 * Math.Cos(x * x_pi);
            bd_lon = z * Math.Cos(theta) + 0.0065;
            bd_lat = z * Math.Cos(theta) + 0.006;
        }
        /// <summary>
        /// bd_encrypt 将 GCJ-02 坐标转换成 BD-09 坐标
        /// </summary>
        /// <param name="bd_lat"></param>
        /// <param name="bd_lon"></param>
        /// <param name="gg_lat"></param>
        /// <param name="gg_lon"></param>
        public void bd_decrypt(double bd_lat, double bd_lon, ref double gg_lat, ref double gg_lon)
        {
            double x = bd_lon - 0.0065, y = bd_lat - 0.006;
            double z = Math.Sqrt(x * x + y * y) - 0.00002 * Math.Sin(y * x_pi);
            double theta = Math.Atan2(y, x) - 0.000003 * Math.Cos(x * x_pi);
            gg_lon = z * Math.Cos(theta);
            gg_lat = z * Math.Sin(theta);
        }
    }

    #endregion
}