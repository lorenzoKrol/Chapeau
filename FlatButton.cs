using System.Drawing;
using System.Windows.Forms;

namespace ChapeauStyle {
    public class FlatButton : Button {
        public FlatButton() {
            BackColor = Color.LightGray;

            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;

            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Size = new Size(110, 35);
        }
    }
}
