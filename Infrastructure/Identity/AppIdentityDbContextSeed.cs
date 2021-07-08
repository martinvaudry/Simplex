using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;


namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user =new AppUser
                {
                    DisplayName = "Jean",
                    Email = "Jean@test.com",
                    UserName = "Jean@test.com",
                    Address = new Address
                    {
                        FirstName = "Jean",
                        LastName = "Tremblay",
                        Street = "123 rue Saint-Joseph",
                        City = "Drummondville",
                        Province = "Quebec",
                        PostalCode = "J2C1B2"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd"); // mot de passe avec majuscule, minuscule, chiffre et caractère spécial
            }
        }
    }
}