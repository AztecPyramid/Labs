using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WebServiceContract
{
    [ServiceContract(Name="ContactContract")]
    public interface IContact
    {
        [OperationContract(Name="Email", Action="Email", ReplyAction="EmailReply")]
        [WebGet(UriTemplate="/{LastName}/{FirstName}/Email", ResponseFormat=WebMessageFormat.Xml)]
        string Email(string LastName, string Firstname);

        [OperationContract(Name = "Phone", Action = "Phone", ReplyAction = "PhoneReply")]
        [WebGet(UriTemplate = "/{LastName}/{FirstName}/Phone", ResponseFormat = WebMessageFormat.Xml)]
        string Phone(string LastName, string Firstname);
    }
}
