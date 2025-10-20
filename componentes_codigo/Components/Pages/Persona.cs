using System.ComponentModel.DataAnnotations;
namespace componentes_codigo.Components.Pages
{
    public class Persona
    {
        public enum GeneroEnum
        {
            Mujer,
            Hombre
        }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "El correo no es válido")]
        [MaxLength(100, ErrorMessage = "El correo no puede exceder los 100 caracteres")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Phone(ErrorMessage = "El teléfono no es válido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Campo necesario")]
        public GeneroEnum? Genero { get; set; }
    }
}
