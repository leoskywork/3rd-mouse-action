using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        private AutoClicker clicker;
        private Keys hotkey;
        private Win32.fsModifiers hotkeyNodifiers;

        private Thread countdownThread;

        public MainForm()
        {
            InitializeComponent();
        }

 

        private void Form_Load(object sender, EventArgs e)
        {
            clicker = new AutoClicker();
            //LoadSettings();
            ReadFromHubSettings();

            ClickTypeHandler(null, null);
            LocationHandler(null, null);
            DelayHandler(null, null);
            CountHandler(null, null);

            clicker.NextClick += HandleNextClick;
            clicker.Finished += HandleFinished;

            this.SetVersionInfo();


            


            if (Environment.MachineName == "LEO-PC-PRO")
            {
                //this.numRandomX.Value = 952;
                //this.numRandomY.Value = 580;
                //this.numRandomWidth.Value = 90;
                //this.numRandomHeight.Value = 50;

                //this.numCount.Value = 3;
                //this.numDelayRangeMin.Value = 1420;
                //this.numDelayRangeMax.Value = 1999;
            }
        }

        private void HandleNextClick(object sender, AutoClicker.NextClickEventArgs e)
        {
            if (countdownThread != null)
            {
                countdownThread.Abort();
            }

            countdownThread = new Thread(() => CountDown(e.NextClickDelayMS, e.Message));
            countdownThread.Start();
        }

        private void HandleFinished(object sender, EventArgs e)
        {
            EnableControls("done");
        }

        private void CountDown(int Milliseconds, string message)
        {
            //for (int i = 0; i < Milliseconds; i += 10)
            //{
            //tslStatus.Text = string.Format("Next click: {0}ms", Milliseconds - i);
            //Thread.Sleep(9);
            //}

            tslStatus.Text = $"Next click: {Milliseconds}ms, {message}";
        }

        private void ClickTypeHandler(object sender, EventArgs e)
        {
            AutoClicker.ButtonType buttonType;
            bool doubleClick = false;

            if (rdbClickSingleLeft.Checked || rdbClickDoubleLeft.Checked)
            {
                buttonType = AutoClicker.ButtonType.Left;
            }
            else if (rdbClickSingleMiddle.Checked || rdbClickDoubleMiddle.Checked)
            {
                buttonType = AutoClicker.ButtonType.Middle;
            }
            else
            {
                buttonType = AutoClicker.ButtonType.Right;
            }

            if (rdbClickDoubleLeft.Checked || rdbClickDoubleMiddle.Checked || rdbClickDoubleRight.Checked)
            {
                doubleClick = true;
            }

            clicker.UpdateButton(buttonType, doubleClick);
        }

        private void LocationHandler(object sender, EventArgs e)
        {
            AutoClicker.LocationType locationType;
            int x = -1;
            int y = -1;
            int width = -1;
            int height = -1;

            if (rdbLocationFixed.Checked)
            {
                locationType = AutoClicker.LocationType.Fixed;
                x = (int)numFixedX.Value;
                y = (int)numFixedY.Value;
            }
            else if (rdbLocationMouse.Checked)
            {
                locationType = AutoClicker.LocationType.Cursor;
            }
            else if (rdbLocationRandom.Checked)
            {
                locationType = AutoClicker.LocationType.Random;
            }
            else
            {
                locationType = AutoClicker.LocationType.RandomRange;
                x = (int)numRandomX.Value;
                y = (int)numRandomY.Value;
                width = (int)numRandomWidth.Value;
                height = (int)numRandomHeight.Value;
            }

            // Toggle visibility of controls.
            if (locationType == AutoClicker.LocationType.Fixed)
            {
                numFixedX.Enabled = true;
                numFixedY.Enabled = true;
            }
            else
            {
                numFixedX.Enabled = false;
                numFixedY.Enabled = false;
            }

            if (locationType == AutoClicker.LocationType.RandomRange)
            {
                numRandomX.Enabled = true;
                numRandomY.Enabled = true;
                numRandomWidth.Enabled = true;
                numRandomHeight.Enabled = true;
                btnSelect.Enabled = true;
            }
            else
            {
                numRandomX.Enabled = false;
                numRandomY.Enabled = false;
                numRandomWidth.Enabled = false;
                numRandomHeight.Enabled = false;
                btnSelect.Enabled = false;
            }

            clicker.UpdateLocation(locationType, x, y, width, height);
        }

        private void DelayHandler(object sender, EventArgs e)
        {
            AutoClicker.DelayType delayType;
            int delay = -1;
            int delayRange = -1;

            if (rdbDelayFixed.Checked)
            {
                delayType = AutoClicker.DelayType.Fixed;
                delay = (int)numDelayFixed.Value;
            }
            else
            {
                delayType = AutoClicker.DelayType.Range;
                delay = (int)numDelayRangeMin.Value;
                delayRange = (int)numDelayRangeMax.Value;
            }

            // Toggle visibility of controls.
            if (delayType == AutoClicker.DelayType.Fixed)
            {
                numDelayFixed.Enabled = true;
                numDelayRangeMax.Enabled = false;
                numDelayRangeMin.Enabled = false;
            }
            else
            {
                numDelayFixed.Enabled = false;
                numDelayRangeMax.Enabled = true;
                numDelayRangeMin.Enabled = true;
            }

            clicker.UpdateDelay(delayType, delay, delayRange);
        }

        private void CountHandler(object sender, EventArgs e)
        {
            AutoClicker.CountType countType;
            int count = -1;

            if (rdbCount.Checked)
            {
                countType = AutoClicker.CountType.Fixed;
                count = (int)numCount.Value;
            }
            else
            {
                countType = AutoClicker.CountType.UntilStopped;
            }

            // Toggle visibility of controls.
            if (countType == AutoClicker.CountType.Fixed)
            {
                numCount.Enabled = true;
            }
            else
            {
                numCount.Enabled = false;
            }

            clicker.UpdateCount(countType, count);
        }

        private void btnHotkeyRemove_Click(object sender, EventArgs e)
        {
            UnsetHotkey();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            WriteToHubSettings();
            var isWaitingToRun = !clicker.IsAlive;

            if (isWaitingToRun)
            {
                this.tslStatus.Text = $"start click in {GlobalHub.MouseTaskStartDelayMS}ms...";
                Cursor = Cursors.WaitCursor;
            }

            this.RunOnMainAsync(() =>
            {
                Cursor = Cursors.Default;

                if (isWaitingToRun)
                {
                    clicker.Start();
                    DisableControls();
                }
                else
                {
                    clicker.Stop();
                    countdownThread.Abort();
                    EnableControls("task abort");
                }
            }, GlobalHub.MouseTaskStartDelayMS);
        }

    

        delegate void SetEnabledCallback(Control Control, bool Enabled);
        private void SetEnabled(Control Control, bool Enabled)
        {
            if (Control.InvokeRequired)
            {
                var d = new SetEnabledCallback(SetEnabled);
                this.Invoke(d, Control, Enabled);
            }
            else
            {
                Control.Enabled = Enabled;
            }
        }

        delegate void SetButtonTextCallback(Button Control, string Text);
        private void SetButtonText(Button Control, string Text)
        {
            if (Control.InvokeRequired)
            {
                var d = new SetButtonTextCallback(SetButtonText);
                this.Invoke(d, Control, Text);
            }
            else
            {
                Control.Text = Text;
            }
        }

        private void EnableControls(string message)
        {
            tslStatus.Text = message;
            SetEnabled(grpClickType, true);
            SetEnabled(grpLocation, true);
            SetEnabled(grpDelay, true);
            SetEnabled(grpCount, true);
            SetButtonText(btnToggle, "Start");
            //grpClickType.Enabled = true;
            //grpLocation.Enabled = true;
            //grpDelay.Enabled = true;
            //grpCount.Enabled = true;
            //btnToggle.Text = "Start";

            this.RunOnMainAsync(() =>
            {
                this.groupBoxOpenGameReward.Enabled = true;
            });
        }

        private void DisableControls()
        {
            SetEnabled(grpClickType, false);
            SetEnabled(grpLocation, false);
            SetEnabled(grpDelay, false);
            SetEnabled(grpCount, false);
            SetButtonText(btnToggle, "Stop");
            //grpClickType.Enabled = false;
            //grpLocation.Enabled = false;
            //grpDelay.Enabled = false;
            //grpCount.Enabled = false;
            //btnToggle.Text = "Stop";

            this.RunOnMainAsync(() =>
            {
                this.groupBoxOpenGameReward.Enabled = false;
            });
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == Win32.WM_HOTKEY)
            {
                // Ignore the hotkey if the user is editing it.
                if (txtHotkey.Focused)
                {
                    return;
                }

                Win32.fsModifiers modifiers = (Win32.fsModifiers)((int)m.LParam & 0xFFFF);
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                if (key == (hotkey & Keys.KeyCode) && modifiers == hotkeyNodifiers)
                {
                    btnToggle_Click(null, null);
                }
            }
        }

        private void txtHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            // Don't want to do anything if only a modifier key is pressed.
            //     Modifiers                                 Asian keys (kana, hanja, kanji etc)       IME related keys (convert etc)           Korean alt (process)  Windows keys
            if (!((e.KeyValue >= 16 && e.KeyValue <= 18) || (e.KeyValue >= 21 && e.KeyValue <= 25) || (e.KeyValue >= 28 && e.KeyValue <= 31) || e.KeyValue == 229 || (e.KeyValue >= 91 && e.KeyValue <= 92)))
            {
                Win32.UnregisterHotKey(this.Handle, (int)hotkey);
                hotkey = e.KeyData;
                // Extract modifiers
                hotkeyNodifiers = 0;
                if ((e.Modifiers & Keys.Shift) != 0)
                {
                    hotkeyNodifiers |= Win32.fsModifiers.Shift;
                }
                if ((e.Modifiers & Keys.Control) != 0)
                {
                    hotkeyNodifiers |= Win32.fsModifiers.Control;
                }
                if ((e.Modifiers & Keys.Alt) != 0)
                {
                    hotkeyNodifiers |= Win32.fsModifiers.Alt;
                }

                SetHotkey();
            }
        }

        private void SetHotkey()
        {
            txtHotkey.Text = KeysConverter.Convert(hotkey);
            Win32.RegisterHotKey(this.Handle, (int)hotkey, (uint)hotkeyNodifiers, (uint)(hotkey & Keys.KeyCode));
            btnHotkeyRemove.Enabled = true;
        }

        private void UnsetHotkey()
        {
            Win32.UnregisterHotKey(this.Handle, (int)hotkey);
            btnHotkeyRemove.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SaveSettings();
            WriteToHubSettings();
        }


        private void ReadFromHubSettings()
        {
            this.numRandomX.Value = GlobalHub.Default.RandomAreaPointX;
            this.numRandomY.Value = GlobalHub.Default.RandomAreaPointY;
            this.numRandomWidth.Value = GlobalHub.Default.RandomAreaSizeWidth;
            this.numRandomHeight.Value = GlobalHub.Default.RandomAreaSizeHeight;
            this.numCount.Value = GlobalHub.Default.FixedClickCount;
            this.numDelayRangeMin.Value = GlobalHub.Default.NextClickDelayMinMS;
            this.numDelayRangeMax.Value = GlobalHub.Default.NextClickDelayMaxMS;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(GlobalHub.Default.LastCloseLocationX, GlobalHub.Default.LastCloseLocationY);
            this.numericUpDownGameBoxGap.Value = GlobalHub.Default.GameRewardBoxGap;
            this.numericUpDownWheelRoll.Value = GlobalHub.Default.GameRewardWheelRollValue;
            this.numericUpDownTaskUnitCount.Value = GlobalHub.Default.GameRewardTaskUnitCount;
            this.numericUpDownRollDelayMin.Value = GlobalHub.Default.AfterWheelRollDelayMinMS;
            this.numericUpDownRollDelayMax.Value = GlobalHub.Default.AfterWheelRollDelayMaxMS;
        }

        private void WriteToHubSettings()
        {
            GlobalHub.Default.RandomAreaPointX = (int)this.numRandomX.Value;
            GlobalHub.Default.RandomAreaPointY = (int)this.numRandomY.Value;
            GlobalHub.Default.RandomAreaSizeWidth = (int)this.numRandomWidth.Value;
            GlobalHub.Default.RandomAreaSizeHeight = (int)this.numRandomHeight.Value;
            GlobalHub.Default.FixedClickCount = (int)this.numCount.Value;
            GlobalHub.Default.NextClickDelayMinMS = (int)this.numDelayRangeMin.Value;
            GlobalHub.Default.NextClickDelayMaxMS = (int)this.numDelayRangeMax.Value;
            GlobalHub.Default.LastCloseLocationX = this.Location.X;
            GlobalHub.Default.LastCloseLocationY = this.Location.Y;
            GlobalHub.Default.GameRewardBoxGap = (int)this.numericUpDownGameBoxGap.Value;
            GlobalHub.Default.GameRewardWheelRollValue = (int)this.numericUpDownWheelRoll.Value;
            GlobalHub.Default.GameRewardTaskUnitCount = (int)this.numericUpDownTaskUnitCount.Value;
            GlobalHub.Default.AfterWheelRollDelayMinMS = (int)this.numericUpDownRollDelayMin.Value;
            GlobalHub.Default.AfterWheelRollDelayMaxMS = (int)this.numericUpDownRollDelayMax.Value;
        }



        public void SendRectangle(int X, int Y, int Width, int Height)
        {
            numRandomX.Value = X;
            numRandomY.Value = Y;
            numRandomWidth.Value = Width;
            numRandomHeight.Value = Height;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var form = new SelectionForm(this);
            form.Show();
        }
    }
}
