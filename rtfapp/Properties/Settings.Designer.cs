﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rtfapp.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=172.16.2.46;user id=Konrad;password=rock6699LIS@;database=\"bazapacjentow v" +
            "2\";persistsecurityinfo=True;characterset=utf8")]
        public string Baza {
            get {
                return ((string)(this["Baza"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=172.16.2.46;user id=Konrad;password=rock6699LIS@;persistsecurityinfo=True;" +
            "database=\"bazapacjentow v2\"")]
        public string bazapacjentow_v2ConnectionString {
            get {
                return ((string)(this["bazapacjentow_v2ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=172.16.2.46;user id=Konrad;persistsecurityinfo=True;database=\"bazapacjento" +
            "w v2\";password=rock6699LIS@")]
        public string bazapacjentow_v2ConnectionString1 {
            get {
                return ((string)(this["bazapacjentow_v2ConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=172.16.2.46;user id=Konrad;persistsecurityinfo=True;database=\"bazapacjento" +
            "w v2\";allowuservariables=True;password=rock6699LIS@")]
        public string bazapacjentow_v2ConnectionString2 {
            get {
                return ((string)(this["bazapacjentow_v2ConnectionString2"]));
            }
        }
    }
}
