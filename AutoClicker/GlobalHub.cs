using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public class GlobalHub
    {
        public const string Version = "1.0";
        public const string Subversion = "2";
        public const string AppName = "MAM";
        public static DateTime ExeCreateDate = DateTime.MinValue;
        public static DateTime ExeUpdateDate = DateTime.MinValue;

        public const int TmpFileMaxCount = 5;
        public const int TmpLogFileMaxCount = 200;

        public const int MouseTaskStartDelayMS = 2000;// 1000;//2000;
        //public const int TaskUnitCount = 3;
        //public const int MouseScrollValue = -400;//-200; //up or down


        public event EventHandler CloseApp;

        public static GlobalHub Default { get; } = new GlobalHub();
        public bool EnableLogToFile { get; set; }
        public bool IsDebugging { get; set; }


        public int RandomAreaPointX { get; set; }
        public int RandomAreaPointY { get; set; }
        public int RandomAreaSizeWidth { get; set; }
        public int RandomAreaSizeHeight { get; set; }

        public int FixedClickCount { get; set; }

        public int NextClickDelayMinMS { get; set; }
        public int NextClickDelayMaxMS { get; set; }
        public int AfterWheelRollDelayMinMS { get; set; }
        public int AfterWheelRollDelayMaxMS { get; set; }

        public int LastCloseLocationX { get; set; }
        public int LastCloseLocationY { get; set; }

        public int GameRewardBoxGap { get; set; }

        public int GameRewardWheelRollValue { get; set; }

        public int GameRewardTaskUnitCount { get; set; }

       

        private GlobalHub()
        {

        }

        public void FireCloseApp()
        {
            CloseApp?.Invoke(null, null);
        }
    }


    public static class FormLEOExt
    {
        public const int DisableControlDelayMS = 220;
        public const int SelectControlDelayMS = 300;
        public const int DisableControlDelayLittleMS = 100;

        public static void OnError(this Form form, Exception e)
        {
            string message;

            if (GlobalHub.Default.IsDebugging)
            {
                message = GetAggregateMessage(e, true);
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
            else
            {
                message = GetAggregateMessage(e, false);
            }

            form.RunOnMain(() => MessageBox.Show(message));
            form.RunOnMain(() => GlobalHub.Default.FireCloseApp(), 1000);
        }

        public static string GetAggregateMessage(Exception e, bool hasDetail)
        {
            var ae = e as AggregateException;

            if (ae != null)
            {
                return $"Multi errors: {(hasDetail ? string.Join(",", ae.InnerExceptions) : string.Join(",", ae.InnerExceptions.Select(aei => aei.Message)))}";
            }
            else
            {
                return hasDetail ? e.ToString() : e.Message;
            }
        }


        public static bool IsDeadExt(this Form form)
        {
            return form.Disposing || form.IsDisposed;
        }

        public static void RunOnMain(this Form form, Action action)
        {
            if (action == null) return;
            if (form.IsDeadExt()) return;

            //System.Diagnostics.Debug.WriteLine($"RunOnMain - is dead: {form.IsDead()}, disp: {form.Disposing}, disped:{form.IsDisposed} - before if");
            if (form.InvokeRequired)
            {
                if (form.IsDeadExt()) return; //not sure why, the is dead check above not working sometimes, do it again here
                if (form.Disposing || form.IsDisposed) return;
                //System.Diagnostics.Debug.WriteLine($"RunOnMain - is dead: {form.IsDead()}, disp: {form.Disposing}, disped:{form.IsDisposed}");
                form.Invoke(action);
            }
            else
            {
                action();
            }
        }

        public static void RunOnMain(this Form form, Action action, int delayMS)
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(delayMS);
                RunOnMain(form, action);
            });
        }

        public static void RunOnMainAsync(this Form form, Action action)
        {
            if (action == null) return;
            if (form.IsDeadExt()) return;

            if (form.InvokeRequired)
            {
                form.BeginInvoke(action);
            }
            else
            {
                action();
            }
        }

        public static void RunOnMainAsync(this Form form, Action action, int delayMS)
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(delayMS);
                RunOnMainAsync(form, action);
            });
        }


        public static void DisableLabelShorterTime(this Form form, Label control)
        {
            DisableLabelWithTime(form, control, DisableControlDelayLittleMS);
        }


        public static void DisableLabelShortTime(this Form form, Label control)
        {
            DisableLabelWithTime(form, control, DisableControlDelayMS);
        }

        public static void DisableLabelWithTime(this Form form, Label control, int delayMS)
        {
            var oldForeColor = control.ForeColor;
            var oldBackColor = control.BackColor;


            control.ForeColor = System.Drawing.Color.White;
            control.BackColor = System.Drawing.Color.LightGray;
            control.Enabled = false;

            form.RunOnMain(() =>
            {
                control.ForeColor = oldForeColor;
                control.BackColor = oldBackColor;
                control.Enabled = true;
            }, delayMS);
        }

        public static void DisableButtonShortTime(this Form form, Button control)
        {
            DisableButtonWithTime(form, control, DisableControlDelayMS);
        }

        public static void DisableButtonWithTime(this Form form, Button control, int intervalMS)
        {
            var oldForeColor = control.ForeColor;
            var oldBackColor = control.BackColor;

            //leotodo, tmp fix for action bar, or else only the first click will work, and button become disabled forever
            //is this caused by the transparent background/color ?
            oldForeColor = System.Drawing.Color.Black;
            oldBackColor = System.Drawing.Color.White;


            control.ForeColor = System.Drawing.Color.White;
            control.BackColor = System.Drawing.Color.LightGray;
            control.Enabled = false;

            form.RunOnMainAsync(() =>
            {
                control.ForeColor = oldForeColor;
                control.BackColor = oldBackColor;
                control.Enabled = true;
            }, intervalMS);
        }





        public static void SetVersionInfo(this Form form)
        {
            form.Text = $"{GlobalHub.AppName}-V{GlobalHub.Version}.{GlobalHub.Subversion}";
        }

    }
}
