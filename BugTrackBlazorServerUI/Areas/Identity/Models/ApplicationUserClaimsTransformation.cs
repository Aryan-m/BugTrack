using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using BugTrackBlazorServerUI.Areas.Identity.Models;

// this class is used to add custom claims to User.identity
// source: https://stackoverflow.com/a/66936864
public class ApplicationUserClaimsTransformation : IClaimsTransformation
{
    private readonly UserManager<ApplicationUser> _userManager;
    public ApplicationUserClaimsTransformation(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
    {
        var identity = principal.Identities.FirstOrDefault(c => c.IsAuthenticated);
        if (identity == null) return principal;

        var user = await _userManager.GetUserAsync(principal);
        if (user == null) return principal;

        // Add or replace identity.Claims.


        if (!principal.HasClaim(c => c.Type == "DisplayName"))
        {
            identity.AddClaim(new Claim("DisplayName", (user.DisplayName ?? user.Email)));

        }

        return new ClaimsPrincipal(identity);
    }
}