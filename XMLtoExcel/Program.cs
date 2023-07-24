using System;
using System.Windows.Forms;
using XMLtoExcel.Forms;

namespace XMLtoExcel
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

            //TODO: убрать после сдачи проекта.
            if (DateTime.Now > new DateTime(2023, 07, 28))
            {
                Environment.Exit(0);
            }

            Application.Run(new MainForm());
        }
    }
}
