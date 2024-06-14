using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace BlazorEngenharia
{
    public class ServerAuthenticationStateProvider : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
          
            var identity = new ClaimsIdentity(); 

            var user = new ClaimsPrincipal(identity);

            return Task.FromResult(new AuthenticationState(user));
        }
    }
}
