using System;
using ImpetusWebsite.Areas.Identity.Data;
using ImpetusWebsite.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ImpetusWebsite.Areas.Identity.IdentityHostingStartup))]
namespace ImpetusWebsite.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ImpetusContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ImpetusContextConnection")));

                services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<ImpetusContext>();
            });
        }
    }
}