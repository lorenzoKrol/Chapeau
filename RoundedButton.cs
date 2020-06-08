using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ChapeauStyle {
    public class RoundedButton : FlatButton {
        public int Radius { get; set; }

        protected override void OnPaint(PaintEventArgs pevent) {
            int top = 0;
            int left = 0;
            int right = Width;
            int bottom = Height;

            base.OnPaint(pevent);

            // Round the corners of the rectangle

            GraphicsPath graphics = new GraphicsPath();

            graphics.AddArc(left, top, Radius, Radius, 180, 90);
            graphics.AddArc(right - Radius, top, Radius, Radius, 270, 90);
            graphics.AddArc(right - Radius, bottom - Radius, Radius, Radius, 0, 90);
            graphics.AddArc(left, bottom - Radius, Radius, Radius, 90, 90);

            graphics.CloseAllFigures();

            Region = new Region(graphics);
        }
    }
}

