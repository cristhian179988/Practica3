using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_3.Entities
{
    [Table("Author", Schema = "dbo")]
    public class Author
    {
        [Key]
        public Guid IdAutor { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(50)]
        public string Genero { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
