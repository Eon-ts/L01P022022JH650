using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace L01P022022JH650.Models
{
    public class materias
    {
        [Key]
        public int id { get; set; }

        [DisplayName("Materia")]
        [Required(ErrorMessage = "La materia NO es opcional")]
        [StringLength(100, ErrorMessage = "La cantidad máxima de carácteres válida es {1}")]
        public string materia { get; set; }

        [DisplayName("Unidades valorativas")]
        [Range(0, 10, ErrorMessage = "La unidad valorativa debe ser de 0 a 10")]
        //[StringLength(2, ErrorMessage = "La cantidad máxima de carácteres válida es {1}")]
        public int unidades_valorativas { get; set; }

        [DisplayName("Estado")]
        [RegularExpression("^[01]$", ErrorMessage = "El estado de la materia debe ser 0 o 1")]
        //[StringLength(1, ErrorMessage = "La cantidad máxima de carácteres válida es {1}")]
        [Required(ErrorMessage = "El estado de la materia NO es opcional")]
        public char estado { get; set; }


        /*
        
        (id                   INT IDENTITY(1, 1) PRIMARY KEY,
 materia              VARCHAR(100),
 unidades_valorativas INT,
 estado               CHAR(1)
);
        */
    }
}
