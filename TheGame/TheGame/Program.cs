﻿namespace TheGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using TheGame.Classes.Actions;
    using TheGame.Classes.Items;
    using TheGame.Classes;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Skill> someSkills = TheGame.Parser.GetAllSkills();

            List<Item> someitem = TheGame.Parser.GetAllConsumableItems();

            List<Equipment> equipments = TheGame.Parser.GetAllEquipments();

            List<Quest> quests = TheGame.Parser.GetAllQuests();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
