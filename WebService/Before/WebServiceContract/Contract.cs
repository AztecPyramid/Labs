using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WebServiceContract
{
    public interface IContact
    {
        string Email(string LastName, string Firstname);
        string Phone(string LastName, string Firstname);
    }
}
