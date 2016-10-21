using GMap.NET.WindowsForms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GMap.Extend
{
    public enum OffsetType : int
    {
        TopRight = 1,
        BottomRight = 2,
        BottomLeft = 3,
        TopLeft = 4
    }

    /// <summary>
    /// GMap.NET marker
    /// </summary>
    public class GMapTip : GMapToolTip
    {
        internal GMapMarker Marker;

        public Point Offset;

        /// <summary>
        /// string format
        /// </summary>
        public StringFormat Format = new StringFormat();

        /// <summary>
        /// font
        /// </summary>
        public Font Font = new Font("微软雅黑", 9);

        /// <summary>
        /// specifies how the outline is painted
        /// </summary>
        public Pen Stroke = null;

        /// <summary>
        /// background color
        /// </summary>
        public Brush Fill = null;

        /// <summary>
        /// forecolor
        /// </summary>
        public Brush Fore = null;

        /// <summary>
        /// text padding
        /// </summary>
        public Size TextPadding = new Size(4, 2);

        public GMapTip(GMapMarker marker, Color BackColor, Color ForeColor)
            : base(marker)
        {
            SetGMapTip(marker, BackColor, ForeColor, new Point(10, -20));
        }

        public GMapTip(GMapMarker marker, Color BackColor, Color ForeColor, OffsetType offsetType)
            : base(marker)
        {
            Point offset = new Point(0, 0);
            switch (offsetType)
            {
                case OffsetType.TopRight:
                    offset = new Point(10, -10);
                    break;

                case OffsetType.BottomRight:
                    offset = new Point(10, 10);
                    break;

                case OffsetType.TopLeft:
                    offset = new Point(-10, -10);
                    break;

                case OffsetType.BottomLeft:
                    offset = new Point(-10, 10);
                    break;
            }
            SetGMapTip(marker, BackColor, ForeColor, offset);
        }

        public void SetGMapTip(GMapMarker marker, Color BackColor, Color ForeColor, Point offset)
        {
            this.Marker = marker;
            this.Offset = offset;

            this.Stroke = new Pen(Color.FromArgb(255, BackColor));
            this.Fill = new SolidBrush(Color.FromArgb(200, BackColor));
            this.Fore = new SolidBrush(Color.FromArgb(255, ForeColor));

            this.Stroke.Width = 1;
            this.Stroke.LineJoin = LineJoin.Round;
            this.Stroke.StartCap = LineCap.RoundAnchor;

            this.Format.Alignment = StringAlignment.Center;
            this.Format.LineAlignment = StringAlignment.Center;
        }

        public override void OnRender(Graphics g)
        {
            System.Drawing.Size st = g.MeasureString(Marker.ToolTipText, Font).ToSize();

            int x = Marker.ToolTipPosition.X;       //Marker.LocalPosition.X + Marker.Size.Width / 2;
            int y = Marker.ToolTipPosition.Y;       // Marker.LocalPosition.Y + Marker.Size.Height / 2;
            int w = st.Width + TextPadding.Width;
            int h = st.Height + TextPadding.Height;

            if (Offset.X > 0)
            {
                if (Offset.Y > 0)   //BottomRight
                {
                    x = x + Offset.X;
                    y = y + Offset.Y;
                }
                else                //TopRight
                {
                    x = x + Offset.X;
                    y = y + Offset.Y - st.Height;
                }
            }
            else
            {
                if (Offset.Y > 0)   //BottomLeft
                {
                    x = x + Offset.X - st.Width;
                    y = y + Offset.Y;
                }
                else                //TopLeft
                {
                    x = x + Offset.X - st.Width;
                    y = y + Offset.Y - st.Height;
                }
            }

            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, w, h);

            if (Offset.X > 0)
            {
                g.DrawLine(Stroke, Marker.ToolTipPosition.X, Marker.ToolTipPosition.Y, rect.X, rect.Y + rect.Height / 2);
            }
            else
            {
                g.DrawLine(Stroke, Marker.ToolTipPosition.X, Marker.ToolTipPosition.Y, rect.X + rect.Width, rect.Y + rect.Height / 2);
            }

            g.FillRectangle(Fill, rect);
            g.DrawRectangle(Stroke, rect);

            g.DrawString(Marker.ToolTipText, Font, Fore, rect, Format);
        }
    }
}
