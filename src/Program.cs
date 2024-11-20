using System;


namespace pdf_tools {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {

            Form form = new FormSendColorToFront();
            form.ShowDialog();
        }
    }
}