using System.ComponentModel.DataAnnotations;
namespace L01P022022JH650.Models
{
    public class facultades
    {
        [Key]
        public int id { get; set; }
        public string facultad { get; set; }

        //(id       INT IDENTITY(1, 1) PRIMARY KEY, facultad VARCHAR(100)
    }
}
