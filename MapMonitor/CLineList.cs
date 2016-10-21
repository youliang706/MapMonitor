using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapMonitor
{
    public class CLineList
    {
        private static List<LineInfo> lineInfo = new List<LineInfo>();

        public static List<LineInfo> LineInfo
        {
            get { return lineInfo; }
            set { lineInfo = value; }
        }

        private static List<LineInfo> grpInfo = new List<LineInfo>();

        public static List<LineInfo> GrpInfo
        {
            get { return grpInfo; }
            set { grpInfo = value; }
        }

        public static List<string> ManagedLines
        {
            get
            {
                List<string> lines = new List<string>();
                for (int i = 0; i < lineInfo.Count; i++)
                {
                    lines.Add(lineInfo[i].LineID2.ToString());
                }

                return lines;
            }
        }
    }
}
