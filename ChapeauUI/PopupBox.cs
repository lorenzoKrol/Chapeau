using System.Windows.Forms;

namespace ChapeauUI {
    public partial class PopupBox : Form {
        public PopupBox(MessageBoxButtons buttons) {
            InitializeComponent();

            if (buttons == MessageBoxButtons.OK)
                btnCancel.Hide();
        }

        public DialogResult Show(string text) {
            lblText.Text = text;
            return ShowDialog();
        }

        private void btnOK_Click(object sender, System.EventArgs e) {
            Hide();
        }

        private void btnCancel_Click(object sender, System.EventArgs e) {
            Hide();
        }
    }
}
