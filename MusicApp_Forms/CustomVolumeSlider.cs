using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp_Forms
{
    public partial class CustomVolumeSlider : UserControl
    {
        private int _value;
        private int _minimum = 0;
        private int _maximum = 100;
        private bool _isDragging = false;

        public int Value
        {
            get { return _value; }
            set
            {
                if (value < _minimum || value > _maximum)
                    throw new ArgumentOutOfRangeException();
                _value = value;
                Invalidate();
            }
        }

        public int Minimum
        {
            get { return _minimum; }
            set
            {
                _minimum = value;
                Invalidate();
            }
        }

        public int Maximum
        {
            get { return _maximum; }
            set
            {
                _maximum = value;
                Invalidate();
            }
        }

        public CustomVolumeSlider()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.Width = 200;
            this.Height = 30;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw the track
            Rectangle trackRect = new Rectangle(10, this.Height / 2 - 2, this.Width - 20, 4);
            g.FillRectangle(Brushes.LightGray, trackRect);

            // Draw the thumb
            int thumbX = 10 + (int)((this.Width - 20) * ((double)(_value - _minimum) / (_maximum - _minimum)));
            Rectangle thumbRect = new Rectangle(thumbX - 10, this.Height / 2 - 10, 20, 20);
            g.FillEllipse(Brushes.DodgerBlue, thumbRect);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = true;
                UpdateValueFromMouse(e.X);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_isDragging)
            {
                UpdateValueFromMouse(e.X);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = false;
            }
        }

        private void UpdateValueFromMouse(int mouseX)
        {
            int trackWidth = this.Width - 20;
            int newValue = _minimum + (int)((_maximum - _minimum) * ((double)(mouseX - 10) / trackWidth));
            newValue = Math.Max(_minimum, Math.Min(_maximum, newValue));
            if (newValue != _value)
            {
                _value = newValue;
                Invalidate();
                OnValueChanged(EventArgs.Empty);
            }
        }

        public event EventHandler ValueChanged;

        protected virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }
    }
}
