using Microsoft.EntityFrameworkCore;

namespace Market.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions op): base(op){  

        }
        public DbSet<Category> Categories{get;set;}
        public DbSet<Product> Products{get;set;}
        public DbSet<Trash> Trashs{get;set;}
        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Category>().HasData(
                new Category{ Id = 1, Name = "Todos los Productos"},
                new Category{ Id = 2, Name = "Productos de Panaderia"},
                new Category{ Id = 3, Name = "Confiteria"},
                new Category{ Id = 4, Name = "Productos de Carne"},
                new Category{ Id = 5, Name = "Productos Marinos"},
                new Category{ Id = 6, Name = "Frutas y vegetales"},
                new Category{ Id = 7, Name = "Productos lacteos"}              
            );
        }
    }
}