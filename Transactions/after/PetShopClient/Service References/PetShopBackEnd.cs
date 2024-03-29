﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetShopClient.PetShopBackEnd
{
    using System.Runtime.Serialization;
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:dm:petshop:data")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName
        {
            get
            {
                return this.ProductNameField;
            }
            set
            {
                this.ProductNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity
        {
            get
            {
                return this.QuantityField;
            }
            set
            {
                this.QuantityField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:dm:petshop:data")]
    [System.SerializableAttribute()]
    public partial class Inventory : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, PetShopClient.PetShopBackEnd.AnimalDetails> ItemsField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, PetShopClient.PetShopBackEnd.AnimalDetails> Items
        {
            get
            {
                return this.ItemsField;
            }
            set
            {
                this.ItemsField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:dm:petshop:data")]
    [System.SerializableAttribute()]
    public partial class AnimalDetails : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int InStockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int InStock
        {
            get
            {
                return this.InStockField;
            }
            set
            {
                this.InStockField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price
        {
            get
            {
                return this.PriceField;
            }
            set
            {
                this.PriceField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:dm:petshop:data")]
    [System.SerializableAttribute()]
    public partial class AccountBalance : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BalanceField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Balance
        {
            get
            {
                return this.BalanceField;
            }
            set
            {
                this.BalanceField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:dm:petshop:data")]
    [System.SerializableAttribute()]
    public partial class OrderFault : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:dm:petshop:services", ConfigurationName="PetShopClient.PetShopBackEnd.PetShopServiceContract", SessionMode=System.ServiceModel.SessionMode.NotAllowed)]
    public interface PetShopServiceContract
    {
        
        // CODEGEN: Generating message contract since the operation PlaceOrder is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="Placeorder", ReplyAction="PlaceOrderReply")]
        [System.ServiceModel.FaultContractAttribute(typeof(PetShopClient.PetShopBackEnd.OrderFault), Action="OrderFault", Name="OrderFault", Namespace="urn:dm:petshop:data")]
        PetShopClient.PetShopBackEnd.PlaceOrderResponse PlaceOrder(PetShopClient.PetShopBackEnd.OrderMessage request);
        
        // CODEGEN: Generating message contract since the operation GetInventory is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="GetInventory", ReplyAction="GetInventoryReply")]
        PetShopClient.PetShopBackEnd.InventoryMessageResponse GetInventory(PetShopClient.PetShopBackEnd.GetInventoryRequest request);
        
        // CODEGEN: Generating message contract since the operation GetAccountBalance is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="GetAccountBalance", ReplyAction="GetAccountBalanceReply")]
        PetShopClient.PetShopBackEnd.AccountBalanceMessageResponse GetAccountBalance(PetShopClient.PetShopBackEnd.GetAccountBalanceRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OrderMessage
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:dm:petshop:messages", Order=0)]
        public PetShopClient.PetShopBackEnd.Order Order;
        
        public OrderMessage()
        {
        }
        
        public OrderMessage(PetShopClient.PetShopBackEnd.Order Order)
        {
            this.Order = Order;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PlaceOrderResponse
    {
        
        public PlaceOrderResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInventoryRequest
    {
        
        public GetInventoryRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InventoryMessageResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:dm:petshop:messages", Order=0)]
        public PetShopClient.PetShopBackEnd.Inventory Inventory;
        
        public InventoryMessageResponse()
        {
        }
        
        public InventoryMessageResponse(PetShopClient.PetShopBackEnd.Inventory Inventory)
        {
            this.Inventory = Inventory;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAccountBalanceRequest
    {
        
        public GetAccountBalanceRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AccountBalanceMessageResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:dm:petshop:messages", Order=0)]
        public PetShopClient.PetShopBackEnd.AccountBalance Account;
        
        public AccountBalanceMessageResponse()
        {
        }
        
        public AccountBalanceMessageResponse(PetShopClient.PetShopBackEnd.AccountBalance Account)
        {
            this.Account = Account;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface PetShopServiceContractChannel : PetShopClient.PetShopBackEnd.PetShopServiceContract, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class PetShopServiceContractClient : System.ServiceModel.ClientBase<PetShopClient.PetShopBackEnd.PetShopServiceContract>, PetShopClient.PetShopBackEnd.PetShopServiceContract
    {
        
        public PetShopServiceContractClient()
        {
        }
        
        public PetShopServiceContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public PetShopServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public PetShopServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public PetShopServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        PetShopClient.PetShopBackEnd.PlaceOrderResponse PetShopClient.PetShopBackEnd.PetShopServiceContract.PlaceOrder(PetShopClient.PetShopBackEnd.OrderMessage request)
        {
            return base.Channel.PlaceOrder(request);
        }
        
        public void PlaceOrder(PetShopClient.PetShopBackEnd.Order Order)
        {
            PetShopClient.PetShopBackEnd.OrderMessage inValue = new PetShopClient.PetShopBackEnd.OrderMessage();
            inValue.Order = Order;
            PetShopClient.PetShopBackEnd.PlaceOrderResponse retVal = ((PetShopClient.PetShopBackEnd.PetShopServiceContract)(this)).PlaceOrder(inValue);
        }
        
        PetShopClient.PetShopBackEnd.InventoryMessageResponse PetShopClient.PetShopBackEnd.PetShopServiceContract.GetInventory(PetShopClient.PetShopBackEnd.GetInventoryRequest request)
        {
            return base.Channel.GetInventory(request);
        }
        
        public PetShopClient.PetShopBackEnd.Inventory GetInventory()
        {
            PetShopClient.PetShopBackEnd.GetInventoryRequest inValue = new PetShopClient.PetShopBackEnd.GetInventoryRequest();
            PetShopClient.PetShopBackEnd.InventoryMessageResponse retVal = ((PetShopClient.PetShopBackEnd.PetShopServiceContract)(this)).GetInventory(inValue);
            return retVal.Inventory;
        }
        
        PetShopClient.PetShopBackEnd.AccountBalanceMessageResponse PetShopClient.PetShopBackEnd.PetShopServiceContract.GetAccountBalance(PetShopClient.PetShopBackEnd.GetAccountBalanceRequest request)
        {
            return base.Channel.GetAccountBalance(request);
        }
        
        public PetShopClient.PetShopBackEnd.AccountBalance GetAccountBalance()
        {
            PetShopClient.PetShopBackEnd.GetAccountBalanceRequest inValue = new PetShopClient.PetShopBackEnd.GetAccountBalanceRequest();
            PetShopClient.PetShopBackEnd.AccountBalanceMessageResponse retVal = ((PetShopClient.PetShopBackEnd.PetShopServiceContract)(this)).GetAccountBalance(inValue);
            return retVal.Account;
        }
    }
}
