using System;
using System.Windows.Forms;

namespace ChapeauUI {
    internal static class Program {
        // SQL delete order item, delete order items referencing order

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
