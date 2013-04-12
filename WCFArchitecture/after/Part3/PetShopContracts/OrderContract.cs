using System.ServiceModel;

namespace DM.PetShop
{
    [ServiceContract(Name = "PetShopOrderContract", Namespace = Constants.SERVICE_NAMESPACE)]
    public interface IOrderContract
    {
        [OperationContract(Name = "PlaceOrder", Action = "PlaceOrder", ReplyAction = "PlaceOrderReply")]
        void PlaceOrder(string orderData);
    }
}
