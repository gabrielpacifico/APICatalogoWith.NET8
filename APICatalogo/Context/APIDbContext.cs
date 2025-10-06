using APICatalogo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context
{
    public class APIDbContext : IdentityDbContext<ApplicationUser>
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { }

        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
