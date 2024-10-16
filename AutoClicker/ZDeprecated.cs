using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoClicker
{
    public class ZDeprecated
    {
        /*
        private void SaveSettings()
        {
            using (FileStream fs = File.Open("settings.dat", FileMode.Create))
            {
                using (BinaryWriter w = new BinaryWriter(fs))
                {
                    // Button type.
                    if (rdbClickSingleLeft.Checked)
                    {
                        w.Write((byte)1);
                    }
                    else if (rdbClickSingleMiddle.Checked)
                    {
                        w.Write((byte)2);
                    }
                    else if (rdbClickSingleRight.Checked)
                    {
                        w.Write((byte)3);
                    }
                    else if (rdbClickDoubleLeft.Checked)
                    {
                        w.Write((byte)4);
                    }
                    else if (rdbClickDoubleMiddle.Checked)
                    {
                        w.Write((byte)5);
                    }
                    else if (rdbClickDoubleRight.Checked)
                    {
                        w.Write((byte)6);
                    }

                    // Location info
                    if (rdbLocationFixed.Checked)
                    {
                        w.Write((byte)1);
                    }
                    else if (rdbLocationMouse.Checked)
                    {
                        w.Write((byte)2);
                    }
                    else if (rdbLocationRandom.Checked)
                    {
                        w.Write((byte)3);
                    }
                    else if (rdbLocationRandomArea.Checked)
                    {
                        w.Write((byte)4);
                    }

                    w.Write((int)numFixedX.Value);
                    w.Write((int)numFixedY.Value);
                    w.Write((int)numRandomX.Value);
                    w.Write((int)numRandomY.Value);
                    w.Write((int)numRandomWidth.Value);
                    w.Write((int)numRandomHeight.Value);

                    // Delay info
                    if (rdbDelayFixed.Checked)
                    {
                        w.Write((byte)1);
                    }
                    else if (rdbDelayRange.Checked)
                    {
                        w.Write((byte)2);
                    }

                    w.Write((int)numDelayFixed.Value);
                    w.Write((int)numDelayRangeMin.Value);
                    w.Write((int)numDelayRangeMax.Value);

                    // Count info
                    if (rdbCount.Checked)
                    {
                        w.Write((byte)1);
                    }
                    else if (rdbUntilStopped.Checked)
                    {
                        w.Write((byte)2);
                    }

                    w.Write((int)numCount.Value);

                    // Hotkey info
                    w.Write((int)hotkey);
                }
            }
        }

        private void LoadSettings()
        {
            if (File.Exists("settings.dat"))
            {
                using (FileStream fs = File.Open("settings.dat", FileMode.Open))
                {
                    using (BinaryReader r = new BinaryReader(fs))
                    {
                        byte buttonType = r.ReadByte();

                        byte locationType = r.ReadByte();
                        int fixedX = r.ReadInt32();
                        int fixedY = r.ReadInt32();
                        int randomX = r.ReadInt32();
                        int randomY = r.ReadInt32();
                        int randomWidth = r.ReadInt32();
                        int randomHeight = r.ReadInt32();

                        byte delayType = r.ReadByte();
                        int fixedDelay = r.ReadInt32();
                        int rangeDelayMin = r.ReadInt32();
                        int rangeDelayMax = r.ReadInt32();

                        byte countType = r.ReadByte();
                        int count = r.ReadInt32();

                        hotkey = (Keys)r.ReadInt32();

                        switch (buttonType)
                        {
                            case 1:
                                rdbClickSingleLeft.Checked = true;
                                break;
                            case 2:
                                rdbClickSingleMiddle.Checked = true;
                                break;
                            case 3:
                                rdbClickSingleRight.Checked = true;
                                break;
                            case 4:
                                rdbClickDoubleLeft.Checked = true;
                                break;
                            case 5:
                                rdbClickDoubleMiddle.Checked = true;
                                break;
                            case 6:
                                rdbClickDoubleRight.Checked = true;
                                break;
                        }

                        switch (locationType)
                        {
                            case 1:
                                rdbLocationFixed.Checked = true;
                                break;
                            case 2:
                                rdbLocationMouse.Checked = true;
                                break;
                            case 3:
                                rdbLocationRandom.Checked = true;
                                break;
                            case 4:
                                rdbLocationRandomArea.Checked = true;
                                break;
                        }

                        numFixedX.Value = fixedX;
                        numFixedY.Value = fixedY;
                        numRandomX.Value = randomX;
                        numRandomY.Value = randomY;
                        numRandomWidth.Value = randomWidth;
                        numRandomHeight.Value = randomHeight;

                        switch (delayType)
                        {
                            case 1:
                                rdbDelayFixed.Checked = true;
                                break;
                            case 2:
                                rdbDelayRange.Checked = true;
                                break;
                        }

                        numDelayFixed.Value = fixedDelay;
                        numDelayRangeMin.Value = rangeDelayMin;
                        numDelayRangeMax.Value = rangeDelayMax;

                        switch (countType)
                        {
                            case 1:
                                rdbCount.Checked = true;
                                break;
                            case 2:
                                rdbUntilStopped.Checked = true;
                                break;
                        }

                        numCount.Value = count;

                        if (hotkey != Keys.None)
                        {
                            var hotkeyModifiers = hotkey & Keys.Modifiers;
                            hotkeyNodifiers = 0;
                            if ((hotkeyModifiers & Keys.Shift) != 0)
                            {
                                hotkeyNodifiers |= Win32.fsModifiers.Shift;
                            }
                            if ((hotkeyModifiers & Keys.Control) != 0)
                            {
                                hotkeyNodifiers |= Win32.fsModifiers.Control;
                            }
                            if ((hotkeyModifiers & Keys.Alt) != 0)
                            {
                                hotkeyNodifiers |= Win32.fsModifiers.Alt;
                            }

                            SetHotkey();
                        }
                    }
                }
            }
        }


        */

    }
}
