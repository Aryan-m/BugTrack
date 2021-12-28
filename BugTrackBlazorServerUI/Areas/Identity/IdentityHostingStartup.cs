﻿using System;
using BugTrackBlazorServerUI.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BugTrackBlazorServerUI.Areas.Identity.IdentityHostingStartup))]
namespace BugTrackBlazorServerUI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<BugTrackBlazorServerUIContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("BugTrackBlazorServerUIContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<BugTrackBlazorServerUIContext>();
            });
        }
    }
}