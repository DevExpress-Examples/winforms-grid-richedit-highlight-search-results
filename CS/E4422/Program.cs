using DevExpress.XtraRichEdit;
using System;
using System.Windows.Forms;

namespace E4422 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RichEditControlCompatibility.UseThemeFonts = false;
            Application.Run(new Form1());
        }
    }
}
