﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.261.
// 
#pragma warning disable 1591

namespace LogReader.LoggingService {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ClientLineServiceSoap", Namespace="http://www.client-line.com/")]
    public partial class ClientLineService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback WriteLogOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReadLogOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCRMTipOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ClientLineService() {
            this.Url = global::LogReader.Properties.Settings.Default.LogReader_LoggingService_ClientLineService;
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
        public event WriteLogCompletedEventHandler WriteLogCompleted;
        
        /// <remarks/>
        public event ReadLogCompletedEventHandler ReadLogCompleted;
        
        /// <remarks/>
        public event GetCRMTipCompletedEventHandler GetCRMTipCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.client-line.com/WriteLog", RequestNamespace="http://www.client-line.com/", ResponseNamespace="http://www.client-line.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void WriteLog(System.DateTime date, string applicationName, string remoteUser, string internalUser, string logType, string message, string stackTrace) {
            this.Invoke("WriteLog", new object[] {
                        date,
                        applicationName,
                        remoteUser,
                        internalUser,
                        logType,
                        message,
                        stackTrace});
        }
        
        /// <remarks/>
        public void WriteLogAsync(System.DateTime date, string applicationName, string remoteUser, string internalUser, string logType, string message, string stackTrace) {
            this.WriteLogAsync(date, applicationName, remoteUser, internalUser, logType, message, stackTrace, null);
        }
        
        /// <remarks/>
        public void WriteLogAsync(System.DateTime date, string applicationName, string remoteUser, string internalUser, string logType, string message, string stackTrace, object userState) {
            if ((this.WriteLogOperationCompleted == null)) {
                this.WriteLogOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWriteLogOperationCompleted);
            }
            this.InvokeAsync("WriteLog", new object[] {
                        date,
                        applicationName,
                        remoteUser,
                        internalUser,
                        logType,
                        message,
                        stackTrace}, this.WriteLogOperationCompleted, userState);
        }
        
        private void OnWriteLogOperationCompleted(object arg) {
            if ((this.WriteLogCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WriteLogCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.client-line.com/ReadLog", RequestNamespace="http://www.client-line.com/", ResponseNamespace="http://www.client-line.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable ReadLog() {
            object[] results = this.Invoke("ReadLog", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void ReadLogAsync() {
            this.ReadLogAsync(null);
        }
        
        /// <remarks/>
        public void ReadLogAsync(object userState) {
            if ((this.ReadLogOperationCompleted == null)) {
                this.ReadLogOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReadLogOperationCompleted);
            }
            this.InvokeAsync("ReadLog", new object[0], this.ReadLogOperationCompleted, userState);
        }
        
        private void OnReadLogOperationCompleted(object arg) {
            if ((this.ReadLogCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReadLogCompleted(this, new ReadLogCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.client-line.com/GetCRMTip", RequestNamespace="http://www.client-line.com/", ResponseNamespace="http://www.client-line.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetCRMTip() {
            object[] results = this.Invoke("GetCRMTip", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetCRMTipAsync() {
            this.GetCRMTipAsync(null);
        }
        
        /// <remarks/>
        public void GetCRMTipAsync(object userState) {
            if ((this.GetCRMTipOperationCompleted == null)) {
                this.GetCRMTipOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCRMTipOperationCompleted);
            }
            this.InvokeAsync("GetCRMTip", new object[0], this.GetCRMTipOperationCompleted, userState);
        }
        
        private void OnGetCRMTipOperationCompleted(object arg) {
            if ((this.GetCRMTipCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCRMTipCompleted(this, new GetCRMTipCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void WriteLogCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void ReadLogCompletedEventHandler(object sender, ReadLogCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReadLogCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReadLogCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetCRMTipCompletedEventHandler(object sender, GetCRMTipCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCRMTipCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCRMTipCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591