﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.2032.
// 
namespace EproLibNET.JMJIntegrationService {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="IntegrationServiceSoap", Namespace="http://tempuri.org/")]
    public class IntegrationService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public IntegrationService() {
            this.Url = "http://www.jmjtech.com/integration/integrationservice.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PutJMJMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void PutJMJMessage(string JMJMessage) {
            this.Invoke("PutJMJMessage", new object[] {
                        JMJMessage});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginPutJMJMessage(string JMJMessage, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("PutJMJMessage", new object[] {
                        JMJMessage}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndPutJMJMessage(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetData(string CustomerID, string Password) {
            object[] results = this.Invoke("GetData", new object[] {
                        CustomerID,
                        Password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetData(string CustomerID, string Password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetData", new object[] {
                        CustomerID,
                        Password}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetData(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Complete", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Complete(string MessageID, int Status) {
            this.Invoke("Complete", new object[] {
                        MessageID,
                        Status});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginComplete(string MessageID, int Status, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Complete", new object[] {
                        MessageID,
                        Status}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndComplete(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPAddr", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string IPAddr() {
            object[] results = this.Invoke("IPAddr", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginIPAddr(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("IPAddr", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndIPAddr(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SetData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SetData(string XmlData) {
            object[] results = this.Invoke("SetData", new object[] {
                        XmlData});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSetData(string XmlData, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SetData", new object[] {
                        XmlData}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndSetData(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
    }
}
