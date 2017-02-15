﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Interpolaridad.eclipse {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Pr1SOAP", Namespace="http://www.example.org/Pr1/")]
    public partial class Pr1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ValidarNIFOperationCompleted;
        
        private System.Threading.SendOrPostCallback ValidarIBANOperationCompleted;
        
        private System.Threading.SendOrPostCallback consultaCodigoPostalOperationCompleted;
        
        private System.Threading.SendOrPostCallback generarPresupuestoOperationCompleted;
        
        private System.Threading.SendOrPostCallback solicitarPresupuestoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Pr1() {
            this.Url = global::Interpolaridad.Properties.Settings.Default.Interpolaridad_eclipse_Pr1;
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
        public event ValidarNIFCompletedEventHandler ValidarNIFCompleted;
        
        /// <remarks/>
        public event ValidarIBANCompletedEventHandler ValidarIBANCompleted;
        
        /// <remarks/>
        public event consultaCodigoPostalCompletedEventHandler consultaCodigoPostalCompleted;
        
        /// <remarks/>
        public event generarPresupuestoCompletedEventHandler generarPresupuestoCompleted;
        
        /// <remarks/>
        public event solicitarPresupuestoCompletedEventHandler solicitarPresupuestoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/Pr1/ValidarNIF", RequestNamespace="http://www.example.org/Pr1/", ResponseNamespace="http://www.example.org/Pr1/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("out", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ValidarNIF([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string nif, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey) {
            object[] results = this.Invoke("ValidarNIF", new object[] {
                        nif,
                        SoapKey});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ValidarNIFAsync(string nif, string SoapKey) {
            this.ValidarNIFAsync(nif, SoapKey, null);
        }
        
        /// <remarks/>
        public void ValidarNIFAsync(string nif, string SoapKey, object userState) {
            if ((this.ValidarNIFOperationCompleted == null)) {
                this.ValidarNIFOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidarNIFOperationCompleted);
            }
            this.InvokeAsync("ValidarNIF", new object[] {
                        nif,
                        SoapKey}, this.ValidarNIFOperationCompleted, userState);
        }
        
        private void OnValidarNIFOperationCompleted(object arg) {
            if ((this.ValidarNIFCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidarNIFCompleted(this, new ValidarNIFCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/Pr1/ValidarIBAN", RequestNamespace="http://www.example.org/Pr1/", ResponseNamespace="http://www.example.org/Pr1/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("out", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ValidarIBAN([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string iban, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string msg) {
            object[] results = this.Invoke("ValidarIBAN", new object[] {
                        iban,
                        SoapKey});
            msg = ((string)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ValidarIBANAsync(string iban, string SoapKey) {
            this.ValidarIBANAsync(iban, SoapKey, null);
        }
        
        /// <remarks/>
        public void ValidarIBANAsync(string iban, string SoapKey, object userState) {
            if ((this.ValidarIBANOperationCompleted == null)) {
                this.ValidarIBANOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidarIBANOperationCompleted);
            }
            this.InvokeAsync("ValidarIBAN", new object[] {
                        iban,
                        SoapKey}, this.ValidarIBANOperationCompleted, userState);
        }
        
        private void OnValidarIBANOperationCompleted(object arg) {
            if ((this.ValidarIBANCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidarIBANCompleted(this, new ValidarIBANCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/Pr1/consultaCodigoPostal", RequestNamespace="http://www.example.org/Pr1/", ResponseNamespace="http://www.example.org/Pr1/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("codigoPostal", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string consultaCodigoPostal([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string codpos, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string poblacion, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string provincia) {
            object[] results = this.Invoke("consultaCodigoPostal", new object[] {
                        codpos,
                        SoapKey});
            poblacion = ((string)(results[1]));
            provincia = ((string)(results[2]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void consultaCodigoPostalAsync(string codpos, string SoapKey) {
            this.consultaCodigoPostalAsync(codpos, SoapKey, null);
        }
        
        /// <remarks/>
        public void consultaCodigoPostalAsync(string codpos, string SoapKey, object userState) {
            if ((this.consultaCodigoPostalOperationCompleted == null)) {
                this.consultaCodigoPostalOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconsultaCodigoPostalOperationCompleted);
            }
            this.InvokeAsync("consultaCodigoPostal", new object[] {
                        codpos,
                        SoapKey}, this.consultaCodigoPostalOperationCompleted, userState);
        }
        
        private void OnconsultaCodigoPostalOperationCompleted(object arg) {
            if ((this.consultaCodigoPostalCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.consultaCodigoPostalCompleted(this, new consultaCodigoPostalCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/Pr1/generarPresupuesto", RequestNamespace="http://www.example.org/Pr1/", ResponseNamespace="http://www.example.org/Pr1/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("idPresupuesto", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int generarPresupuesto([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")] System.DateTime fechaPresupuesto, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int id, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string referenciaProducto, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int cantidadProducto, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out bool presupuestoGeneradoCorrectamente) {
            object[] results = this.Invoke("generarPresupuesto", new object[] {
                        SoapKey,
                        fechaPresupuesto,
                        id,
                        referenciaProducto,
                        cantidadProducto});
            presupuestoGeneradoCorrectamente = ((bool)(results[1]));
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void generarPresupuestoAsync(string SoapKey, System.DateTime fechaPresupuesto, int id, string referenciaProducto, int cantidadProducto) {
            this.generarPresupuestoAsync(SoapKey, fechaPresupuesto, id, referenciaProducto, cantidadProducto, null);
        }
        
        /// <remarks/>
        public void generarPresupuestoAsync(string SoapKey, System.DateTime fechaPresupuesto, int id, string referenciaProducto, int cantidadProducto, object userState) {
            if ((this.generarPresupuestoOperationCompleted == null)) {
                this.generarPresupuestoOperationCompleted = new System.Threading.SendOrPostCallback(this.OngenerarPresupuestoOperationCompleted);
            }
            this.InvokeAsync("generarPresupuesto", new object[] {
                        SoapKey,
                        fechaPresupuesto,
                        id,
                        referenciaProducto,
                        cantidadProducto}, this.generarPresupuestoOperationCompleted, userState);
        }
        
        private void OngenerarPresupuestoOperationCompleted(object arg) {
            if ((this.generarPresupuestoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.generarPresupuestoCompleted(this, new generarPresupuestoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/Pr1/solicitarPresupuesto", RequestNamespace="http://www.example.org/Pr1/", ResponseNamespace="http://www.example.org/Pr1/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("precioPieza", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float solicitarPresupuesto([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string referenciaPieza, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int idProveedor, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out bool disponibilidadPieza, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")] out System.DateTime fechaDisponibilidadPieza) {
            object[] results = this.Invoke("solicitarPresupuesto", new object[] {
                        SoapKey,
                        referenciaPieza,
                        idProveedor});
            disponibilidadPieza = ((bool)(results[1]));
            fechaDisponibilidadPieza = ((System.DateTime)(results[2]));
            return ((float)(results[0]));
        }
        
        /// <remarks/>
        public void solicitarPresupuestoAsync(string SoapKey, string referenciaPieza, int idProveedor) {
            this.solicitarPresupuestoAsync(SoapKey, referenciaPieza, idProveedor, null);
        }
        
        /// <remarks/>
        public void solicitarPresupuestoAsync(string SoapKey, string referenciaPieza, int idProveedor, object userState) {
            if ((this.solicitarPresupuestoOperationCompleted == null)) {
                this.solicitarPresupuestoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsolicitarPresupuestoOperationCompleted);
            }
            this.InvokeAsync("solicitarPresupuesto", new object[] {
                        SoapKey,
                        referenciaPieza,
                        idProveedor}, this.solicitarPresupuestoOperationCompleted, userState);
        }
        
        private void OnsolicitarPresupuestoOperationCompleted(object arg) {
            if ((this.solicitarPresupuestoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.solicitarPresupuestoCompleted(this, new solicitarPresupuestoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void ValidarNIFCompletedEventHandler(object sender, ValidarNIFCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidarNIFCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValidarNIFCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void ValidarIBANCompletedEventHandler(object sender, ValidarIBANCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidarIBANCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValidarIBANCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public string msg {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void consultaCodigoPostalCompletedEventHandler(object sender, consultaCodigoPostalCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class consultaCodigoPostalCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal consultaCodigoPostalCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public string poblacion {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string provincia {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void generarPresupuestoCompletedEventHandler(object sender, generarPresupuestoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class generarPresupuestoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal generarPresupuestoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public bool presupuestoGeneradoCorrectamente {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    public delegate void solicitarPresupuestoCompletedEventHandler(object sender, solicitarPresupuestoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1590.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class solicitarPresupuestoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal solicitarPresupuestoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public float Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool disponibilidadPieza {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public System.DateTime fechaDisponibilidadPieza {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[2]));
            }
        }
    }
}

#pragma warning restore 1591