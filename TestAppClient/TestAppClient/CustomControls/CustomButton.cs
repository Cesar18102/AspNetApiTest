using System;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace TestAppClient.CustomControls
{
    public class CustomButton : Button
    {
        private const int CLICK_COLOR_CHANGE_TIMEOUT = 100;
        private enum SIDE : int { LeftTop, RightTop, RightBot, LeftBot };

        private int smooth = 10;
        [Category("View")]
        public int Smooth { get => smooth; set { smooth = value; UpdatePathes(); Invalidate(); } }

        private int r = 0;
        [Category("View")]
        public int CornerRadius { get => r; set { r = value; UpdatePathes(); Invalidate(); } }

        private Color cornerBackColor = Color.FromKnownColor(KnownColor.Control);
        [Category("View")]
        [Browsable(true)]
        public virtual Color CornerBackColor { get => cornerBackColor; set { cornerBackColor = value; Invalidate(); } }

        private Color borderColor = Color.FromKnownColor(KnownColor.Black);
        [Category("View")]
        [Browsable(true)]
        public virtual Color BorderColor { get => borderColor; set { borderColor = value; Invalidate(); } }

        private float borderWidth = 5;
        [Category("View")]
        public float BorderWidth { get => borderWidth; set { borderWidth = value; Invalidate(); } }

        private float enteredBorderWidth = 7;
        [Category("View")]
        public float EnteredBorderWidth { get => enteredBorderWidth; set { enteredBorderWidth = value; Invalidate(); } }

        private Color enteredBackColor = Color.FromKnownColor(KnownColor.Gray);
        [Category("View")]
        [Browsable(true)]
        public virtual Color EnteredBackColor { get => enteredBackColor; set { enteredBackColor = value; Invalidate(); } }

        private Color defBackColor = Color.FromKnownColor(KnownColor.Control);
        [Category("View")]
        [Browsable(true)]
        public virtual Color DefBackColor { get => defBackColor; set { defBackColor = value; Invalidate(); } }

        private GraphicsPath[] pathes = new GraphicsPath[4];
        private GraphicsPath border { get; set; }
        private bool entered = false;

        protected override void OnSizeChanged(EventArgs e) => UpdatePathes();

        protected override void OnMouseEnter(EventArgs e) { base.OnMouseEnter(e); entered = true; Invalidate(); }
        protected override void OnMouseLeave(EventArgs e) { base.OnMouseLeave(e); entered = false; Invalidate(); }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            BackColor = EnteredBackColor;
            Task.Run(() =>
            {
                Thread.Sleep(CLICK_COLOR_CHANGE_TIMEOUT);
                BackColor = DefBackColor;
            });
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (CornerRadius == 0)
                return;

            for (int i = 0; i < pathes.Length; i++)
                pevent.Graphics.FillPath(new SolidBrush(CornerBackColor), pathes[i]);

            pevent.Graphics.DrawPath(new Pen(BorderColor, entered ? EnteredBorderWidth : BorderWidth), border);
        }

        private Point[] GetCornerPoints(Point center, double angleStart, double angle, int pointsCount)
        {
            Point[] pts = new Point[pointsCount];
            double angleDelta = angle / (pointsCount - 1);

            double a = angleStart;
            for (int i = 0; i < pts.Length; i++, a += angleDelta)
                pts[i] = new Point((int)(center.X + CornerRadius * Math.Cos(a)), (int)(center.Y - r * Math.Sin(a)));

            return pts;
        }

        private Point[] GetBorderPoints(Point start, Point[] border)
        {
            Point[] pts = new Point[border.Length + 2];
            Array.Copy(border, 0, pts, 1, border.Length);

            pts[0] = start;
            pts[pts.Length - 1] = start;

            return pts;
        }

        private byte[] GetPointTypes(int count, PathPointType start = PathPointType.Start)
        {
            byte[] types = new byte[count];
            types[0] = (byte)start;

            for (int i = 1; i < count; i++)
                types[i] = (byte)PathPointType.Line;

            return types;
        }

        private void UpdatePathes()
        {
            byte[] cornerPointTypes = GetPointTypes(smooth + 2);

            Point[] ltp = GetCornerPoints(new Point(r, r), Math.PI, -Math.PI / 2, smooth);
            Point[] rtp = GetCornerPoints(new Point(Width - r, r), Math.PI / 2, -Math.PI / 2, smooth);
            Point[] rbp = GetCornerPoints(new Point(Width - r, Height - r), 0, -Math.PI / 2, smooth);
            Point[] lbp = GetCornerPoints(new Point(r, Height - r), -Math.PI / 2, -Math.PI / 2, smooth);

            pathes[(int)SIDE.LeftTop] = new GraphicsPath(GetBorderPoints(new Point(0, 0), ltp), cornerPointTypes);
            pathes[(int)SIDE.RightTop] = new GraphicsPath(GetBorderPoints(new Point(Width, 0), rtp), cornerPointTypes);
            pathes[(int)SIDE.RightBot] = new GraphicsPath(GetBorderPoints(new Point(Width, Height), rbp), cornerPointTypes);
            pathes[(int)SIDE.LeftBot] = new GraphicsPath(GetBorderPoints(new Point(0, Height), lbp), cornerPointTypes);

            border = new GraphicsPath(ltp.Concat(rtp).Concat(rbp).Concat(lbp).Append(ltp[0]).ToArray(), GetPointTypes(smooth * 4 + 1));
        }
    }
}
