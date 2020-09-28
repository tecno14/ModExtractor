using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModExtractor
{
    static class Program
    {
        #region Defination

        public static string _FILES_DIR { get { return "_FILES_"; } }
        public static string _UnKnw_DIR { get { return "_UnKnw_"; } }
        public static string _DELETED_FILE { get { return "_DELETED_.TXT"; } }

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
