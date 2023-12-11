using System.ComponentModel.DataAnnotations;

namespace cruddepruebanet7mvc.Models
{
    public class Contacto
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El teléfono es obligatorio")]
        public string telefono { get; set;}
        [Required(ErrorMessage = "El celular es obligatorio")]
        public string Celular { get;set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        public string Email { get; set;}

        public DateTime fechaCreacion { get; set; }
    }
}
