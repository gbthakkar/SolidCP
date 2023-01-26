// Copyright (c) 2016, SolidCP
// SolidCP is distributed under the Creative Commons Share-alike license
// 
// SolidCP is a fork of WebsitePanel:
// Copyright (c) 2015, Outercurve Foundation.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  Outercurve Foundation  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.1.
// 
#pragma warning disable 1591

namespace SolidCP.Installer.Services {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="InstallerServiceSoap", Namespace="http://installer.solidcp.com/services")]
    public partial class InstallerService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetReleaseFileInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFileChunkOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFileSizeOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAvailableComponentsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetLatestComponentUpdateOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetComponentUpdateOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public InstallerService() {
            this.Url = global::SolidCP.Installer.Core.Properties.Settings.Default.SolidCP_Installer_Core_InstallerService_InstallerService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetReleaseFileInfoCompletedEventHandler GetReleaseFileInfoCompleted;
        
        /// <remarks/>
        public event GetFileChunkCompletedEventHandler GetFileChunkCompleted;
        
        /// <remarks/>
        public event GetFileSizeCompletedEventHandler GetFileSizeCompleted;
        
        /// <remarks/>
        public event GetAvailableComponentsCompletedEventHandler GetAvailableComponentsCompleted;
        
        /// <remarks/>
        public event GetLatestComponentUpdateCompletedEventHandler GetLatestComponentUpdateCompleted;
        
        /// <remarks/>
        public event GetComponentUpdateCompletedEventHandler GetComponentUpdateCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://installer.solidcp.com/services/GetReleaseFileInfo", RequestNamespace="http://installer.solidcp.com/services", ResponseNamespace="http://installer.solidcp.com/services", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetReleaseFileInfo(string componentCode, string version) {
            object[] results = this.Invoke("GetReleaseFileInfo", new object[] {
                        componentCode,
                        version});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetReleaseFileInfoAsync(string componentCode, string version) {
            this.GetReleaseFileInfoAsync(componentCode, version, null);
        }
        
        /// <remarks/>
        public void GetReleaseFileInfoAsync(string componentCode, string version, object userState) {
            if ((this.GetReleaseFileInfoOperationCompleted == null)) {
                this.GetReleaseFileInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetReleaseFileInfoOperationCompleted);
            }
            this.InvokeAsync("GetReleaseFileInfo", new object[] {
                        componentCode,
                        version}, this.GetReleaseFileInfoOperationCompleted, userState);
        }
        
        private void OnGetReleaseFileInfoOperationCompleted(object arg) {
            if ((this.GetReleaseFileInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetReleaseFileInfoCompleted(this, new GetReleaseFileInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://installer.solidcp.com/services/GetFileChunk", RequestNamespace="http://installer.solidcp.com/services", ResponseNamespace="http://installer.solidcp.com/services", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] GetFileChunk(string fileName, int offset, int size) {
            object[] results = this.Invoke("GetFileChunk", new object[] {
                        fileName,
                        offset,
                        size});
            return ((byte[])(results[0]));
        }
        
        /// <remarks/>
        public void GetFileChunkAsync(string fileName, int offset, int size) {
            this.GetFileChunkAsync(fileName, offset, size, null);
        }
        
        /// <remarks/>
        public void GetFileChunkAsync(string fileName, int offset, int size, object userState) {
            if ((this.GetFileChunkOperationCompleted == null)) {
                this.GetFileChunkOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFileChunkOperationCompleted);
            }
            this.InvokeAsync("GetFileChunk", new object[] {
                        fileName,
                        offset,
                        size}, this.GetFileChunkOperationCompleted, userState);
        }
        
        private void OnGetFileChunkOperationCompleted(object arg) {
            if ((this.GetFileChunkCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFileChunkCompleted(this, new GetFileChunkCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://installer.solidcp.com/services/GetFileSize", RequestNamespace="http://installer.solidcp.com/services", ResponseNamespace="http://installer.solidcp.com/services", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public long GetFileSize(string fileName) {
            object[] results = this.Invoke("GetFileSize", new object[] {
                        fileName});
            return ((long)(results[0]));
        }
        
        /// <remarks/>
        public void GetFileSizeAsync(string fileName) {
            this.GetFileSizeAsync(fileName, null);
        }
        
        /// <remarks/>
        public void GetFileSizeAsync(string fileName, object userState) {
            if ((this.GetFileSizeOperationCompleted == null)) {
                this.GetFileSizeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFileSizeOperationCompleted);
            }
            this.InvokeAsync("GetFileSize", new object[] {
                        fileName}, this.GetFileSizeOperationCompleted, userState);
        }
        
        private void OnGetFileSizeOperationCompleted(object arg) {
            if ((this.GetFileSizeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFileSizeCompleted(this, new GetFileSizeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://installer.solidcp.com/services/GetAvailableComponents", RequestNamespace="http://installer.solidcp.com/services", ResponseNamespace="http://installer.solidcp.com/services", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetAvailableComponents() {
            object[] results = this.Invoke("GetAvailableComponents", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetAvailableComponentsAsync() {
            this.GetAvailableComponentsAsync(null);
        }
        
        /// <remarks/>
        public void GetAvailableComponentsAsync(object userState) {
            if ((this.GetAvailableComponentsOperationCompleted == null)) {
                this.GetAvailableComponentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAvailableComponentsOperationCompleted);
            }
            this.InvokeAsync("GetAvailableComponents", new object[0], this.GetAvailableComponentsOperationCompleted, userState);
        }
        
        private void OnGetAvailableComponentsOperationCompleted(object arg) {
            if ((this.GetAvailableComponentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAvailableComponentsCompleted(this, new GetAvailableComponentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://installer.solidcp.com/services/GetLatestComponentUpdate", RequestNamespace="http://installer.solidcp.com/services", ResponseNamespace="http://installer.solidcp.com/services", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetLatestComponentUpdate(string componentCode) {
            object[] results = this.Invoke("GetLatestComponentUpdate", new object[] {
                        componentCode});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetLatestComponentUpdateAsync(string componentCode) {
            this.GetLatestComponentUpdateAsync(componentCode, null);
        }
        
        /// <remarks/>
        public void GetLatestComponentUpdateAsync(string componentCode, object userState) {
            if ((this.GetLatestComponentUpdateOperationCompleted == null)) {
                this.GetLatestComponentUpdateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetLatestComponentUpdateOperationCompleted);
            }
            this.InvokeAsync("GetLatestComponentUpdate", new object[] {
                        componentCode}, this.GetLatestComponentUpdateOperationCompleted, userState);
        }
        
        private void OnGetLatestComponentUpdateOperationCompleted(object arg) {
            if ((this.GetLatestComponentUpdateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetLatestComponentUpdateCompleted(this, new GetLatestComponentUpdateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://installer.solidcp.com/services/GetComponentUpdate", RequestNamespace="http://installer.solidcp.com/services", ResponseNamespace="http://installer.solidcp.com/services", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetComponentUpdate(string componentCode, string release) {
            object[] results = this.Invoke("GetComponentUpdate", new object[] {
                        componentCode,
                        release});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetComponentUpdateAsync(string componentCode, string release) {
            this.GetComponentUpdateAsync(componentCode, release, null);
        }
        
        /// <remarks/>
        public void GetComponentUpdateAsync(string componentCode, string release, object userState) {
            if ((this.GetComponentUpdateOperationCompleted == null)) {
                this.GetComponentUpdateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetComponentUpdateOperationCompleted);
            }
            this.InvokeAsync("GetComponentUpdate", new object[] {
                        componentCode,
                        release}, this.GetComponentUpdateOperationCompleted, userState);
        }
        
        private void OnGetComponentUpdateOperationCompleted(object arg) {
            if ((this.GetComponentUpdateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetComponentUpdateCompleted(this, new GetComponentUpdateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetReleaseFileInfoCompletedEventHandler(object sender, GetReleaseFileInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetReleaseFileInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetReleaseFileInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetFileChunkCompletedEventHandler(object sender, GetFileChunkCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFileChunkCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFileChunkCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public byte[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetFileSizeCompletedEventHandler(object sender, GetFileSizeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFileSizeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFileSizeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public long Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((long)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetAvailableComponentsCompletedEventHandler(object sender, GetAvailableComponentsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAvailableComponentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAvailableComponentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetLatestComponentUpdateCompletedEventHandler(object sender, GetLatestComponentUpdateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetLatestComponentUpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetLatestComponentUpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetComponentUpdateCompletedEventHandler(object sender, GetComponentUpdateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetComponentUpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetComponentUpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591
