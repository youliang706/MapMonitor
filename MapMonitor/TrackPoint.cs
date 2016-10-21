using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapMonitor
{
    public class TrackPoint
    {
        public TrackPoint(double lon, double lat)
        {
            longitude = lon;
            latitude = lat;
        }

        private double longitude;

        public double Lon
        {
            get { return longitude; }
            set { longitude = value; }
        }

        private double latitude;

        public double Lat
        {
            get { return latitude; }
            set { latitude = value; }
        }
    }
}
