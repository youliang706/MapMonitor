namespace MapMonitor
{
    /// <summary>
    /// 公交车信息对象
    /// </summary>
    public class BusInfo
    {
        /// <summary>
        /// 公交车ID
        /// </summary>
        private string busID;

        /// <summary>
        /// 公交车ID2
        /// </summary>
        private string busID2;

        /// <summary>
        /// 公交车内部编号
        /// </summary>
        private string busNumber;

        /// <summary>
        /// 所在的线路编号
        /// </summary>
        private string lineID;

        /// <summary>
        /// 车牌号
        /// </summary>
        private string plateNumber;

        /// <summary>
        /// 公交车车载设备手机号
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// 状态
        /// </summary>
        private string status;

        /// <summary>
        /// 设备类型
        /// </summary>
        private int equipType;

        /// <summary>
        /// 车辆设备编号
        /// </summary>
        private string busCode;

        /// <summary>
        /// 公交车ID
        /// </summary>
        public string BusID
        {
            get { return busID; }
            set { busID = value; }
        }

        /// <summary>
        /// 公交车ID2
        /// </summary>
        public string BusID2
        {
            get { return busID2; }
            set { busID2 = value; }
        }

        /// <summary>
        /// 公交车内部编号
        /// </summary>
        public string BusNumber
        {
            get { return busNumber; }
            set { busNumber = value; }
        }

        public string BusNo
        {
            get 
            {  
                int pos = busNumber.IndexOf("-") + 1;
                return pos > 0 ? busNumber.Substring(pos) : busNumber; 
            }
        }

        /// <summary>
        /// 所在的线路编号
        /// </summary>
        public string LineID
        {
            get { return lineID; }
            set { lineID = value; }
        }

        /// <summary>
        /// 公交车车牌号
        /// </summary>
        public string PlateNumber
        {
            get { return plateNumber; }
            set { plateNumber = value; }
        }

        /// <summary>
        /// 公交车车载设备手机号
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        /// <summary>
        /// 状态
        /// </summary>
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// 设备类型
        /// </summary>
        public int EquipType
        {
            get { return equipType; }
            set { equipType = value; }
        }

        /// <summary>
        /// 车辆设备编号
        /// </summary>
        public string BusCode
        {
            get { return busCode; }
            set { busCode = value; }
        }

        public override string ToString()
        {
            return busNumber;
        }

    }
}
