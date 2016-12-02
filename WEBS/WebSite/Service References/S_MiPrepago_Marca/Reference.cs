﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSite.S_MiPrepago_Marca {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Marca", Namespace="http://schemas.datacontract.org/2004/07/WS_MiPrepago.Dominio")]
    [System.SerializableAttribute()]
    public partial class Marca : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int marca_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int marca_id {
            get {
                return this.marca_idField;
            }
            set {
                if ((this.marca_idField.Equals(value) != true)) {
                    this.marca_idField = value;
                    this.RaisePropertyChanged("marca_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WS_MiPrepago.Errores")]
    [System.SerializableAttribute()]
    public partial class RepetidoException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descripcionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string codigo {
            get {
                return this.codigoField;
            }
            set {
                if ((object.ReferenceEquals(this.codigoField, value) != true)) {
                    this.codigoField = value;
                    this.RaisePropertyChanged("codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.descripcionField, value) != true)) {
                    this.descripcionField = value;
                    this.RaisePropertyChanged("descripcion");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="S_MiPrepago_Marca.IMarcas")]
    public interface IMarcas {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcas/crearMarca", ReplyAction="http://tempuri.org/IMarcas/crearMarcaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WebSite.S_MiPrepago_Marca.RepetidoException), Action="http://tempuri.org/IMarcas/crearMarcaRepetidoExceptionFault", Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WS_MiPrepago.Errores")]
        WebSite.S_MiPrepago_Marca.Marca crearMarca(WebSite.S_MiPrepago_Marca.Marca marcaACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcas/crearMarca", ReplyAction="http://tempuri.org/IMarcas/crearMarcaResponse")]
        System.Threading.Tasks.Task<WebSite.S_MiPrepago_Marca.Marca> crearMarcaAsync(WebSite.S_MiPrepago_Marca.Marca marcaACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcas/ObtenerMarca", ReplyAction="http://tempuri.org/IMarcas/ObtenerMarcaResponse")]
        WebSite.S_MiPrepago_Marca.Marca ObtenerMarca(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcas/ObtenerMarca", ReplyAction="http://tempuri.org/IMarcas/ObtenerMarcaResponse")]
        System.Threading.Tasks.Task<WebSite.S_MiPrepago_Marca.Marca> ObtenerMarcaAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcas/listarMarca", ReplyAction="http://tempuri.org/IMarcas/listarMarcaResponse")]
        WebSite.S_MiPrepago_Marca.Marca[] listarMarca();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcas/listarMarca", ReplyAction="http://tempuri.org/IMarcas/listarMarcaResponse")]
        System.Threading.Tasks.Task<WebSite.S_MiPrepago_Marca.Marca[]> listarMarcaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcas/calcular", ReplyAction="http://tempuri.org/IMarcas/calcularResponse")]
        string calcular(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcas/calcular", ReplyAction="http://tempuri.org/IMarcas/calcularResponse")]
        System.Threading.Tasks.Task<string> calcularAsync(int number);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMarcasChannel : WebSite.S_MiPrepago_Marca.IMarcas, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MarcasClient : System.ServiceModel.ClientBase<WebSite.S_MiPrepago_Marca.IMarcas>, WebSite.S_MiPrepago_Marca.IMarcas {
        
        public MarcasClient() {
        }
        
        public MarcasClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MarcasClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MarcasClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MarcasClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebSite.S_MiPrepago_Marca.Marca crearMarca(WebSite.S_MiPrepago_Marca.Marca marcaACrear) {
            return base.Channel.crearMarca(marcaACrear);
        }
        
        public System.Threading.Tasks.Task<WebSite.S_MiPrepago_Marca.Marca> crearMarcaAsync(WebSite.S_MiPrepago_Marca.Marca marcaACrear) {
            return base.Channel.crearMarcaAsync(marcaACrear);
        }
        
        public WebSite.S_MiPrepago_Marca.Marca ObtenerMarca(int Id) {
            return base.Channel.ObtenerMarca(Id);
        }
        
        public System.Threading.Tasks.Task<WebSite.S_MiPrepago_Marca.Marca> ObtenerMarcaAsync(int Id) {
            return base.Channel.ObtenerMarcaAsync(Id);
        }
        
        public WebSite.S_MiPrepago_Marca.Marca[] listarMarca() {
            return base.Channel.listarMarca();
        }
        
        public System.Threading.Tasks.Task<WebSite.S_MiPrepago_Marca.Marca[]> listarMarcaAsync() {
            return base.Channel.listarMarcaAsync();
        }
        
        public string calcular(int number) {
            return base.Channel.calcular(number);
        }
        
        public System.Threading.Tasks.Task<string> calcularAsync(int number) {
            return base.Channel.calcularAsync(number);
        }
    }
}
