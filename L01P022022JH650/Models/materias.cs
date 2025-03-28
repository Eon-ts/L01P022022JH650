using System.ComponentModel.DataAnnotations;
namespace L01P022022JH650.Models
{
    public class materias
    {
        [Key]
        public int id { get; set; }
        public string materia { get; set; }
        public int unidades_valorativas { get; set; }
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
