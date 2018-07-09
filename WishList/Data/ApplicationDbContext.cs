using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ApplicationDbContext : DbContext
    {
        private readonly RequestDelegate _next;

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}
