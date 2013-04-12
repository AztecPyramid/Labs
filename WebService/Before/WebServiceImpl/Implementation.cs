using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WebServiceContract;

namespace WebServiceImpl
{
    public class Contact : IContact
    {
        public string Email(string LastName, string Firstname)
        {
            // Should do something smart, like lookup value in DB.
            // For now just return your email address.

            return "george@highlevelcode.com";
        }

        public string Phone(string LastName, string Firstname)
        {
            // Return your phone number
            return "7143946290";
        }
    }
}
