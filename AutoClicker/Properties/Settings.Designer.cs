﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoClicker.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.11.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point RandomAreaPoint {
            get {
                return ((global::System.Drawing.Point)(this["RandomAreaPoint"]));
            }
            set {
                this["RandomAreaPoint"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40, 20")]
        public global::System.Drawing.Size RandomAreaSize {
            get {
                return ((global::System.Drawing.Size)(this["RandomAreaSize"]));
            }
            set {
                this["RandomAreaSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int FixedClickCount {
            get {
                return ((int)(this["FixedClickCount"]));
            }
            set {
                this["FixedClickCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("520")]
        public int NextClickDelayMinMS {
            get {
                return ((int)(this["NextClickDelayMinMS"]));
            }
            set {
                this["NextClickDelayMinMS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1520")]
        public int NextClickDelayMaxMS {
            get {
                return ((int)(this["NextClickDelayMaxMS"]));
            }
            set {
                this["NextClickDelayMaxMS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1020")]
        public int AfterWheelRollDelayMinMS {
            get {
                return ((int)(this["AfterWheelRollDelayMinMS"]));
            }
            set {
                this["AfterWheelRollDelayMinMS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1820")]
        public int AfterWheelRollDelayMaxMS {
            get {
                return ((int)(this["AfterWheelRollDelayMaxMS"]));
            }
            set {
                this["AfterWheelRollDelayMaxMS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableLogToFile {
            get {
                return ((bool)(this["EnableLogToFile"]));
            }
            set {
                this["EnableLogToFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsDebugging {
            get {
                return ((bool)(this["IsDebugging"]));
            }
            set {
                this["IsDebugging"] = value;
            }
        }
    }
}
