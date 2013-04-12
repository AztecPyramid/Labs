using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace DM
{
    class ChannelWrapper<T> : IDisposable
    {
        T _channel;

        public T Channel
        {
            get { return _channel; }
        }

        public ChannelWrapper(string configname)
        {
            ChannelFactory<T> cf = new ChannelFactory<T>(configname);
            _channel = cf.CreateChannel();
        }

        public void Dispose()
        {
            IClientChannel channel = (IClientChannel)_channel;
            try
            {
                if (channel.State != CommunicationState.Closed)
                {
                    channel.Close();
                }
            }
            catch
            {
                channel.Abort();
            }
        }
    }
}
