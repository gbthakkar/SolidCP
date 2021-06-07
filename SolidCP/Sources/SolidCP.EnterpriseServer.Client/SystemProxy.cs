//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.7905
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.3038.
// 
namespace SolidCP.EnterpriseServer {
    using System.Xml.Serialization;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Diagnostics;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="esSystemSoap", Namespace="http://tempuri.org/")]
    public partial class esSystem : Microsoft.Web.Services3.WebServicesClientProtocol {
        
        private System.Threading.SendOrPostCallback GetSystemSettingsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSystemSettingsActiveOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckIsTwilioEnabledOperationCompleted;
        
        private System.Threading.SendOrPostCallback SetSystemSettingsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetThemesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetThemeSettingsOperationCompleted;

        private System.Threading.SendOrPostCallback GetThemeSettingOperationCompleted;

        /// <remarks/>
        public esSystem() {
            this.Url = "http://127.0.0.1:9002/esSystem.asmx";
        }
        
        /// <remarks/>
        public event GetSystemSettingsCompletedEventHandler GetSystemSettingsCompleted;
        
        /// <remarks/>
        public event GetSystemSettingsActiveCompletedEventHandler GetSystemSettingsActiveCompleted;
        
        /// <remarks/>
        public event CheckIsTwilioEnabledCompletedEventHandler CheckIsTwilioEnabledCompleted;
        
        /// <remarks/>
        public event SetSystemSettingsCompletedEventHandler SetSystemSettingsCompleted;
        
        /// <remarks/>
        public event GetThemesCompletedEventHandler GetThemesCompleted;
        
        /// <remarks/>
        public event GetThemeSettingsCompletedEventHandler GetThemeSettingsCompleted;

        /// <remarks/>
        public event GetThemeSettingCompletedEventHandler GetThemeSettingCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSystemSettings", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SystemSettings GetSystemSettings(string settingsName) {
            object[] results = this.Invoke("GetSystemSettings", new object[] {
                        settingsName});
            return ((SystemSettings)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetSystemSettings(string settingsName, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetSystemSettings", new object[] {
                        settingsName}, callback, asyncState);
        }
        
        /// <remarks/>
        public SystemSettings EndGetSystemSettings(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((SystemSettings)(results[0]));
        }
        
        /// <remarks/>
        public void GetSystemSettingsAsync(string settingsName) {
            this.GetSystemSettingsAsync(settingsName, null);
        }
        
        /// <remarks/>
        public void GetSystemSettingsAsync(string settingsName, object userState) {
            if ((this.GetSystemSettingsOperationCompleted == null)) {
                this.GetSystemSettingsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSystemSettingsOperationCompleted);
            }
            this.InvokeAsync("GetSystemSettings", new object[] {
                        settingsName}, this.GetSystemSettingsOperationCompleted, userState);
        }
        
        private void OnGetSystemSettingsOperationCompleted(object arg) {
            if ((this.GetSystemSettingsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSystemSettingsCompleted(this, new GetSystemSettingsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSystemSettingsActive", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SystemSettings GetSystemSettingsActive(string settingsName, bool decrypt) {
            object[] results = this.Invoke("GetSystemSettingsActive", new object[] {
                        settingsName,
                        decrypt});
            return ((SystemSettings)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetSystemSettingsActive(string settingsName, bool decrypt, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetSystemSettingsActive", new object[] {
                        settingsName,
                        decrypt}, callback, asyncState);
        }
        
        /// <remarks/>
        public SystemSettings EndGetSystemSettingsActive(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((SystemSettings)(results[0]));
        }
        
        /// <remarks/>
        public void GetSystemSettingsActiveAsync(string settingsName, bool decrypt) {
            this.GetSystemSettingsActiveAsync(settingsName, decrypt, null);
        }
        
        /// <remarks/>
        public void GetSystemSettingsActiveAsync(string settingsName, bool decrypt, object userState) {
            if ((this.GetSystemSettingsActiveOperationCompleted == null)) {
                this.GetSystemSettingsActiveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSystemSettingsActiveOperationCompleted);
            }
            this.InvokeAsync("GetSystemSettingsActive", new object[] {
                        settingsName,
                        decrypt}, this.GetSystemSettingsActiveOperationCompleted, userState);
        }
        
        private void OnGetSystemSettingsActiveOperationCompleted(object arg) {
            if ((this.GetSystemSettingsActiveCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSystemSettingsActiveCompleted(this, new GetSystemSettingsActiveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CheckIsTwilioEnabled", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CheckIsTwilioEnabled() {
            object[] results = this.Invoke("CheckIsTwilioEnabled", new object[0]);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginCheckIsTwilioEnabled(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("CheckIsTwilioEnabled", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndCheckIsTwilioEnabled(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CheckIsTwilioEnabledAsync() {
            this.CheckIsTwilioEnabledAsync(null);
        }
        
        /// <remarks/>
        public void CheckIsTwilioEnabledAsync(object userState) {
            if ((this.CheckIsTwilioEnabledOperationCompleted == null)) {
                this.CheckIsTwilioEnabledOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckIsTwilioEnabledOperationCompleted);
            }
            this.InvokeAsync("CheckIsTwilioEnabled", new object[0], this.CheckIsTwilioEnabledOperationCompleted, userState);
        }
        
        private void OnCheckIsTwilioEnabledOperationCompleted(object arg) {
            if ((this.CheckIsTwilioEnabledCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckIsTwilioEnabledCompleted(this, new CheckIsTwilioEnabledCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SetSystemSettings", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int SetSystemSettings(string settingsName, SystemSettings settings) {
            object[] results = this.Invoke("SetSystemSettings", new object[] {
                        settingsName,
                        settings});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSetSystemSettings(string settingsName, SystemSettings settings, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SetSystemSettings", new object[] {
                        settingsName,
                        settings}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndSetSystemSettings(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void SetSystemSettingsAsync(string settingsName, SystemSettings settings) {
            this.SetSystemSettingsAsync(settingsName, settings, null);
        }
        
        /// <remarks/>
        public void SetSystemSettingsAsync(string settingsName, SystemSettings settings, object userState) {
            if ((this.SetSystemSettingsOperationCompleted == null)) {
                this.SetSystemSettingsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetSystemSettingsOperationCompleted);
            }
            this.InvokeAsync("SetSystemSettings", new object[] {
                        settingsName,
                        settings}, this.SetSystemSettingsOperationCompleted, userState);
        }
        
        private void OnSetSystemSettingsOperationCompleted(object arg) {
            if ((this.SetSystemSettingsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetSystemSettingsCompleted(this, new SetSystemSettingsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetThemes", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetThemes() {
            object[] results = this.Invoke("GetThemes", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetThemes(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetThemes", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetThemes(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetThemesAsync() {
            this.GetThemesAsync(null);
        }
        
        /// <remarks/>
        public void GetThemesAsync(object userState) {
            if ((this.GetThemesOperationCompleted == null)) {
                this.GetThemesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetThemesOperationCompleted);
            }
            this.InvokeAsync("GetThemes", new object[0], this.GetThemesOperationCompleted, userState);
        }
        
        private void OnGetThemesOperationCompleted(object arg) {
            if ((this.GetThemesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetThemesCompleted(this, new GetThemesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetThemeSettings", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetThemeSettings(int ThemeID, string SettingsName) {
            object[] results = this.Invoke("GetThemeSettings", new object[] {
                        ThemeID,
                        SettingsName});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetThemeSettings(int ThemeID, string SettingsName, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetThemeSettings", new object[] {
                        ThemeID,
                        SettingsName}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetThemeSettings(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetThemeSettingsAsync(int ThemeID) {
            this.GetThemeSettingsAsync(ThemeID, null);
        }
        
        /// <remarks/>
        public void GetThemeSettingsAsync(int ThemeID, object userState) {
            if ((this.GetThemeSettingsOperationCompleted == null)) {
                this.GetThemeSettingsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetThemeSettingsOperationCompleted);
            }
            this.InvokeAsync("GetThemeSettings", new object[] {
                        ThemeID}, this.GetThemeSettingsOperationCompleted, userState);
        }
        
        private void OnGetThemeSettingsOperationCompleted(object arg) {
            if ((this.GetThemeSettingsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetThemeSettingsCompleted(this, new GetThemeSettingsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetThemeSetting", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetThemeSetting(int ThemeID, string SettingsName)
        {
            object[] results = this.Invoke("GetThemeSetting", new object[] {
                        ThemeID,
                        SettingsName});
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetThemeSetting(int ThemeID, string SettingsName, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetThemeSetting", new object[] {
                        ThemeID,
                        SettingsName}, callback, asyncState);
        }

        /// <remarks/>
        public System.Data.DataSet EndGetThemeSetting(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public void GetThemeSettingAsync(int ThemeID, string SettingsName)
        {
            this.GetThemeSettingAsync(ThemeID, SettingsName, null);
        }

        /// <remarks/>
        public void GetThemeSettingAsync(int ThemeID, string SettingsName, object userState)
        {
            if ((this.GetThemeSettingOperationCompleted == null))
            {
                this.GetThemeSettingOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetThemeSettingOperationCompleted);
            }
            this.InvokeAsync("GetThemeSetting", new object[] {
                        ThemeID,
                        SettingsName}, this.GetThemeSettingOperationCompleted, userState);
        }

        private void OnGetThemeSettingOperationCompleted(object arg)
        {
            if ((this.GetThemeSettingCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetThemeSettingCompleted(this, new GetThemeSettingCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void GetSystemSettingsCompletedEventHandler(object sender, GetSystemSettingsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSystemSettingsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSystemSettingsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SystemSettings Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SystemSettings)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void GetSystemSettingsActiveCompletedEventHandler(object sender, GetSystemSettingsActiveCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSystemSettingsActiveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSystemSettingsActiveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SystemSettings Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SystemSettings)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void CheckIsTwilioEnabledCompletedEventHandler(object sender, CheckIsTwilioEnabledCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckIsTwilioEnabledCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckIsTwilioEnabledCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void SetSystemSettingsCompletedEventHandler(object sender, SetSystemSettingsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetSystemSettingsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SetSystemSettingsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetThemesCompletedEventHandler(object sender, GetThemesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetThemesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetThemesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetThemeSettingsCompletedEventHandler(object sender, GetThemeSettingsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetThemeSettingsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetThemeSettingsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetThemeSettingCompletedEventHandler(object sender, GetThemeSettingCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetThemeSettingCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetThemeSettingCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Data.DataSet Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}
