using Microsoft.EntityFrameworkCore;
using AgileGame.Models;

namespace AgileGame.Data
{
    public class AgileGameContext: DbContext{
        public DbSet<Card> Tarjetas { get; set; }
        public DbSet<Column> Columnas {get; set;}
        
        public DbSet<Tablero> Tableros {get;set;}
        
        //public DbSet<BoardList> Tableros {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=AgileGame.db");
        }
    }

}