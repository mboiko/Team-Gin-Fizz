namespace TheGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using TheGame.Classes.Actions;

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
            Application.Run(new Login());

            List<List<Quest>> missions = new List<List<Quest>>()
            {
                new List<Quest>()
                {
                    new Quest("C# Programing - Part I", "To complete this mission you have to pass all submissions", ActionType.Primary, 0, 0, false),
                    new Quest("Primitive data types and variables", "Submission of C# Programing - Part I", ActionType.Secondary, 20, 20, false),
                    new Quest("Operators and Expressions", "Submission of C# Programing - Part I", ActionType.Secondary, 20, 20, false),
                    new Quest("Console Input / Output", "Submission of C# Programing - Part I", ActionType.Secondary, 20, 20, false),
                    new Quest("Conditional Statements", "Submission of C# Programing - Part I", ActionType.Secondary, 20, 20, false),
                    new Quest("Team Work Project", "If you pass this mission you may won a present. This mission is not obligatory.", ActionType.Bonus, 25, 25, false),
                    new Quest("Loops", "Submission of C# Programing - Part I", ActionType.Secondary, 20, 20, false),
                    new Quest("The Exam", "This is the last submission of C# Programing - Part I", ActionType.Secondary, 50, 50, false),
                },

                new List<Quest>()
                {
                    new Quest("C# Programing - Part II", "To complete this mission you have to pass all submissions", ActionType.Primary, 0, 0, false),
                    new Quest("Arrays", "Submission of C# Programing - Part II", ActionType.Secondary, 22, 22, false),
                    new Quest("Matrix and Multidimensional arrays", "Submission of C# Programing - Part II", ActionType.Secondary, 22, 22, false),
                    new Quest("Methods", "Submission of C# Programing - Part II", ActionType.Secondary, 22, 22, false),
                    new Quest("Numeral Systems", "Submission of C# Programing - Part II", ActionType.Secondary, 22, 22, false),
                    new Quest("Using Classes and Objects", "Submission of C# Programing - Part II", ActionType.Secondary, 22, 22, false),
                    new Quest("Text files", "Submission of C# Programing - Part II", ActionType.Secondary, 22, 22, false),
                    new Quest("Exception Handling", "Submission of C# Programing - Part II", ActionType.Secondary, 22, 22, false),
                    new Quest("Strings and Text processing", "Submission of C# Programing - Part II", ActionType.Secondary, 22, 22, false),
                    new Quest("Team Work Project", "If you pass this mission you may won a present. This mission is not obligatory.", ActionType.Bonus, 30, 30, false),
                    new Quest("The Exam", "This is the last submission of C# Programing - Part II", ActionType.Secondary, 50, 50, false),
                },

                new List<Quest>()
                {
                    new Quest("Object Oriented Programming - \"OOP\"", "To complete this mission you have to pass all submissions", ActionType.Primary, 0, 0, false),
                    new Quest("Defining Classes – Part I", "Submission of OOP", ActionType.Secondary, 28, 28, false),
                    new Quest("Defining Classes – Part II", "Submission of OOP", ActionType.Secondary, 28, 28, false),
                    new Quest("Extension Methods, Lambda Expressions and LINQ", "Submission of OOP", ActionType.Secondary, 28, 28, false),
                    new Quest("Object-Oriented Programming Fundamental Principles – Part I", "Submission of OOP", ActionType.Secondary, 28, 28, false),
                    new Quest("Object-Oriented Programming Fundamental Principles – Part II", "Submission of OOP", ActionType.Secondary, 28, 28, false),
                    new Quest("Common Type System", "Submission of OOP", ActionType.Secondary, 28, 28, false),
                    new Quest("Team Work Project", "If you pass this mission you may won a present. This mission is not obligatory.", ActionType.Bonus, 30, 30, false),
                    new Quest("The Exam", "This is the last submission of C# Programing - Part II", ActionType.Secondary, 50, 50, false),
                }
            };
        }
    }
}
