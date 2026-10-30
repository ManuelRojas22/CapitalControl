using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapitalControl.Controls
{
    public class GradientPanel : Panel
    {
        private Color _startColor = Color.FromArgb(30, 30, 30);
        private Color _endColor = Color.FromArgb(0, 0, 0);
        private float _angle = 90f;

        public Color StartColor
        {
            get => _startColor;
            set { _startColor = value; Invalidate(); }
        }

        public Color EndColor
        {
            get => _endColor;
            set { _endColor = value; Invalidate(); }
        }

        public float Angle
        {
            get => _angle;
            set { _angle = value; Invalidate(); }
        }

        public GradientPanel()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void PaintGradient(Graphics g)
        {
            if (ClientRectangle.Width == 0 || ClientRectangle.Height == 0) return;
            if (StartColor == EndColor)
            {
                using (var brush = new SolidBrush(StartColor))
                    g.FillRectangle(brush, ClientRectangle);
            }
            else
            {
                using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    ClientRectangle, StartColor, EndColor, Angle))
                {
                    g.FillRectangle(brush, ClientRectangle);
                }
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            PaintGradient(e.Graphics);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            PaintGradient(e.Graphics);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        }
    }
}