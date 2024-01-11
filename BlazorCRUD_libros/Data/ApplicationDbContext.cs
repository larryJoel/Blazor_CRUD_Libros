using BlazorCRUD_libros.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD_libros.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //colocamos caada uno de los modelos
        public DbSet<Libro> Libro { get; set; }
    }
}
