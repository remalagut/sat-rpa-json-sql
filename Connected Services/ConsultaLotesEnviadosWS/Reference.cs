﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Net;

namespace SATRpaToJson.ConsultaLotesEnviadosWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.fazenda.sp.gov.br/sat/wsdl/CfeConsultaLotes", ConfigurationName="ConsultaLotesEnviadosWS.CfeConsultaLotesSoap")]
    public interface CfeConsultaLotesSoap {
        
        // CODEGEN: Generating message contract since the wrapper name (CfeConsultarLotes) of message CfeConsultarLotes does not match the default value (ConsultarLotesEnviados)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.fazenda.sp.gov.br/sat/wsdl/CfeConsultar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultarLotes1 ConsultarLotesEnviados(SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultarLotes request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.fazenda.sp.gov.br/sat/wsdl/CfeConsultar", ReplyAction="*")]
        System.Threading.Tasks.Task<SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultarLotes1> ConsultarLotesEnviadosAsync(SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultarLotes request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.fazenda.sp.gov.br/sat/wsdl/CfeConsultaLotes")]
    public partial class CfeCabecMsgSoapEntity : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cUFField;
        
        private string versaoDadosField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string cUF {
            get {
                return this.cUFField;
            }
            set {
                this.cUFField = value;
                this.RaisePropertyChanged("cUF");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string versaoDados {
            get {
                return this.versaoDadosField;
            }
            set {
                this.versaoDadosField = value;
                this.RaisePropertyChanged("versaoDados");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CfeConsultarLotes", WrapperNamespace="http://www.fazenda.sp.gov.br/sat/wsdl/CfeConsultaLotes", IsWrapped=true)]
    public partial class CfeConsultarLotes {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.fazenda.sp.gov.br/sat/wsdl/CfeConsultaLotes")]
        public SATRpaToJson.ConsultaLotesEnviadosWS.CfeCabecMsgSoapEntity cfeCabecMsg;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fazenda.sp.gov.br/sat/wsdl/CfeConsultaLotes", Order=0)]
        public string cfeDadosMsg;
        
        public CfeConsultarLotes() {
        }
        
        public CfeConsultarLotes(SATRpaToJson.ConsultaLotesEnviadosWS.CfeCabecMsgSoapEntity cfeCabecMsg, string cfeDadosMsg) {
            this.cfeCabecMsg = cfeCabecMsg;
            this.cfeDadosMsg = cfeDadosMsg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CfeConsultarLotesResponse", WrapperNamespace="http://www.fazenda.sp.gov.br/sat/wsdl/CfeConsultaLotes", IsWrapped=true)]
    public partial class CfeConsultarLotes1 {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.fazenda.sp.gov.br/sat/wsdl/CfeConsultaLotes")]
        public SATRpaToJson.ConsultaLotesEnviadosWS.CfeCabecMsgSoapEntity cfeCabecMsg;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.fazenda.sp.gov.br/sat/wsdl/CfeConsultaLotes", Order=0)]
        public string CfeConsultarLotesResult;
        
        public CfeConsultarLotes1() {
        }
        
        public CfeConsultarLotes1(SATRpaToJson.ConsultaLotesEnviadosWS.CfeCabecMsgSoapEntity cfeCabecMsg, string CfeConsultarLotesResult) {
            this.cfeCabecMsg = cfeCabecMsg;
            this.CfeConsultarLotesResult = CfeConsultarLotesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CfeConsultaLotesSoapChannel : SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultaLotesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CfeConsultaLotesSoapClient : System.ServiceModel.ClientBase<SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultaLotesSoap>, SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultaLotesSoap {
        
        public CfeConsultaLotesSoapClient() {
            ServicePointManager.ServerCertificateValidationCallback += (mender, certificate, chain, sslPolicyErrors) => true;
        }
        
        public CfeConsultaLotesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CfeConsultaLotesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CfeConsultaLotesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CfeConsultaLotesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultarLotes1 SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultaLotesSoap.ConsultarLotesEnviados(SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultarLotes request) {
            return base.Channel.ConsultarLotesEnviados(request);
        }
        
        public string ConsultarLotesEnviados(ref SATRpaToJson.ConsultaLotesEnviadosWS.CfeCabecMsgSoapEntity cfeCabecMsg, string cfeDadosMsg) {
            SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultarLotes inValue = new SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultarLotes();
            inValue.cfeCabecMsg = cfeCabecMsg;
            inValue.cfeDadosMsg = cfeDadosMsg;
            SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultarLotes1 retVal = ((SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultaLotesSoap)(this)).ConsultarLotesEnviados(inValue);
            cfeCabecMsg = retVal.cfeCabecMsg;
            return retVal.CfeConsultarLotesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultarLotes1> SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultaLotesSoap.ConsultarLotesEnviadosAsync(SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultarLotes request) {
            this.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = System.ServiceModel.Security.X509CertificateValidationMode.None;
            return base.Channel.ConsultarLotesEnviadosAsync(request);
        }
        
        public System.Threading.Tasks.Task<SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultarLotes1> ConsultarLotesEnviadosAsync(SATRpaToJson.ConsultaLotesEnviadosWS.CfeCabecMsgSoapEntity cfeCabecMsg, string cfeDadosMsg) {
            SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultarLotes inValue = new SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultarLotes();
            inValue.cfeCabecMsg = cfeCabecMsg;
            inValue.cfeDadosMsg = cfeDadosMsg;
            return ((SATRpaToJson.ConsultaLotesEnviadosWS.CfeConsultaLotesSoap)(this)).ConsultarLotesEnviadosAsync(inValue);
        }
    }
}