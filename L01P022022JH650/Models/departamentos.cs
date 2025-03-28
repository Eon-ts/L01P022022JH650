using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace L01P022022JH650.Models
{
    public class departamentos
    {
        [Key]
        public int id { get; set; }

        [DisplayName("Departamento")]
        [Required(ErrorMessage = "El departamento NO es opcional")]
        [StringLength(50, ErrorMessage = "La cantidad máxima de carácteres válida es {1}")]
        public string departamento { get; set; }
        

        /*
        (id           INT IDENTITY(1, 1) PRIMARY KEY,
 departamento VARCHAR(50)
);

        */
    }
}
