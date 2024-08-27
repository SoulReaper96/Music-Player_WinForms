using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp_Forms
{
    internal class CustomButtons : Button
    {
        // Corner radius property
        private int cornerRadius = 30;
        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                this.Invalidate(); // Redraw the button when the radius is changed
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Create a rounded rectangle path
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            graphicsPath.AddArc(this.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            graphicsPath.AddArc(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            graphicsPath.AddArc(0, this.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            graphicsPath.CloseFigure();

            // Set the button region to the rounded rectangle
            this.Region = new Region(graphicsPath);

            // Draw the button background
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Brush brush = new SolidBrush(Color.Yellow))
            {
                pevent.Graphics.FillPath(brush, graphicsPath);
            }

            // Draw the button border
            using (Pen pen = new Pen(Color.Black, 2))
            {
                pevent.Graphics.DrawPath(pen, graphicsPath);
            }

            // Draw the button text
            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); // Redraw the button when resized
        }
    }
}
