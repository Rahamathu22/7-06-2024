﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_Project_App.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
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
<<<<<<< HEAD
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=school_temp;Integrated Security=Tru" +
            "e")]
=======
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-BHCKS8G;Initial Catalog=School;Integrated Security=True")]
>>>>>>> 1a0ca63ff62f97fecc9546ca580420075c765edb
        public string Data {
            get {
                return ((string)(this["Data"]));
            }
        }
    }
}
