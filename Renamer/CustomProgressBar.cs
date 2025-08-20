using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renamer
{
    internal class CustomProgressBar : ProgressBar
    {
        public CustomProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var rect = this.ClientRectangle;
            e.Graphics.FillRectangle(SystemBrushes.Control, rect);

            int width = (int)(rect.Width * (Value - Minimum) / (double)(Maximum - Minimum));

            if (width > 0)
                e.Graphics.FillRectangle(new SolidBrush(this.ForeColor), new Rectangle(rect.X, rect.Y, width, rect.Height));

            e.Graphics.DrawRectangle(Pens.Gray, rect.X, rect.Y, rect.Width - 1, rect.Height - 1);
        }
    }
}
