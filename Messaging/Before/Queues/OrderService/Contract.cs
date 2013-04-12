using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Transactions;

namespace DM
{
    [ServiceContract(   Name = "IOrderService",
                        Namespace = "urn:dm:demos", 
                        ConfigurationName = "IOrderService",
                        SessionMode=SessionMode.Required)]
    interface IOrderService
    {
        [OperationContract( Name = "StartPlaceOrder",
                            Action = "StartPlaceOrder",
                            IsOneWay = true, 
                            IsInitiating=true,IsTerminating=false)]
        void StartPlaceOrder(string data);

        [OperationContract( Name = "AddOrderItem",
                            Action = "AddOrderItem",
                            IsOneWay = true,
                            IsInitiating=false, IsTerminating=false)]
        void AddOrderItem(string item, int quantity);

        [OperationContract( Name = "FinishedPlaceOrder",
                            Action = "FinishedPlaceOrder",
                            IsOneWay = true,
                            IsInitiating=false, IsTerminating=true)]
        void FinishedPlaceOrder();
    }
}