using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365RESTAPI.Helpers
{
    class AuthenticationHelper
    {
        static string tenant = "msd365demo1.onmicrosoft.com";
        static string authority = "https://login.microsoftonline.com/" + tenant;
        static string clientId = "1ba98e83-b57e-4b70-9306-9deabb9bc0e3";
        static string clientSecret = "60?m0/9d@xS[8S?UDYJcR9-/fg3jNkU2";

        public Task<AuthenticationResult> GetBearerToken(string environmentId)
        {
            string resource = "https://" + environmentId + ".cloudax.dynamics.com";

            var clientCredential = new ClientCredential(clientId, clientSecret);
            string authorityURL = "https://login.microsoftonline.com/" + tenant;

            AuthenticationContext context = new AuthenticationContext(authority, false);
            Task<AuthenticationResult> authenticationResult = context.AcquireTokenAsync(resource, clientCredential);

            return authenticationResult;
        }
    }
}
