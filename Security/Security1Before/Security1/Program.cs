using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Security.Principal;
using System.Security.Permissions;

namespace Security1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericIdentity identity = new GenericIdentity("Jorge");
            GenericPrincipal principal = new GenericPrincipal(identity, new string[] { "Guest", "Admin" });
            Thread.CurrentPrincipal = principal;
            RestricedLayer rl = new RestricedLayer();
            rl.GuestAccess();
            rl.AdminAccess();
            Console.ReadLine();
        }
    }

    public class RestricedLayer
    {
        [PrincipalPermission(SecurityAction.Demand, Role = "Guest")]
        public void GuestAccess()
        {
            Console.WriteLine("Successfully called GuestAccess");
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "Admin")]
        public void AdminAccess()
        {
            Console.WriteLine("Successfully called AdminAccess");
        }
    }
}
