using System;
using System.Collections.Generic;
using System.Linq;
using System.DirectoryServices.AccountManagement;

namespace PrintumProjektverwaltung.Helper
{
    class ADHelper
    {
        public static bool CheckUserinAD(string domain, string username)
        {

          var  ADUser_Id = "PRINT\\erp"; //make sure user name has domain name.
           var Password = "Bernd$Finest";
            var context = new PrincipalContext(ContextType.Domain, "192.168.26.250", ADUser_Id, Password);
            /* server_address = "192.168.15.36"; //don't include ldap in url */


            using (var domainContext = new PrincipalContext(ContextType.Domain, "192.168.26.250", ADUser_Id, Password))
            {
                using (var user = new UserPrincipal(domainContext))
                {
                    user.SamAccountName = username;

                    using (var pS = new PrincipalSearcher())
                    {
                        pS.QueryFilter = user;

                        using (PrincipalSearchResult<Principal> results = pS.FindAll())
                        {
                            if (results != null && results.Count() > 0)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

    }
}
