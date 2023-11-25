using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace login {
    public class RoundedPanel : Panel
    {
        private int radius = 20; // 기본 반지름

        // 반지름 속성
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate(); // 다시 그리기
            }
        }

        public RoundedPanel()
        {
            // 둥근 모서리 설정
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            UpdateStyles();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // 둥근 모서리 그리기
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            Region = new Region(path);
        }
    }
}
    