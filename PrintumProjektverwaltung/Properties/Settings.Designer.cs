﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrintumProjektverwaltung.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=192.168.26.250\\EXPRESS2008ERP;Initial Catalog=PrintumDB;Persist Secur" +
            "ity Info=True;User ID=sa;Password=Inhouse2017;MultipleActiveResultSets=True;Appl" +
            "ication Name=EntityFramework")]
        public string PrintumProjekteConnectionString {
            get {
                return ((string)(this["PrintumProjekteConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string templatePath {
            get {
                return ((string)(this["templatePath"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GrqAbpzk7iETAu2avFjGDgR")]
        public string Kennwort_Appregistartion {
            get {
                return ((string)(this["Kennwort_Appregistartion"]));
            }
            set {
                this["Kennwort_Appregistartion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("94b49e81-a4e2-4e41-b224-9999bff7d3ed")]
        public string AnwendungsID {
            get {
                return ((string)(this["AnwendungsID"]));
            }
            set {
                this["AnwendungsID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PrintumProjektverwaltung")]
        public string AnwendungsName {
            get {
                return ((string)(this["AnwendungsName"]));
            }
            set {
                this["AnwendungsName"] = value;
            }
        }
    }
}
