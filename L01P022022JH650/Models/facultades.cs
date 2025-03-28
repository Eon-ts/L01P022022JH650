using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace L01P022022JH650.Models
{
    public class facultades
    {
        [Key]
        public int id { get; set; }

        [DisplayName("Facultad")]
        [StringLength(100, ErrorMessage = "La cantidad máxima de carácteres válida es {1}")]
        [Required(ErrorMessage = "La facultad NO es opcional")]
        public string facultad { get; set; }

        //(id       INT IDENTITY(1, 1) PRIMARY KEY, facultad VARCHAR(100)
    }
}
