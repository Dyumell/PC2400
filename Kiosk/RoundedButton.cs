using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace login
{
    public class RoundButton : Button
    {
        public RoundButton()
        {

            this.BackColor = Color.FromArgb(255, 168, 0);
            this.FlatAppearance.BorderSize = 0;
            this.Font = new Font("Arial", 12);
            this.ForeColor = Color.Black;
            this.FlatStyle = FlatStyle.Flat;
            this.Padding = new Padding(0);

        }

        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // 조절 가능한 반지름 값

            // 좌상단
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            // 우상단
            path.AddArc(Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            // 우하단
            path.AddArc(Width - radius * 2, Height - radius * 2, radius * 2, radius * 2, 0, 90);
            // 좌하단
            path.AddArc(0, Height - radius * 2, radius * 2, radius * 2, 90, 90);

            this.Region = new Region(path);
        }
    }
}


