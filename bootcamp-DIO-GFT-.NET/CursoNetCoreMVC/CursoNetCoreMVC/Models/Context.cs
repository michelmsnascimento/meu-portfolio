using Microsoft.EntityFrameworkCore;

namespace CursoNetCoreMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost\\mssqllocaldb; Database = CursoMVC; Integrated Security = True");
            //optionsBuilder.UseSqlServer("Data Sourse=;Initial Catalog=CursoMVC;Integrated Security=True");
        }
        
    }
}
