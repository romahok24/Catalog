using Microsoft.AspNetCore.Identity;
using ProductCatalog.Domain.Models;
using System;
using System.Threading.Tasks;

namespace ProductCatalog.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Product> Products { get; }
        IRepository<Category> Categories { get; }

        UserManager<User> UserManager { get; }
        RoleManager<IdentityRole> RoleManager { get; }
        SignInManager<User> SignInManager { get; }

        void Save();
        Task<int> SaveAsync();
    }
}