using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.Domain.Models;
using System;
using System.Threading.Tasks;
using static ProductCatalog.Constants.Constants;

namespace ProductCatalog.API
{
    public class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(Roles.Admin))
                {
                    await roleManager.CreateAsync(new IdentityRole { Name = Roles.Admin });
                }

                if (!await roleManager.RoleExistsAsync(Roles.User))
                {
                    await roleManager.CreateAsync(new IdentityRole { Name = Roles.User });
                }

                if (!await roleManager.RoleExistsAsync(Roles.SuperUser))
                {
                    await roleManager.CreateAsync(new IdentityRole { Name = Roles.SuperUser });
                }

                var admin = new User
                {
                    Email = "admin@admin.ru",
                    UserName = "admin",
                    IsBlocked = false,
                };
                var superUser = new User
                {
                    Email = "SuperUser@SuperUser.ru",
                    UserName = "SuperUser",
                    IsBlocked = false,
                };

                var user = new User
                {
                    Email = "user@user.ru",
                    UserName = "user",
                    IsBlocked = false,
                };

                await userManager.CreateAsync(admin, "12345678");
                await userManager.AddToRoleAsync(admin, Roles.Admin);

                await userManager.CreateAsync(superUser, "12345678");
                await userManager.AddToRoleAsync(superUser, Roles.SuperUser);

                await userManager.CreateAsync(user, "12345678");
                await userManager.AddToRoleAsync(user, Roles.User);
            }
        }
    }
}
