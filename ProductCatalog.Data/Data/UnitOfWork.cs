using Microsoft.AspNetCore.Identity;
using ProductCatalog.Data.Interfaces;
using ProductCatalog.Domain.Models;
using System;
using System.Threading.Tasks;

namespace ProductCatalog.Data.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        ApplicationContext _context;

        IRepository<Product> _productRepository;
        IRepository<Category> _categoryRepository;

        UserManager<User> _users;
        RoleManager<IdentityRole> _roles;
        SignInManager<User> _signInManager;

        private bool disposed = false;

        public UnitOfWork(
            ApplicationContext context, 
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<User> signInManager)
        {
            _context = context;
            _users = userManager;
            _roles = roleManager;
            _signInManager = signInManager;
        }

        public IRepository<Product> Products => 
            _productRepository ?? (_productRepository = new Repository<Product>(_context));

        public IRepository<Category> Categories => 
            _categoryRepository ?? (_categoryRepository = new Repository<Category>(_context));

        public UserManager<User> UserManager => _users;
        public RoleManager<IdentityRole> RoleManager => _roles;
        public SignInManager<User> SignInManager => _signInManager;


        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            disposed = true;
        }
    }
}