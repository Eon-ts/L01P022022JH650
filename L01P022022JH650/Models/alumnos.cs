using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace L01P022022JH650.Models
{
    public class alumnos
    {
        [Key]
        public int id { get; set; }

        [DisplayName("Codigo de alumno")]
        [Required(ErrorMessage = "El codigo del alumno NO es opcional")]
        [StringLength(10, ErrorMessage = "La cantidad máxima de carácteres válida es {1}")]
        public string codigo { get; set; }

        [DisplayName("Nombre de alumno")]
        [Required(ErrorMessage = "El nombre del alumno NO es opcional")]
        [StringLength(50, ErrorMessage = "La cantidad máxima de carácteres válida es {1}")]
        public string nombre { get; set; }


        [DisplayName("Apellidos de alumno")]
        [Required(ErrorMessage = "Los apellidos del alumno NO son opcionales")]
        [StringLength(50, ErrorMessage = "La cantidad máxima de carácteres válida es {1}")]
        public string apellidos { get; set; }


        [DisplayName("DUI de alumno")]
        [Required(ErrorMessage = "El DUI del alumno NO es opcional")]
        [RegularExpression("^[0-9]{9}$", ErrorMessage = "El DUI debe tener 9 dígitos")]
        //[StringLength(9, ErrorMessage = "La cantidad máxima de carácteres válida es {1}")]
        public int dui { get; set; }

        [DisplayName("Estado de alumno")]

        [Range(0, 1, ErrorMessage = "El estado del alumno debe ser 0 o 1")]
        //[StringLength(1, ErrorMessage = "La cantidad máxima de carácteres válida es {1}")]
        [Required(ErrorMessage = "El estado del alumno NO es opcional")]
        public int estado { get; set; }
        

    }
}
