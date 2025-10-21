using System.ComponentModel.DataAnnotations;
namespace componentes_codigo.Components.Pages
{

    public class Producto
    {
        [Required(ErrorMessage = "El número de inventario es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe ser un número entero positivo")]
        public int Inventario { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un departamento")]
        public DepartamentoEnum Departamento { get; set; }
    }

    public enum DepartamentoEnum
    {
        Frutas,
        Verduras,
        Lacteos
    }
}