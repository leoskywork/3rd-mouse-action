using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
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

            ReadAppConfig();

            var firstView = new MainForm();
            firstView.FormClosed += (_, __) => WriteAppConfig();

            Application.Run(firstView);
        }

        private static void ReadAppConfig()
        {
            GlobalHub.Default.IsDebugging = Properties.Settings.Default.IsDebugging;
            GlobalHub.Default.EnableLogToFile = Properties.Settings.Default.EnableLogToFile;

            GlobalHub.Default.RandomAreaPointX = Properties.Settings.Default.RandomAreaPoint.X;
            GlobalHub.Default.RandomAreaPointY = Properties.Settings.Default.RandomAreaPoint.Y;
            GlobalHub.Default.RandomAreaSizeWidth = Properties.Settings.Default.RandomAreaSize.Width;
            GlobalHub.Default.RandomAreaSizeHeight = Properties.Settings.Default.RandomAreaSize.Height;

            GlobalHub.Default.FixedClickCount = Properties.Settings.Default.FixedClickCount;

            GlobalHub.Default.NextClickDelayMinMS = Properties.Settings.Default.NextClickDelayMinMS;
            GlobalHub.Default.NextClickDelayMaxMS = Properties.Settings.Default.NextClickDelayMaxMS;
            GlobalHub.Default.AfterWheelRollDelayMinMS = Properties.Settings.Default.AfterWheelRollDelayMinMS;
            GlobalHub.Default.AfterWheelRollDelayMaxMS = Properties.Settings.Default.AfterWheelRollDelayMaxMS; 
            
        }

        private static void WriteAppConfig()
        {
            try
            {
                Properties.Settings.Default.IsDebugging = GlobalHub.Default.IsDebugging;
                Properties.Settings.Default.EnableLogToFile = GlobalHub.Default.EnableLogToFile;

                Properties.Settings.Default.RandomAreaPoint = new System.Drawing.Point(GlobalHub.Default.RandomAreaPointX, GlobalHub.Default.RandomAreaPointY);
                Properties.Settings.Default.RandomAreaSize = new System.Drawing.Size(GlobalHub.Default.RandomAreaSizeWidth, GlobalHub.Default.RandomAreaSizeHeight);

                Properties.Settings.Default.FixedClickCount = GlobalHub.Default.FixedClickCount;

                Properties.Settings.Default.NextClickDelayMinMS = GlobalHub.Default.NextClickDelayMinMS;
                Properties.Settings.Default.NextClickDelayMaxMS = GlobalHub.Default.NextClickDelayMaxMS;
                Properties.Settings.Default.AfterWheelRollDelayMinMS = GlobalHub.Default.AfterWheelRollDelayMinMS;
                Properties.Settings.Default.AfterWheelRollDelayMaxMS = GlobalHub.Default.AfterWheelRollDelayMaxMS;


                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

    }
}
