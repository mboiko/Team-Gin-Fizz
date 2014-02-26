namespace TheGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using TheGame.Classes.Actions;
    using TheGame.Classes.Items;
    using TheGame.Classes.Characters;
    using TheGame.Classes;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Equipment> equipments = Parser.GetAllEquipments();

            equipments[0].Compare(equipments[1]);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
