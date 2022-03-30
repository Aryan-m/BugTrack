using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BugTrackBlazorServerUI.Classes
{
    /// <summary>
    /// Allows signed in user data to be accessible from one place
    /// </summary>
    public class IdentityUserData : IIdentityUserData
    {
        private AuthenticationStateProvider _authState;
        public IdentityUserData(AuthenticationStateProvider authState)
        {
            _authState = authState;

        }

        /// <summary>
        ///     return current signed in user
        /// </summary>
        /// <returns>
        /// ClaimsPrincipal holding user data
        /// </returns>
        // source: https://docs.microsoft.com/en-us/aspnet/core/blazor/security/?view=aspnetcore-6.0
        // code snippet is under "Security and Identity" -> "Overview" 
        public async Task<ClaimsPrincipal> currentUser()
        {
            var authState = await _authState.GetAuthenticationStateAsync();
            var user = authState.User;
            return user;
        }

    }
}
