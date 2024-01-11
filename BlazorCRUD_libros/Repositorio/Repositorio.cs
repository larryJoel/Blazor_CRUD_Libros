using BlazorCRUD_libros.Data;
using BlazorCRUD_libros.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD_libros.Repositorio
{
    public class Repositorio : IRepositorio
    {
        private readonly ApplicationDbContext _context;
        //private object dateTime;

        public Repositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Libro> ActualizarLibro(int libroId, Libro actualizarLibro)
        {
            var libroDesdeBd = await _context.Libro.FindAsync(libroId);
            libroDesdeBd.Titulo = actualizarLibro.Titulo;
            libroDesdeBd.Descripcion = actualizarLibro.Descripcion;
            libroDesdeBd.Autor = actualizarLibro.Autor;
            libroDesdeBd.Paginas = actualizarLibro.Paginas;
            libroDesdeBd.Precio = actualizarLibro.Precio;
            await _context.SaveChangesAsync();
            return libroDesdeBd;

        }

        public async Task<Libro> CrearLibro(Libro crearLibro)
        {
            if(crearLibro != null)
            {
                crearLibro.FechaCreacion = DateTime.Now;
                await _context.Libro.AddAsync(crearLibro);
                await _context.SaveChangesAsync();
                return crearLibro;
            }
            return new Libro();
        }

        public async Task EliminarLibro(int libroId)
        {
            var libroDesdeDb = await _context.Libro.FindAsync(libroId);
            _context.Remove(libroDesdeDb);
            await _context.SaveChangesAsync();
        }

        public async Task<Libro> GetLibroId(int LibroId)
        {
           var libroDesdeBd = await _context.Libro.FindAsync(LibroId);
            if(libroDesdeBd == null)
            {
                return new Libro();
            }
            return libroDesdeBd;
        }

        public async Task<List<Libro>> getLibros()
        {
            return await _context.Libro.ToListAsync();
        }
    }
}
