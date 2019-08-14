using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_3.Entities
{
    public class Book
    {
        [Key]
        public Guid IdLibro { get; set; }
        [Required]
        [MaxLength(150)]
        public string Titulo { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }

        [ForeignKey("IdAutor")]
        public Author Autor { get; set; }

        public Guid IdAutor { get; set; }

    }
}
