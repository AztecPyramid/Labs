using System;
using System.Collections.Generic;
using System.Text;

using System.ServiceModel;
using System.ServiceModel.Channels;

using IOrderContractChannelFactory =
        System.ServiceModel.ChannelFactory<DM.PetShop.IOrderContract>;
using DM.PetShop;

namespace Client1
{
    class Client1App
    {
        static void Main(string[] args)
        {
            IOrderContractChannelFactory factory = new IOrderContractChannelFactory(new BasicHttpBinding());
            IOrderContract channel = factory.CreateChannel(new EndpointAddress("http://localhost:9000/PetShop/OrderService"));
            channel.PlaceOrder("1 parrot");

            IClientChannel clientChannel = (IClientChannel)channel;
            try
            {
                if (clientChannel.State != CommunicationState.Closed)
                    clientChannel.Close();
            }
            catch
            {
                clientChannel.Abort();
            }
        }
    }
}
