using Microsoft.EntityFrameworkCore;
using CursoNetCoreMVC.Models;
using System;

namespace CursoNetCoreMVC.Models
{
    public class Context : DbContext
    {
        public virtual DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = ASUS-PC; Database = Cursomvc; Integrated Security = True");
            
        }

        //public DbSet<CursoNetCoreMVC.Models.Produto> Produto { get; set; }
        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

        
    }
}
