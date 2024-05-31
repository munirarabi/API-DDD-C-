using Domain.Interfaces;
using Entityes.Entityes;
using Infra.Configurations;
using Infra.Repository.Generics;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
    public class RepositoryUser : RepositoryGenerics<ApplicationUser>, IUser
    {
        private readonly DbContextOptions<Context> _optionsBuilder;

        public RepositoryUser()
        {
            _optionsBuilder = new DbContextOptions<Context>();
        }

        public async Task<bool> InsertUser(string email, string password, int age, string phone)
        {
            try
            {
                using (var data = new Context(_optionsBuilder))
                {
                    await data.ApplicationUser.AddAsync(
                        new ApplicationUser
                        {
                            Email = email,
                            PasswordHash = password,
                            Age = age,
                            Phone = phone
                        });  
                    
                    await data.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
