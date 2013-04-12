using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WebServiceContract;

namespace WebServiceImpl
{
    [ServiceBehavior(Name="ContactImpl")]
    public class Contact : IContact
    {
        public string Email(string LastName, string Firstname)
        {
            return "surana@develop.com";
        }

        public string Phone(string LastName, string Firstname)
        {
            return "555-1212";
        }
    }
}
