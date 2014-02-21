namespace TheGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    static class Program
    {
        public static int GetRandomNumber(int min, int max)
        {
            Random randomInt = new Random();
            return randomInt.Next(min, max + 1);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
