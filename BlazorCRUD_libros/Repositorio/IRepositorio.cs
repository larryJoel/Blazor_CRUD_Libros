using BlazorCRUD_libros.Modelos;

namespace BlazorCRUD_libros.Repositorio
{
    public interface IRepositorio
    {
        public Task<List<Libro>> getLibros();
        public Task<Libro>GetLibroId(int LibroId);
        public Task<Libro> CrearLibro(Libro crearLibro);
        public Task<Libro> ActualizarLibro(int libroId, Libro actualizarLibro);
        public Task EliminarLibro(int libroId);


    }
}
