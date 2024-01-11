﻿using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD_libros.Modelos
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El titulo es obligatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        public string Autor {  get; set; }

        [Required(ErrorMessage = "La cantidade páginas es obligatoria")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public int Precio { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
