using System.Drawing;
using System.Windows.Forms;

namespace ChapeauStyle {
    public class MainLabel : Label {
        public MainLabel() {
            // Change names, generalise as much as possible, panel with top always the same (menu bar)

            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Size = new Size(50, 20);
        }
    }
}
