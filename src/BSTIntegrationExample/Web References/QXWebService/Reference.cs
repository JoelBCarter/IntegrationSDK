﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace BSTIntegrationExample.QXWebService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "EnrollmentSoap", Namespace = "https://benefits-selection.com/qx/enrollment")]
    public partial class Enrollment : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback SiteGUIDOperationCompleted;

        private System.Threading.SendOrPostCallback ExportCheckSumOperationCompleted;

        private System.Threading.SendOrPostCallback CheckUserOperationCompleted;

        private System.Threading.SendOrPostCallback CheckEmployeePINOperationCompleted;

        private System.Threading.SendOrPostCallback LoginGUIDOperationCompleted;

        private System.Threading.SendOrPostCallback GetLoginGUIDOperationCompleted;

        private System.Threading.SendOrPostCallback PortfolioAsOfDateOperationCompleted;

        private System.Threading.SendOrPostCallback UploadOperationCompleted;

        private System.Threading.SendOrPostCallback QueryOperationCompleted;

        private bool useDefaultCredentialsSetExplicitly;

        /// <remarks/>
        public Enrollment()
        {
        }

        public new string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true)
                            && (this.useDefaultCredentialsSetExplicitly == false))
                            && (this.IsLocalFileSystemWebService(value) == false)))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public new bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        /// <remarks/>
        public event SiteGUIDCompletedEventHandler SiteGUIDCompleted;

        /// <remarks/>
        public event ExportCheckSumCompletedEventHandler ExportCheckSumCompleted;

        /// <remarks/>
        public event CheckUserCompletedEventHandler CheckUserCompleted;

        /// <remarks/>
        public event CheckEmployeePINCompletedEventHandler CheckEmployeePINCompleted;

        /// <remarks/>
        public event LoginGUIDCompletedEventHandler LoginGUIDCompleted;

        /// <remarks/>
        public event GetLoginGUIDCompletedEventHandler GetLoginGUIDCompleted;

        /// <remarks/>
        public event PortfolioAsOfDateCompletedEventHandler PortfolioAsOfDateCompleted;

        /// <remarks/>
        public event UploadCompletedEventHandler UploadCompleted;

        /// <remarks/>
        public event QueryCompletedEventHandler QueryCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://benefits-selection.com/qx/enrollment/SiteGUID", RequestNamespace = "https://benefits-selection.com/qx/enrollment", ResponseNamespace = "https://benefits-selection.com/qx/enrollment", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Guid SiteGUID()
        {
            object[] results = this.Invoke("SiteGUID", new object[0]);
            return ((System.Guid)(results[0]));
        }

        /// <remarks/>
        public void SiteGUIDAsync()
        {
            this.SiteGUIDAsync(null);
        }

        /// <remarks/>
        public void SiteGUIDAsync(object userState)
        {
            if ((this.SiteGUIDOperationCompleted == null))
            {
                this.SiteGUIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSiteGUIDOperationCompleted);
            }
            this.InvokeAsync("SiteGUID", new object[0], this.SiteGUIDOperationCompleted, userState);
        }

        private void OnSiteGUIDOperationCompleted(object arg)
        {
            if ((this.SiteGUIDCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SiteGUIDCompleted(this, new SiteGUIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://benefits-selection.com/qx/enrollment/ExportCheckSum", RequestNamespace = "https://benefits-selection.com/qx/enrollment", ResponseNamespace = "https://benefits-selection.com/qx/enrollment", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ExportCheckSum(System.Guid exportID)
        {
            object[] results = this.Invoke("ExportCheckSum", new object[] {
                        exportID});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void ExportCheckSumAsync(System.Guid exportID)
        {
            this.ExportCheckSumAsync(exportID, null);
        }

        /// <remarks/>
        public void ExportCheckSumAsync(System.Guid exportID, object userState)
        {
            if ((this.ExportCheckSumOperationCompleted == null))
            {
                this.ExportCheckSumOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExportCheckSumOperationCompleted);
            }
            this.InvokeAsync("ExportCheckSum", new object[] {
                        exportID}, this.ExportCheckSumOperationCompleted, userState);
        }

        private void OnExportCheckSumOperationCompleted(object arg)
        {
            if ((this.ExportCheckSumCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExportCheckSumCompleted(this, new ExportCheckSumCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://benefits-selection.com/qx/enrollment/CheckUser", RequestNamespace = "https://benefits-selection.com/qx/enrollment", ResponseNamespace = "https://benefits-selection.com/qx/enrollment", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CheckUser(string user, string passwd)
        {
            object[] results = this.Invoke("CheckUser", new object[] {
                        user,
                        passwd});
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public void CheckUserAsync(string user, string passwd)
        {
            this.CheckUserAsync(user, passwd, null);
        }

        /// <remarks/>
        public void CheckUserAsync(string user, string passwd, object userState)
        {
            if ((this.CheckUserOperationCompleted == null))
            {
                this.CheckUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckUserOperationCompleted);
            }
            this.InvokeAsync("CheckUser", new object[] {
                        user,
                        passwd}, this.CheckUserOperationCompleted, userState);
        }

        private void OnCheckUserOperationCompleted(object arg)
        {
            if ((this.CheckUserCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckUserCompleted(this, new CheckUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://benefits-selection.com/qx/enrollment/CheckEmployeePIN", RequestNamespace = "https://benefits-selection.com/qx/enrollment", ResponseNamespace = "https://benefits-selection.com/qx/enrollment", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CheckEmployeePIN(System.Guid portfolioID, System.Guid employeeID, string pin)
        {
            object[] results = this.Invoke("CheckEmployeePIN", new object[] {
                        portfolioID,
                        employeeID,
                        pin});
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public void CheckEmployeePINAsync(System.Guid portfolioID, System.Guid employeeID, string pin)
        {
            this.CheckEmployeePINAsync(portfolioID, employeeID, pin, null);
        }

        /// <remarks/>
        public void CheckEmployeePINAsync(System.Guid portfolioID, System.Guid employeeID, string pin, object userState)
        {
            if ((this.CheckEmployeePINOperationCompleted == null))
            {
                this.CheckEmployeePINOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckEmployeePINOperationCompleted);
            }
            this.InvokeAsync("CheckEmployeePIN", new object[] {
                        portfolioID,
                        employeeID,
                        pin}, this.CheckEmployeePINOperationCompleted, userState);
        }

        private void OnCheckEmployeePINOperationCompleted(object arg)
        {
            if ((this.CheckEmployeePINCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckEmployeePINCompleted(this, new CheckEmployeePINCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://benefits-selection.com/qx/enrollment/LoginGUID", RequestNamespace = "https://benefits-selection.com/qx/enrollment", ResponseNamespace = "https://benefits-selection.com/qx/enrollment", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Guid LoginGUID(string user, string passwd, System.Guid uniqueID)
        {
            object[] results = this.Invoke("LoginGUID", new object[] {
                        user,
                        passwd,
                        uniqueID});
            return ((System.Guid)(results[0]));
        }

        /// <remarks/>
        public void LoginGUIDAsync(string user, string passwd, System.Guid uniqueID)
        {
            this.LoginGUIDAsync(user, passwd, uniqueID, null);
        }

        /// <remarks/>
        public void LoginGUIDAsync(string user, string passwd, System.Guid uniqueID, object userState)
        {
            if ((this.LoginGUIDOperationCompleted == null))
            {
                this.LoginGUIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginGUIDOperationCompleted);
            }
            this.InvokeAsync("LoginGUID", new object[] {
                        user,
                        passwd,
                        uniqueID}, this.LoginGUIDOperationCompleted, userState);
        }

        private void OnLoginGUIDOperationCompleted(object arg)
        {
            if ((this.LoginGUIDCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginGUIDCompleted(this, new LoginGUIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://benefits-selection.com/qx/enrollment/GetLoginGUID", RequestNamespace = "https://benefits-selection.com/qx/enrollment", ResponseNamespace = "https://benefits-selection.com/qx/enrollment", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Guid GetLoginGUID(string user, string passwd, System.Guid portfolioID, System.Guid uniqueID)
        {
            object[] results = this.Invoke("GetLoginGUID", new object[] {
                        user,
                        passwd,
                        portfolioID,
                        uniqueID});
            return ((System.Guid)(results[0]));
        }

        /// <remarks/>
        public void GetLoginGUIDAsync(string user, string passwd, System.Guid portfolioID, System.Guid uniqueID)
        {
            this.GetLoginGUIDAsync(user, passwd, portfolioID, uniqueID, null);
        }

        /// <remarks/>
        public void GetLoginGUIDAsync(string user, string passwd, System.Guid portfolioID, System.Guid uniqueID, object userState)
        {
            if ((this.GetLoginGUIDOperationCompleted == null))
            {
                this.GetLoginGUIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetLoginGUIDOperationCompleted);
            }
            this.InvokeAsync("GetLoginGUID", new object[] {
                        user,
                        passwd,
                        portfolioID,
                        uniqueID}, this.GetLoginGUIDOperationCompleted, userState);
        }

        private void OnGetLoginGUIDOperationCompleted(object arg)
        {
            if ((this.GetLoginGUIDCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetLoginGUIDCompleted(this, new GetLoginGUIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://benefits-selection.com/qx/enrollment/PortfolioAsOfDate", RequestNamespace = "https://benefits-selection.com/qx/enrollment", ResponseNamespace = "https://benefits-selection.com/qx/enrollment", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.DateTime PortfolioAsOfDate(System.Guid portfolioID)
        {
            object[] results = this.Invoke("PortfolioAsOfDate", new object[] {
                        portfolioID});
            return ((System.DateTime)(results[0]));
        }

        /// <remarks/>
        public void PortfolioAsOfDateAsync(System.Guid portfolioID)
        {
            this.PortfolioAsOfDateAsync(portfolioID, null);
        }

        /// <remarks/>
        public void PortfolioAsOfDateAsync(System.Guid portfolioID, object userState)
        {
            if ((this.PortfolioAsOfDateOperationCompleted == null))
            {
                this.PortfolioAsOfDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPortfolioAsOfDateOperationCompleted);
            }
            this.InvokeAsync("PortfolioAsOfDate", new object[] {
                        portfolioID}, this.PortfolioAsOfDateOperationCompleted, userState);
        }

        private void OnPortfolioAsOfDateOperationCompleted(object arg)
        {
            if ((this.PortfolioAsOfDateCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PortfolioAsOfDateCompleted(this, new PortfolioAsOfDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://benefits-selection.com/qx/enrollment/Upload", RequestNamespace = "https://benefits-selection.com/qx/enrollment", ResponseNamespace = "https://benefits-selection.com/qx/enrollment", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Upload(string user, string passwd, string data)
        {
            object[] results = this.Invoke("Upload", new object[] {
                        user,
                        passwd,
                        data});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void UploadAsync(string user, string passwd, string data)
        {
            this.UploadAsync(user, passwd, data, null);
        }

        /// <remarks/>
        public void UploadAsync(string user, string passwd, string data, object userState)
        {
            if ((this.UploadOperationCompleted == null))
            {
                this.UploadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUploadOperationCompleted);
            }
            this.InvokeAsync("Upload", new object[] {
                        user,
                        passwd,
                        data}, this.UploadOperationCompleted, userState);
        }

        private void OnUploadOperationCompleted(object arg)
        {
            if ((this.UploadCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UploadCompleted(this, new UploadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("https://benefits-selection.com/qx/enrollment/Query", RequestNamespace = "https://benefits-selection.com/qx/enrollment", ResponseNamespace = "https://benefits-selection.com/qx/enrollment", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Query(string user, string passwd, string data)
        {
            object[] results = this.Invoke("Query", new object[] {
                        user,
                        passwd,
                        data});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void QueryAsync(string user, string passwd, string data)
        {
            this.QueryAsync(user, passwd, data, null);
        }

        /// <remarks/>
        public void QueryAsync(string user, string passwd, string data, object userState)
        {
            if ((this.QueryOperationCompleted == null))
            {
                this.QueryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryOperationCompleted);
            }
            this.InvokeAsync("Query", new object[] {
                        user,
                        passwd,
                        data}, this.QueryOperationCompleted, userState);
        }

        private void OnQueryOperationCompleted(object arg)
        {
            if ((this.QueryCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryCompleted(this, new QueryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if (((url == null)
                        || (url == string.Empty)))
            {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024)
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0)))
            {
                return true;
            }
            return false;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void SiteGUIDCompletedEventHandler(object sender, SiteGUIDCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SiteGUIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SiteGUIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Guid Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Guid)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void ExportCheckSumCompletedEventHandler(object sender, ExportCheckSumCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExportCheckSumCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ExportCheckSumCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void CheckUserCompletedEventHandler(object sender, CheckUserCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CheckUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public bool Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void CheckEmployeePINCompletedEventHandler(object sender, CheckEmployeePINCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckEmployeePINCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CheckEmployeePINCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public bool Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void LoginGUIDCompletedEventHandler(object sender, LoginGUIDCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginGUIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal LoginGUIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Guid Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Guid)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetLoginGUIDCompletedEventHandler(object sender, GetLoginGUIDCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetLoginGUIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetLoginGUIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Guid Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Guid)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void PortfolioAsOfDateCompletedEventHandler(object sender, PortfolioAsOfDateCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PortfolioAsOfDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal PortfolioAsOfDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.DateTime Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void UploadCompletedEventHandler(object sender, UploadCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UploadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal UploadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void QueryCompletedEventHandler(object sender, QueryCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal QueryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591