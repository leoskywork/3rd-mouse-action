using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
    class AutoClicker
    {
        #region "Button"
        public enum ButtonType
        {
            Left,
            Middle,
            Right
        }

        private ButtonType buttonType;
        private bool doubleClick;
        #endregion

        #region "Location"
        public enum LocationType
        {
            Cursor,
            Fixed,
            Random,
            RandomRange
        }

        private LocationType locationType;
        private int x;
        private int y;
        private int width;
        private int height;
        #endregion

        #region "Delay"
        public enum DelayType
        {
            Fixed,
            Range
        }

        private DelayType delayType;
        private int delay;
        private int delayRange;
        #endregion

        #region "Count"
        public enum CountType
        {
            Fixed,
            UntilStopped
        }

        private CountType countType;
        private int count;
        #endregion

        #region "Update storage"
        private bool buttonUpdated;
        private ButtonType tmpButtonType;
        private bool tmpDoubleClick;

        private bool locationUpdated;
        private LocationType tmpLocationType;
        private int tmpX;
        private int tmpY;
        private int tmpWidth;
        private int tmpHeight;

        private bool delayUpdated;
        private DelayType tmpDelayType;
        private int tmpDelay;
        private int tmpDelayRange;

        private bool countUpdated;
        private CountType tmpCountType;
        private int tmpCount;
        #endregion

        Thread Clicker;
        Random rnd;

        public AutoClicker()
        {
            rnd = new Random();
        }

        public class ProgressReportEventArgs : EventArgs
        {
            public int NextTaskDelayMS;
            public string Message;
        }

        public event EventHandler<ProgressReportEventArgs> ProgressReport;

        public EventHandler<EventArgs> Finished;

        private void Click()
        {
            //System.Diagnostics.Debug.Print("Click() started");
            SyncSettings();
            int remaining = count;
            int doneClickCount = 0;
            //System.Diagnostics.Debug.Print("Count type: {0}, count: {1}", countType, count);
            while (countType == CountType.UntilStopped || remaining > 0)
            {
                if (!IsAlive)
                    return;
                SyncSettings();
                List<Win32.INPUT> inputs = new List<Win32.INPUT>();

                // Move the mouse if required.
                if (locationType == LocationType.Fixed)
                {
                    Win32.INPUT input = new Win32.INPUT
                    {
                        type = Win32.SendInputEventType.InputMouse,
                        mi = new Win32.MOUSEINPUT
                        {
                            dx = Win32.CalculateAbsoluteCoordinateX(x),
                            dy = Win32.CalculateAbsoluteCoordinateX(y),
                            dwFlags = Win32.MouseEventFlags.Move | Win32.MouseEventFlags.Absolute
                        }
                    };
                    inputs.Add(input);
                }
                else if (locationType == LocationType.Random)
                {
                    Win32.INPUT input = new Win32.INPUT
                    {
                        type = Win32.SendInputEventType.InputMouse,
                        mi = new Win32.MOUSEINPUT
                        {
                            dx = rnd.Next(65536),
                            dy = rnd.Next(65536),
                            dwFlags = Win32.MouseEventFlags.Move | Win32.MouseEventFlags.Absolute
                        }
                    };
                    inputs.Add(input);
                }
                else if (locationType == LocationType.RandomRange)
                {
                    Win32.INPUT input = new Win32.INPUT
                    {
                        type = Win32.SendInputEventType.InputMouse,
                        mi = new Win32.MOUSEINPUT
                        {
                            dx = Win32.CalculateAbsoluteCoordinateX(rnd.Next(x, x + width)),
                            dy = Win32.CalculateAbsoluteCoordinateY(rnd.Next(y, y + height)),
                            dwFlags = Win32.MouseEventFlags.Move | Win32.MouseEventFlags.Absolute
                        }
                    };
                    inputs.Add(input);
                }
                //System.Diagnostics.Debug.Print("Move command added");

                // マウスをクリック
                for (int i = 0; i < (doubleClick ? 2 : 1); i++)
                {
                    // Add a delay if it's a double click.
                    if (i == 1)
                    {
                        Thread.Sleep(50);
                    }

                    if (buttonType == ButtonType.Left)
                    {
                        Win32.INPUT inputDown = new Win32.INPUT
                        {
                            type = Win32.SendInputEventType.InputMouse,
                            mi = new Win32.MOUSEINPUT
                            {
                                dwFlags = Win32.MouseEventFlags.LeftDown
                            }
                        };
                        inputs.Add(inputDown);
                        Win32.INPUT inputUp = new Win32.INPUT
                        {
                            type = Win32.SendInputEventType.InputMouse,
                            mi = new Win32.MOUSEINPUT
                            {
                                dwFlags = Win32.MouseEventFlags.LeftUp
                            }
                        };
                        inputs.Add(inputUp);
                    }

                    if (buttonType == ButtonType.Middle)
                    {
                        Win32.INPUT inputDown = new Win32.INPUT
                        {
                            type = Win32.SendInputEventType.InputMouse,
                            mi = new Win32.MOUSEINPUT
                            {
                                dwFlags = Win32.MouseEventFlags.MiddleDown
                            }
                        };
                        inputs.Add(inputDown);
                        Win32.INPUT inputUp = new Win32.INPUT
                        {
                            type = Win32.SendInputEventType.InputMouse,
                            mi = new Win32.MOUSEINPUT
                            {
                                dwFlags = Win32.MouseEventFlags.MiddleUp
                            }
                        };
                        inputs.Add(inputUp);
                    }

                    if (buttonType == ButtonType.Right)
                    {
                        Win32.INPUT inputDown = new Win32.INPUT
                        {
                            type = Win32.SendInputEventType.InputMouse,
                            mi = new Win32.MOUSEINPUT
                            {
                                dwFlags = Win32.MouseEventFlags.RightDown
                            }
                        };
                        inputs.Add(inputDown);
                        Win32.INPUT inputUp = new Win32.INPUT
                        {
                            type = Win32.SendInputEventType.InputMouse,
                            mi = new Win32.MOUSEINPUT
                            {
                                dwFlags = Win32.MouseEventFlags.RightUp
                            }
                        };
                        inputs.Add(inputUp);
                    }
                }
                //System.Diagnostics.Debug.Print("Click commands added");

                //INPUT[] input = new INPUT[2];
                //input[0].mi.dwFlags = Win32.MOUSEEVENTF_LEFTDOWN;
                //input[1].mi.dwFlags = Win32.MOUSEEVENTF_LEFTUP;
                //Win32.SendInput(2, input, Marshal.SizeOf(input[0]));
                Win32.SendInput((uint)inputs.Count, inputs.ToArray(), Marshal.SizeOf(new Win32.INPUT()));
                //System.Diagnostics.Debug.Print("Command sent");

                // ちょっと寝る
                int nextDelay = 0;
                if (delayType == DelayType.Fixed)
                {
                    nextDelay = delay;

                }
                else
                {
                    nextDelay = rnd.Next(delay, delayRange);
                }
                ProgressReport?.Invoke(this, new ProgressReportEventArgs { NextTaskDelayMS = nextDelay });
                Thread.Sleep(nextDelay);
                //System.Diagnostics.Debug.Print("Had a nap");
                remaining--;
                doneClickCount++;

                if (doneClickCount % GlobalHub.Default.GameRewardTaskUnitCount == 0)
                {
                    ScrollMouseMiddleWheel(doneClickCount, remaining);
                }
            }
            Finished?.Invoke(this, null);
        }

        private void ClickToOpenGameRewardBoxes()
        {
            //open button 952,580 90x50
            //3 height with space: ~380, one space: ~120/124
            //one button height + one space: ~174

            SyncSettings();
            int remaining = count;
            int doneClickCount = 0;
            List<Win32.INPUT> inputs = new List<Win32.INPUT>();

            while (remaining > 0)
            {
                if (!IsAlive) return;
                SyncSettings();

                int offsetY = GlobalHub.Default.GameRewardTaskUnitCount == 0 ? 0 :  GlobalHub.Default.GameRewardBoxGap * (doneClickCount % GlobalHub.Default.GameRewardTaskUnitCount);
                int adjustY = y + offsetY;

                if (locationType == LocationType.RandomRange)
                {
                    var randX = rnd.Next(x, x + width);
                    var randY = rnd.Next(adjustY, adjustY + height);

                    Win32.INPUT input = new Win32.INPUT
                    {
                        type = Win32.SendInputEventType.InputMouse,
                        mi = new Win32.MOUSEINPUT
                        {
                            dx = Win32.CalculateAbsoluteCoordinateX(randX),
                            dy = Win32.CalculateAbsoluteCoordinateY(randY),
                            dwFlags = Win32.MouseEventFlags.Move | Win32.MouseEventFlags.Absolute
                        }
                    };
                    inputs.Add(input);
                    System.Diagnostics.Debug.WriteLine($"move to {x},{adjustY} - {randX},{randY} - {input.mi.dx},{input.mi.dy}");
                }
                else throw new NotSupportedException();

                if (GlobalHub.Default.GameRewardTaskUnitCount > 0)
                {
                    for (int i = 0; i < (doubleClick ? 2 : 1); i++)
                    {
                        // Add a delay if it's a double click.
                        if (i == 1)
                        {
                            Thread.Sleep(50 + rnd.Next(10, 90));
                        }

                        if (buttonType == ButtonType.Left)
                        {
                            Win32.INPUT inputDown = new Win32.INPUT
                            {
                                type = Win32.SendInputEventType.InputMouse,
                                mi = new Win32.MOUSEINPUT { dwFlags = Win32.MouseEventFlags.LeftDown }
                            };
                            inputs.Add(inputDown);
                            Win32.INPUT inputUp = new Win32.INPUT
                            {
                                type = Win32.SendInputEventType.InputMouse,
                                mi = new Win32.MOUSEINPUT { dwFlags = Win32.MouseEventFlags.LeftUp }
                            };
                            inputs.Add(inputUp);
                        }
                        else throw new NotSupportedException();
                    }
                }

                Win32.SendInput((uint)inputs.Count, inputs.ToArray(), Marshal.SizeOf(new Win32.INPUT()));

                remaining--;
                doneClickCount++;
                inputs.Clear();

                if (remaining > 0)
                {
                    if (GlobalHub.Default.GameRewardTaskUnitCount > 0)
                    {
                        int nextDelay = rnd.Next(delay, delayRange);
                        ProgressReportInternal(nextDelay, $"next click no. #{doneClickCount + 1}");
                        Thread.Sleep(nextDelay);
                    }

                    if (GlobalHub.Default.GameRewardTaskUnitCount == 0 || doneClickCount % GlobalHub.Default.GameRewardTaskUnitCount == 0)
                    {
                        ScrollMouseMiddleWheel(doneClickCount, remaining);
                    }
                }
            }

            Finished?.Invoke(this, null);
        }

        private void ScrollMouseMiddleWheel(int doneClickCount, int remaining)
        {
            var rollValue = GlobalHub.Default.GameRewardWheelRollValue;
            System.Diagnostics.Debug.WriteLine($"scroll({rollValue}) going to start, click done #{doneClickCount}, remaining #{remaining}");
            Win32.ScrollWheel(rollValue);

            if (remaining > 0)
            {
                var min = GlobalHub.Default.AfterWheelRollDelayMinMS;
                var max = GlobalHub.Default.AfterWheelRollDelayMaxMS;

                var delayMS = max > min ?  rnd.Next(min, max) : min;
                System.Diagnostics.Debug.WriteLine($"scroll done, going to sleep {delayMS}ms");
                ProgressReportInternal(delayMS, $"next roll after click no. #{doneClickCount + 1}");
                Thread.Sleep(delayMS);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"scroll done, no following task");
            }
        }

        private void ProgressReportInternal(int delayMS, string message)
        {
            ProgressReport?.Invoke(this, new ProgressReportEventArgs { NextTaskDelayMS = delayMS, Message = message });
        }

        public bool IsAlive
        {
            get
            {
                if (Clicker == null)
                {
                    return false;
                }
                return Clicker.IsAlive;
            }
        }

        public void Start()
        {
            //Clicker = new Thread(Click);
            Clicker = new Thread(ClickToOpenGameRewardBoxes);
            Clicker.IsBackground = true;
            Clicker.Start();
        }

        public void Stop()
        {
            if (Clicker != null)
            {
                Clicker.Abort();
            }
        }

        private void SyncSettings()
        {
            if (buttonUpdated)
            {
                buttonType = tmpButtonType;
                doubleClick = tmpDoubleClick;

                buttonUpdated = false;
            }

            if (locationUpdated)
            {
                locationType = tmpLocationType;
                x = tmpX;
                y = tmpY;
                width = tmpWidth;
                height = tmpHeight;

                locationUpdated = false;
            }

            if (delayUpdated)
            {
                delayType = tmpDelayType;
                delay = tmpDelay;
                delayRange = tmpDelayRange;

                delayUpdated = false;
            }

            if (countUpdated)
            {
                countType = tmpCountType;
                count = tmpCount;

                countUpdated = false;
            }
            //System.Diagnostics.Debug.Print("Settings synced");
        }

        public void UpdateButton(ButtonType ButtonType, bool DoubleClick)
        {
            tmpButtonType = ButtonType;
            tmpDoubleClick = DoubleClick;

            buttonUpdated = true;
        }

        public void UpdateLocation(LocationType LocationType, int X, int Y, int Width, int Height)
        {
            tmpLocationType = LocationType;
            tmpX = X;
            tmpY = Y;
            tmpWidth = Width;
            tmpHeight = Height;

            locationUpdated = true;
        }

        public void UpdateDelay(DelayType DelayType, int Delay, int DelayRange)
        {
            tmpDelayType = DelayType;
            tmpDelay = Delay;
            tmpDelayRange = DelayRange;

            delayUpdated = true;
        }

        public void UpdateCount(CountType CountType, int Count)
        {
            tmpCountType = CountType;
            tmpCount = Count;

            countUpdated = true;
        }
    }
}
