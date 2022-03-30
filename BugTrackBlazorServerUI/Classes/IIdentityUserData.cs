using System.Security.Claims;
using System.Threading.Tasks;


namespace BugTrackBlazorServerUI.Classes
{
    /// <summary>
    /// Allows signed in user data to be accessible from one place
    /// </summary>
    public interface IIdentityUserData
    {
        Task<ClaimsPrincipal> currentUser();
    }
}