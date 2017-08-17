﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteTest.CardValidatorReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost/SmartPayments/", ConfigurationName="CardValidatorReference.CreditCardValidatorSoap")]
    public interface CreditCardValidatorSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/GetCardType", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetCardType(string CardNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/GetCardType", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetCardTypeAsync(string CardNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/IsCommercialCard", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool IsCommercialCard(string CardNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/IsCommercialCard", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> IsCommercialCardAsync(string CardNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/ValidCard", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int ValidCard(string CardNumber, string ExpDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/ValidCard", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ValidCardAsync(string CardNumber, string ExpDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/ValidCardLength", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool ValidCardLength(string CardNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/ValidCardLength", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ValidCardLengthAsync(string CardNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/ValidExpDate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool ValidExpDate(string ExpDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/ValidExpDate", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ValidExpDateAsync(string ExpDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/ValidMod10", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool ValidMod10(string CardNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/ValidMod10", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ValidMod10Async(string CardNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/GetNetworkID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WebsiteTest.CardValidatorReference.Response GetNetworkID(string UserName, string Password, string CardNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/GetNetworkID", ReplyAction="*")]
        System.Threading.Tasks.Task<WebsiteTest.CardValidatorReference.Response> GetNetworkIDAsync(string UserName, string Password, string CardNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/IsFSACard", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool IsFSACard(string CardNumber, string PNRef, string Vendor, string CcInfoKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/IsFSACard", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> IsFSACardAsync(string CardNumber, string PNRef, string Vendor, string CcInfoKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/IsValidCheckRoutingNumber", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool IsValidCheckRoutingNumber(string RoutingNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/IsValidCheckRoutingNumber", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> IsValidCheckRoutingNumberAsync(string RoutingNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/IsDebitCard", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Xml.XmlNode IsDebitCard(string CardNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/SmartPayments/IsDebitCard", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Xml.XmlNode> IsDebitCardAsync(string CardNumber);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://localhost/SmartPayments/")]
    public partial class Response : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int resultField;
        
        private string respMSGField;
        
        private string messageField;
        
        private string message1Field;
        
        private string message2Field;
        
        private string authCodeField;
        
        private string pNRefField;
        
        private string hostCodeField;
        
        private string hostURLField;
        
        private string receiptURLField;
        
        private string getAVSResultField;
        
        private string getAVSResultTXTField;
        
        private string getStreetMatchTXTField;
        
        private string getZipMatchTXTField;
        
        private string getCVResultField;
        
        private string getCVResultTXTField;
        
        private string getGetOrigResultField;
        
        private string getCommercialCardField;
        
        private string workingKeyField;
        
        private string keyPointerField;
        
        private string extDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
                this.RaisePropertyChanged("Result");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string RespMSG {
            get {
                return this.respMSGField;
            }
            set {
                this.respMSGField = value;
                this.RaisePropertyChanged("RespMSG");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("Message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Message1 {
            get {
                return this.message1Field;
            }
            set {
                this.message1Field = value;
                this.RaisePropertyChanged("Message1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Message2 {
            get {
                return this.message2Field;
            }
            set {
                this.message2Field = value;
                this.RaisePropertyChanged("Message2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string AuthCode {
            get {
                return this.authCodeField;
            }
            set {
                this.authCodeField = value;
                this.RaisePropertyChanged("AuthCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string PNRef {
            get {
                return this.pNRefField;
            }
            set {
                this.pNRefField = value;
                this.RaisePropertyChanged("PNRef");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string HostCode {
            get {
                return this.hostCodeField;
            }
            set {
                this.hostCodeField = value;
                this.RaisePropertyChanged("HostCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string HostURL {
            get {
                return this.hostURLField;
            }
            set {
                this.hostURLField = value;
                this.RaisePropertyChanged("HostURL");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string ReceiptURL {
            get {
                return this.receiptURLField;
            }
            set {
                this.receiptURLField = value;
                this.RaisePropertyChanged("ReceiptURL");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string GetAVSResult {
            get {
                return this.getAVSResultField;
            }
            set {
                this.getAVSResultField = value;
                this.RaisePropertyChanged("GetAVSResult");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string GetAVSResultTXT {
            get {
                return this.getAVSResultTXTField;
            }
            set {
                this.getAVSResultTXTField = value;
                this.RaisePropertyChanged("GetAVSResultTXT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string GetStreetMatchTXT {
            get {
                return this.getStreetMatchTXTField;
            }
            set {
                this.getStreetMatchTXTField = value;
                this.RaisePropertyChanged("GetStreetMatchTXT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string GetZipMatchTXT {
            get {
                return this.getZipMatchTXTField;
            }
            set {
                this.getZipMatchTXTField = value;
                this.RaisePropertyChanged("GetZipMatchTXT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string GetCVResult {
            get {
                return this.getCVResultField;
            }
            set {
                this.getCVResultField = value;
                this.RaisePropertyChanged("GetCVResult");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string GetCVResultTXT {
            get {
                return this.getCVResultTXTField;
            }
            set {
                this.getCVResultTXTField = value;
                this.RaisePropertyChanged("GetCVResultTXT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string GetGetOrigResult {
            get {
                return this.getGetOrigResultField;
            }
            set {
                this.getGetOrigResultField = value;
                this.RaisePropertyChanged("GetGetOrigResult");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string GetCommercialCard {
            get {
                return this.getCommercialCardField;
            }
            set {
                this.getCommercialCardField = value;
                this.RaisePropertyChanged("GetCommercialCard");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string WorkingKey {
            get {
                return this.workingKeyField;
            }
            set {
                this.workingKeyField = value;
                this.RaisePropertyChanged("WorkingKey");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public string KeyPointer {
            get {
                return this.keyPointerField;
            }
            set {
                this.keyPointerField = value;
                this.RaisePropertyChanged("KeyPointer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public string ExtData {
            get {
                return this.extDataField;
            }
            set {
                this.extDataField = value;
                this.RaisePropertyChanged("ExtData");
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
    public interface CreditCardValidatorSoapChannel : WebsiteTest.CardValidatorReference.CreditCardValidatorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreditCardValidatorSoapClient : System.ServiceModel.ClientBase<WebsiteTest.CardValidatorReference.CreditCardValidatorSoap>, WebsiteTest.CardValidatorReference.CreditCardValidatorSoap {
        
        public CreditCardValidatorSoapClient() {
        }
        
        public CreditCardValidatorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CreditCardValidatorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreditCardValidatorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreditCardValidatorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetCardType(string CardNumber) {
            return base.Channel.GetCardType(CardNumber);
        }
        
        public System.Threading.Tasks.Task<string> GetCardTypeAsync(string CardNumber) {
            return base.Channel.GetCardTypeAsync(CardNumber);
        }
        
        public bool IsCommercialCard(string CardNumber) {
            return base.Channel.IsCommercialCard(CardNumber);
        }
        
        public System.Threading.Tasks.Task<bool> IsCommercialCardAsync(string CardNumber) {
            return base.Channel.IsCommercialCardAsync(CardNumber);
        }
        
        public int ValidCard(string CardNumber, string ExpDate) {
            return base.Channel.ValidCard(CardNumber, ExpDate);
        }
        
        public System.Threading.Tasks.Task<int> ValidCardAsync(string CardNumber, string ExpDate) {
            return base.Channel.ValidCardAsync(CardNumber, ExpDate);
        }
        
        public bool ValidCardLength(string CardNumber) {
            return base.Channel.ValidCardLength(CardNumber);
        }
        
        public System.Threading.Tasks.Task<bool> ValidCardLengthAsync(string CardNumber) {
            return base.Channel.ValidCardLengthAsync(CardNumber);
        }
        
        public bool ValidExpDate(string ExpDate) {
            return base.Channel.ValidExpDate(ExpDate);
        }
        
        public System.Threading.Tasks.Task<bool> ValidExpDateAsync(string ExpDate) {
            return base.Channel.ValidExpDateAsync(ExpDate);
        }
        
        public bool ValidMod10(string CardNumber) {
            return base.Channel.ValidMod10(CardNumber);
        }
        
        public System.Threading.Tasks.Task<bool> ValidMod10Async(string CardNumber) {
            return base.Channel.ValidMod10Async(CardNumber);
        }
        
        public WebsiteTest.CardValidatorReference.Response GetNetworkID(string UserName, string Password, string CardNumber) {
            return base.Channel.GetNetworkID(UserName, Password, CardNumber);
        }
        
        public System.Threading.Tasks.Task<WebsiteTest.CardValidatorReference.Response> GetNetworkIDAsync(string UserName, string Password, string CardNumber) {
            return base.Channel.GetNetworkIDAsync(UserName, Password, CardNumber);
        }
        
        public bool IsFSACard(string CardNumber, string PNRef, string Vendor, string CcInfoKey) {
            return base.Channel.IsFSACard(CardNumber, PNRef, Vendor, CcInfoKey);
        }
        
        public System.Threading.Tasks.Task<bool> IsFSACardAsync(string CardNumber, string PNRef, string Vendor, string CcInfoKey) {
            return base.Channel.IsFSACardAsync(CardNumber, PNRef, Vendor, CcInfoKey);
        }
        
        public bool IsValidCheckRoutingNumber(string RoutingNumber) {
            return base.Channel.IsValidCheckRoutingNumber(RoutingNumber);
        }
        
        public System.Threading.Tasks.Task<bool> IsValidCheckRoutingNumberAsync(string RoutingNumber) {
            return base.Channel.IsValidCheckRoutingNumberAsync(RoutingNumber);
        }
        
        public System.Xml.XmlNode IsDebitCard(string CardNumber) {
            return base.Channel.IsDebitCard(CardNumber);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlNode> IsDebitCardAsync(string CardNumber) {
            return base.Channel.IsDebitCardAsync(CardNumber);
        }
    }
}
