using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductCatalog.Data.Data
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } 

        public ApplicationContext() : base()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var products = GetProductsList();
            var categories = InitTestCategories().ToList();
            var words = GenerateWords();
            var rnd = new Random();
            var list = new List<Product>(1000);

            for(int i = 0; i < list.Capacity; i++)
            {
                list.Add(new Product()
                {
                    Name = products.ElementAt(rnd.Next(1, products.Count - 1)),
                    Description = words.ElementAt(rnd.Next(1, words.Count - 1)),
                    GeneralNote = words.ElementAt(rnd.Next(1, words.Count - 1)),
                    SpecialNote = words.ElementAt(rnd.Next(1, words.Count - 1)),
                    Cost = rnd.Next(1, 250),
                    CategoryId = rnd.Next(1, categories.Count - 1),
                    Id = i+1,
                });
            }

            builder.Entity<Category>().HasData(categories);
            builder.Entity<Product>().HasData(list);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "SuperUser", NormalizedName = "SUPERUSER" },
                new IdentityRole { Id = "3", Name = "User", NormalizedName = "USER" }
            );
        }

        private Category[] InitTestCategories()
        {
            Category[] categories = new Category[]
            {
                new Category { Name = "Еда", Id = 1 },
                new Category { Name = "Вкусности", Id = 2 },
                new Category { Name = "Вода", Id = 3 },
                new Category { Name = "Фрукты", Id = 4 },
                new Category { Name = "Овощи", Id = 5 },
                new Category { Name = "Мясо", Id = 6 },
                new Category { Name = "Рыба", Id = 7 },
                new Category { Name = "Молочные продукты", Id = 8 },
                new Category { Name = "Зерновые", Id = 9 },
                new Category { Name = "Сладости", Id = 10 },
                new Category { Name = "Гарниры", Id = 11 },
                new Category { Name = "Супы", Id = 12 },
                new Category { Name = "Напитки", Id = 13 },
                new Category { Name = "Закуски", Id = 14},
                new Category { Name = "Пицца", Id = 15 },
                new Category { Name = "Салаты", Id = 16 },
                new Category { Name = "Десерты", Id = 17 },
                new Category { Name = "Паста", Id = 18 },
                new Category { Name = "Рис", Id = 19 },
                new Category { Name = "Соусы", Id = 20 }
            };

            return categories;
        }

        public List<string> GetProductsList()
        {
            List<string> productList = new List<string>
            {
                "Селедка", "Тушенка", "Сгущенка", "Квас", "Кола",
                "Мороженное", "Курица", "Шоколад", "Чай", "Кофе",
                "Хлеб", "Молоко", "Вода", "Пельмени", "Пицца",
                "Сыр", "Мясо", "Яйца", "Орехи", "Сок",
                "Фрукты", "Овощи", "Рыба", "Морепродукты", "Красное вино",
                "Белое вино", "Паста", "Рис", "Макароны", "Морковь",
                "Огурцы", "Томаты", "Перец", "Салат", "Гречка",
                "Картофель", "Печенье", "Кекс", "Торт", "Пирог",
                "Каша", "Мед", "Сахар", "Соль", "Перец",
                "Соус", "Майонез", "Кетчуп", "Маргарин", "Сливочное масло"
            };

            return productList;
        }

        public List<string> GenerateWords()
        {
            List<string> words = new List<string>
        {
            "Качественное",
            "Свежее",
            "Натуральное",
            "Вкусное",
            "Ароматное",
            "Сочное",
            "Питательное",
            "Полезное",
            "Сладкое",
            "Соленое",
            "Острое",
            "Пикантное",
            "Красивое",
            "Нежное",
            "Постное",
            "Приправленное",
            "Пшеничное",
            "Ржаное",
            "Ванильное",
            "Шоколадное",
            "Медовое",
            "Молочное",
            "Фруктовое",
            "Овощное",
            "Мясное",
            "Рыбное",
            "Морское",
            "Жареное",
            "Вареное",
            "Тушеное",
            "Запеченное",
            "Сырое",
            "Жидкое",
            "Твердое",
            "Мягкое",
            "Сытное",
            "Пряное",
            "Сладкое",
            "Свежевыжатое",
            "Авторское"
        };

            return words;
        }
    }
}