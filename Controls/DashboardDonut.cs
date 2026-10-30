using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapitalControl.Controls
{
    public class DonutSlice
    {
        public string Label { get; set; }
        public decimal Value { get; set; }
        public Color Color { get; set; }

        public DonutSlice(string label, decimal value, Color color)
        {
            Label = label;
            Value = value;
            Color = color;
        }
    }

    public partial class DashboardDonut : UserControl
    {
        public List<DonutSlice> Slices { get; set; } = new List<DonutSlice>();

        private int _ringThickness = 28;
        public int RingThickness
        {
            get => _ringThickness;
            set { _ringThickness = value; Invalidate(); }
        }

        public DashboardDonut()
        {
            // Enable custom painting
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Name = "DashboardDonut";
            this.Size = new System.Drawing.Size(200, 200);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var rect = ClientRectangle;
            int padding = 4;
            int diameter = Math.Min(rect.Width, rect.Height) - 2 * padding;
            if (diameter <= 0) return;

            var outerRect = new Rectangle(
                rect.X + (rect.Width - diameter) / 2,
                rect.Y + (rect.Height - diameter) / 2,
                diameter, diameter);

            // Draw placeholder if no data
            if (Slices == null || Slices.Count == 0)
            {
                using (var pen = new Pen(Color.FromArgb(60, 60, 60), RingThickness))
                {
                    g.DrawEllipse(pen, outerRect);
                }
                return;
            }

            decimal total = 0;
            foreach (var s in Slices) total += s.Value;
            if (total == 0)
            {
                using (var pen = new Pen(Color.FromArgb(60, 60, 60), RingThickness))
                {
                    g.DrawEllipse(pen, outerRect);
                }
                return;
            }

            float startAngle = -90f; // start at top
            const float gapDegrees = 2f; // visual gap between slices

            foreach (var slice in Slices)
            {
                float sweep = (float)(slice.Value / total * 360m);
                if (sweep <= 0) continue;

                // Reduce sweep slightly for gap, but not below zero
                float drawSweep = sweep - gapDegrees;
                if (drawSweep < 0) drawSweep = 0;

                using (var pen = new Pen(slice.Color, RingThickness))
                {
                    g.DrawArc(pen, outerRect, startAngle, drawSweep);
                }

                startAngle += sweep;
            }
        }
    }
}