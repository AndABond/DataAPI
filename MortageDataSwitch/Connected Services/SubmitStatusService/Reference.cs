﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MortageDataSwitch.SubmitStatusService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService", ConfigurationName="SubmitStatusService.SubmitStatusServiceSoap")]
    public interface SubmitStatusServiceSoap {
        
        // CODEGEN: Generating message contract since element name requestXML from namespace http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService/GetApplication" +
            "Status", ReplyAction="*")]
        MortageDataSwitch.SubmitStatusService.GetApplicationStatusResponse GetApplicationStatus(MortageDataSwitch.SubmitStatusService.GetApplicationStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService/GetApplication" +
            "Status", ReplyAction="*")]
        System.Threading.Tasks.Task<MortageDataSwitch.SubmitStatusService.GetApplicationStatusResponse> GetApplicationStatusAsync(MortageDataSwitch.SubmitStatusService.GetApplicationStatusRequest request);
        
        // CODEGEN: Generating message contract since element name requestXML from namespace http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService/GetApplication" +
            "Statuses", ReplyAction="*")]
        MortageDataSwitch.SubmitStatusService.GetApplicationStatusesResponse GetApplicationStatuses(MortageDataSwitch.SubmitStatusService.GetApplicationStatusesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService/GetApplication" +
            "Statuses", ReplyAction="*")]
        System.Threading.Tasks.Task<MortageDataSwitch.SubmitStatusService.GetApplicationStatusesResponse> GetApplicationStatusesAsync(MortageDataSwitch.SubmitStatusService.GetApplicationStatusesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetApplicationStatusRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetApplicationStatus", Namespace="http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService", Order=0)]
        public MortageDataSwitch.SubmitStatusService.GetApplicationStatusRequestBody Body;
        
        public GetApplicationStatusRequest() {
        }
        
        public GetApplicationStatusRequest(MortageDataSwitch.SubmitStatusService.GetApplicationStatusRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService")]
    public partial class GetApplicationStatusRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string requestXML;
        
        public GetApplicationStatusRequestBody() {
        }
        
        public GetApplicationStatusRequestBody(string requestXML) {
            this.requestXML = requestXML;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetApplicationStatusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetApplicationStatusResponse", Namespace="http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService", Order=0)]
        public MortageDataSwitch.SubmitStatusService.GetApplicationStatusResponseBody Body;
        
        public GetApplicationStatusResponse() {
        }
        
        public GetApplicationStatusResponse(MortageDataSwitch.SubmitStatusService.GetApplicationStatusResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService")]
    public partial class GetApplicationStatusResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetApplicationStatusResult;
        
        public GetApplicationStatusResponseBody() {
        }
        
        public GetApplicationStatusResponseBody(string GetApplicationStatusResult) {
            this.GetApplicationStatusResult = GetApplicationStatusResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetApplicationStatusesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetApplicationStatuses", Namespace="http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService", Order=0)]
        public MortageDataSwitch.SubmitStatusService.GetApplicationStatusesRequestBody Body;
        
        public GetApplicationStatusesRequest() {
        }
        
        public GetApplicationStatusesRequest(MortageDataSwitch.SubmitStatusService.GetApplicationStatusesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService")]
    public partial class GetApplicationStatusesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string requestXML;
        
        public GetApplicationStatusesRequestBody() {
        }
        
        public GetApplicationStatusesRequestBody(string requestXML) {
            this.requestXML = requestXML;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetApplicationStatusesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetApplicationStatusesResponse", Namespace="http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService", Order=0)]
        public MortageDataSwitch.SubmitStatusService.GetApplicationStatusesResponseBody Body;
        
        public GetApplicationStatusesResponse() {
        }
        
        public GetApplicationStatusesResponse(MortageDataSwitch.SubmitStatusService.GetApplicationStatusesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.unifiedplatform/Comcorp.WebServices/SubmitStatusService")]
    public partial class GetApplicationStatusesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetApplicationStatusesResult;
        
        public GetApplicationStatusesResponseBody() {
        }
        
        public GetApplicationStatusesResponseBody(string GetApplicationStatusesResult) {
            this.GetApplicationStatusesResult = GetApplicationStatusesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SubmitStatusServiceSoapChannel : MortageDataSwitch.SubmitStatusService.SubmitStatusServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SubmitStatusServiceSoapClient : System.ServiceModel.ClientBase<MortageDataSwitch.SubmitStatusService.SubmitStatusServiceSoap>, MortageDataSwitch.SubmitStatusService.SubmitStatusServiceSoap {
        
        public SubmitStatusServiceSoapClient() {
        }
        
        public SubmitStatusServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SubmitStatusServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubmitStatusServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubmitStatusServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MortageDataSwitch.SubmitStatusService.GetApplicationStatusResponse MortageDataSwitch.SubmitStatusService.SubmitStatusServiceSoap.GetApplicationStatus(MortageDataSwitch.SubmitStatusService.GetApplicationStatusRequest request) {
            return base.Channel.GetApplicationStatus(request);
        }
        
        public string GetApplicationStatus(string requestXML) {
            MortageDataSwitch.SubmitStatusService.GetApplicationStatusRequest inValue = new MortageDataSwitch.SubmitStatusService.GetApplicationStatusRequest();
            inValue.Body = new MortageDataSwitch.SubmitStatusService.GetApplicationStatusRequestBody();
            inValue.Body.requestXML = requestXML;
            MortageDataSwitch.SubmitStatusService.GetApplicationStatusResponse retVal = ((MortageDataSwitch.SubmitStatusService.SubmitStatusServiceSoap)(this)).GetApplicationStatus(inValue);
            return retVal.Body.GetApplicationStatusResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MortageDataSwitch.SubmitStatusService.GetApplicationStatusResponse> MortageDataSwitch.SubmitStatusService.SubmitStatusServiceSoap.GetApplicationStatusAsync(MortageDataSwitch.SubmitStatusService.GetApplicationStatusRequest request) {
            return base.Channel.GetApplicationStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<MortageDataSwitch.SubmitStatusService.GetApplicationStatusResponse> GetApplicationStatusAsync(string requestXML) {
            MortageDataSwitch.SubmitStatusService.GetApplicationStatusRequest inValue = new MortageDataSwitch.SubmitStatusService.GetApplicationStatusRequest();
            inValue.Body = new MortageDataSwitch.SubmitStatusService.GetApplicationStatusRequestBody();
            inValue.Body.requestXML = requestXML;
            return ((MortageDataSwitch.SubmitStatusService.SubmitStatusServiceSoap)(this)).GetApplicationStatusAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MortageDataSwitch.SubmitStatusService.GetApplicationStatusesResponse MortageDataSwitch.SubmitStatusService.SubmitStatusServiceSoap.GetApplicationStatuses(MortageDataSwitch.SubmitStatusService.GetApplicationStatusesRequest request) {
            return base.Channel.GetApplicationStatuses(request);
        }
        
        public string GetApplicationStatuses(string requestXML) {
            MortageDataSwitch.SubmitStatusService.GetApplicationStatusesRequest inValue = new MortageDataSwitch.SubmitStatusService.GetApplicationStatusesRequest();
            inValue.Body = new MortageDataSwitch.SubmitStatusService.GetApplicationStatusesRequestBody();
            inValue.Body.requestXML = requestXML;
            MortageDataSwitch.SubmitStatusService.GetApplicationStatusesResponse retVal = ((MortageDataSwitch.SubmitStatusService.SubmitStatusServiceSoap)(this)).GetApplicationStatuses(inValue);
            return retVal.Body.GetApplicationStatusesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MortageDataSwitch.SubmitStatusService.GetApplicationStatusesResponse> MortageDataSwitch.SubmitStatusService.SubmitStatusServiceSoap.GetApplicationStatusesAsync(MortageDataSwitch.SubmitStatusService.GetApplicationStatusesRequest request) {
            return base.Channel.GetApplicationStatusesAsync(request);
        }
        
        public System.Threading.Tasks.Task<MortageDataSwitch.SubmitStatusService.GetApplicationStatusesResponse> GetApplicationStatusesAsync(string requestXML) {
            MortageDataSwitch.SubmitStatusService.GetApplicationStatusesRequest inValue = new MortageDataSwitch.SubmitStatusService.GetApplicationStatusesRequest();
            inValue.Body = new MortageDataSwitch.SubmitStatusService.GetApplicationStatusesRequestBody();
            inValue.Body.requestXML = requestXML;
            return ((MortageDataSwitch.SubmitStatusService.SubmitStatusServiceSoap)(this)).GetApplicationStatusesAsync(inValue);
        }
    }
}