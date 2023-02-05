using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EasyReservator
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string[] args = System.Environment.GetCommandLineArgs();
            if (args.Count() > 1)
            {
                if (args.Contains("-hide"))
                {
                    foreach (string arg in args)
                    {
                        if (arg == "-hide")
                        {
                            MainForm mf = new MainForm();
                            mf.HidedConsolas(args);
                        }
                    }
                }
                else
                {
                    Application.Run(new MainForm(args));
                }
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}
