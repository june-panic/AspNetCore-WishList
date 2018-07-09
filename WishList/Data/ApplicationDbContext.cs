using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

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
    }
}
