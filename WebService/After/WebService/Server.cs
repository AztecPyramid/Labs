using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WebService
{
    class Server
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new WebServiceHost(typeof(WebServiceImpl.Contact), new Uri("http://localhost:9000/Contact"))) {
                host.AddServiceEndpoint("WebServiceContract.IContact", new WebHttpBinding(), "Contact");
                host.Open();

                Console.Title = String.Format("{0} is running ...", host.Description.Endpoints[0].Address);
                Console.ReadLine();
            }
        }
    }
}
