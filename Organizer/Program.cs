using System;
using System.Windows.Forms;

namespace Organizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormB());           
        }

        public struct DataBase
        {
            public string date;
            public string time;
            public string text;
            public string type;
        }

        public static DataBase[] value = new DataBase[10];

        public static string time;
        public static bool flagLogin = true;
        public static bool flagExit = false;

    }
}
