﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSite.S_MiPrepago_Proveedor_Rest {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ModeloProveedor", Namespace="http://schemas.datacontract.org/2004/07/WS_MiPrepago.Dominio")]
    [System.SerializableAttribute()]
    public partial class ModeloProveedor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string anioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int marcaIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float precioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string proveedorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int proveedor_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int stockField;
        
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
        public string anio {
            get {
                return this.anioField;
            }
            set {
                if ((object.ReferenceEquals(this.anioField, value) != true)) {
                    this.anioField = value;
                    this.RaisePropertyChanged("anio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int marcaId {
            get {
                return this.marcaIdField;
            }
            set {
                if ((this.marcaIdField.Equals(value) != true)) {
                    this.marcaIdField = value;
                    this.RaisePropertyChanged("marcaId");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float precio {
            get {
                return this.precioField;
            }
            set {
                if ((this.precioField.Equals(value) != true)) {
                    this.precioField = value;
                    this.RaisePropertyChanged("precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string proveedor {
            get {
                return this.proveedorField;
            }
            set {
                if ((object.ReferenceEquals(this.proveedorField, value) != true)) {
                    this.proveedorField = value;
                    this.RaisePropertyChanged("proveedor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int proveedor_id {
            get {
                return this.proveedor_idField;
            }
            set {
                if ((this.proveedor_idField.Equals(value) != true)) {
                    this.proveedor_idField = value;
                    this.RaisePropertyChanged("proveedor_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int stock {
            get {
                return this.stockField;
            }
            set {
                if ((this.stockField.Equals(value) != true)) {
                    this.stockField = value;
                    this.RaisePropertyChanged("stock");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Reserva", Namespace="http://schemas.datacontract.org/2004/07/WS_MiPrepago.Dominio")]
    [System.SerializableAttribute()]
    public partial class Reserva : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string celularField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codigoReservaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int modeloIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string proveedorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int proveedor_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int reserva_idField;
        
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
        public string apellido {
            get {
                return this.apellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.apellidoField, value) != true)) {
                    this.apellidoField = value;
                    this.RaisePropertyChanged("apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cantidad {
            get {
                return this.cantidadField;
            }
            set {
                if ((this.cantidadField.Equals(value) != true)) {
                    this.cantidadField = value;
                    this.RaisePropertyChanged("cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string celular {
            get {
                return this.celularField;
            }
            set {
                if ((object.ReferenceEquals(this.celularField, value) != true)) {
                    this.celularField = value;
                    this.RaisePropertyChanged("celular");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string codigoReserva {
            get {
                return this.codigoReservaField;
            }
            set {
                if ((object.ReferenceEquals(this.codigoReservaField, value) != true)) {
                    this.codigoReservaField = value;
                    this.RaisePropertyChanged("codigoReserva");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int modeloId {
            get {
                return this.modeloIdField;
            }
            set {
                if ((this.modeloIdField.Equals(value) != true)) {
                    this.modeloIdField = value;
                    this.RaisePropertyChanged("modeloId");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string proveedor {
            get {
                return this.proveedorField;
            }
            set {
                if ((object.ReferenceEquals(this.proveedorField, value) != true)) {
                    this.proveedorField = value;
                    this.RaisePropertyChanged("proveedor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int proveedor_id {
            get {
                return this.proveedor_idField;
            }
            set {
                if ((this.proveedor_idField.Equals(value) != true)) {
                    this.proveedor_idField = value;
                    this.RaisePropertyChanged("proveedor_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int reserva_id {
            get {
                return this.reserva_idField;
            }
            set {
                if ((this.reserva_idField.Equals(value) != true)) {
                    this.reserva_idField = value;
                    this.RaisePropertyChanged("reserva_id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="S_MiPrepago_Proveedor_Rest.IProveedorService")]
    public interface IProveedorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProveedorService/consultarDisponibilidad", ReplyAction="http://tempuri.org/IProveedorService/consultarDisponibilidadResponse")]
        WebSite.S_MiPrepago_Proveedor_Rest.ModeloProveedor[] consultarDisponibilidad(string marca, string modelo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProveedorService/consultarDisponibilidad", ReplyAction="http://tempuri.org/IProveedorService/consultarDisponibilidadResponse")]
        System.Threading.Tasks.Task<WebSite.S_MiPrepago_Proveedor_Rest.ModeloProveedor[]> consultarDisponibilidadAsync(string marca, string modelo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProveedorService/crearReserva", ReplyAction="http://tempuri.org/IProveedorService/crearReservaResponse")]
        WebSite.S_MiPrepago_Proveedor_Rest.Reserva crearReserva(WebSite.S_MiPrepago_Proveedor_Rest.Reserva reservaAcrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProveedorService/crearReserva", ReplyAction="http://tempuri.org/IProveedorService/crearReservaResponse")]
        System.Threading.Tasks.Task<WebSite.S_MiPrepago_Proveedor_Rest.Reserva> crearReservaAsync(WebSite.S_MiPrepago_Proveedor_Rest.Reserva reservaAcrear);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProveedorServiceChannel : WebSite.S_MiPrepago_Proveedor_Rest.IProveedorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProveedorServiceClient : System.ServiceModel.ClientBase<WebSite.S_MiPrepago_Proveedor_Rest.IProveedorService>, WebSite.S_MiPrepago_Proveedor_Rest.IProveedorService {
        
        public ProveedorServiceClient() {
        }
        
        public ProveedorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProveedorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProveedorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProveedorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebSite.S_MiPrepago_Proveedor_Rest.ModeloProveedor[] consultarDisponibilidad(string marca, string modelo) {
            return base.Channel.consultarDisponibilidad(marca, modelo);
        }
        
        public System.Threading.Tasks.Task<WebSite.S_MiPrepago_Proveedor_Rest.ModeloProveedor[]> consultarDisponibilidadAsync(string marca, string modelo) {
            return base.Channel.consultarDisponibilidadAsync(marca, modelo);
        }
        
        public WebSite.S_MiPrepago_Proveedor_Rest.Reserva crearReserva(WebSite.S_MiPrepago_Proveedor_Rest.Reserva reservaAcrear) {
            return base.Channel.crearReserva(reservaAcrear);
        }
        
        public System.Threading.Tasks.Task<WebSite.S_MiPrepago_Proveedor_Rest.Reserva> crearReservaAsync(WebSite.S_MiPrepago_Proveedor_Rest.Reserva reservaAcrear) {
            return base.Channel.crearReservaAsync(reservaAcrear);
        }
    }
}
