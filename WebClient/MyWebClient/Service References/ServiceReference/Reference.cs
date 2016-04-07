﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWebClient.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer.Models")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsRentedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIdField;
        
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
        public bool IsRented {
            get {
                return this.IsRentedField;
            }
            set {
                if ((this.IsRentedField.Equals(value) != true)) {
                    this.IsRentedField = value;
                    this.RaisePropertyChanged("IsRented");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IProductRentalService")]
    public interface IProductRentalService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRentalService/GetProduct", ReplyAction="http://tempuri.org/IProductRentalService/GetProductResponse")]
        MyWebClient.ServiceReference.Product GetProduct(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRentalService/GetProduct", ReplyAction="http://tempuri.org/IProductRentalService/GetProductResponse")]
        System.Threading.Tasks.Task<MyWebClient.ServiceReference.Product> GetProductAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRentalService/GetProducts", ReplyAction="http://tempuri.org/IProductRentalService/GetProductsResponse")]
        MyWebClient.ServiceReference.Product[] GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRentalService/GetProducts", ReplyAction="http://tempuri.org/IProductRentalService/GetProductsResponse")]
        System.Threading.Tasks.Task<MyWebClient.ServiceReference.Product[]> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRentalService/CreateProduct", ReplyAction="http://tempuri.org/IProductRentalService/CreateProductResponse")]
        void CreateProduct(MyWebClient.ServiceReference.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRentalService/CreateProduct", ReplyAction="http://tempuri.org/IProductRentalService/CreateProductResponse")]
        System.Threading.Tasks.Task CreateProductAsync(MyWebClient.ServiceReference.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRentalService/UpdateProduct", ReplyAction="http://tempuri.org/IProductRentalService/UpdateProductResponse")]
        void UpdateProduct(MyWebClient.ServiceReference.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRentalService/UpdateProduct", ReplyAction="http://tempuri.org/IProductRentalService/UpdateProductResponse")]
        System.Threading.Tasks.Task UpdateProductAsync(MyWebClient.ServiceReference.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRentalService/DeleteProduct", ReplyAction="http://tempuri.org/IProductRentalService/DeleteProductResponse")]
        void DeleteProduct(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductRentalService/DeleteProduct", ReplyAction="http://tempuri.org/IProductRentalService/DeleteProductResponse")]
        System.Threading.Tasks.Task DeleteProductAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductRentalServiceChannel : MyWebClient.ServiceReference.IProductRentalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductRentalServiceClient : System.ServiceModel.ClientBase<MyWebClient.ServiceReference.IProductRentalService>, MyWebClient.ServiceReference.IProductRentalService {
        
        public ProductRentalServiceClient() {
        }
        
        public ProductRentalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductRentalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductRentalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductRentalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MyWebClient.ServiceReference.Product GetProduct(int id) {
            return base.Channel.GetProduct(id);
        }
        
        public System.Threading.Tasks.Task<MyWebClient.ServiceReference.Product> GetProductAsync(int id) {
            return base.Channel.GetProductAsync(id);
        }
        
        public MyWebClient.ServiceReference.Product[] GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<MyWebClient.ServiceReference.Product[]> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public void CreateProduct(MyWebClient.ServiceReference.Product p) {
            base.Channel.CreateProduct(p);
        }
        
        public System.Threading.Tasks.Task CreateProductAsync(MyWebClient.ServiceReference.Product p) {
            return base.Channel.CreateProductAsync(p);
        }
        
        public void UpdateProduct(MyWebClient.ServiceReference.Product p) {
            base.Channel.UpdateProduct(p);
        }
        
        public System.Threading.Tasks.Task UpdateProductAsync(MyWebClient.ServiceReference.Product p) {
            return base.Channel.UpdateProductAsync(p);
        }
        
        public void DeleteProduct(int id) {
            base.Channel.DeleteProduct(id);
        }
        
        public System.Threading.Tasks.Task DeleteProductAsync(int id) {
            return base.Channel.DeleteProductAsync(id);
        }
    }
}
