using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTreinosAcademia.Models
{
    [Table("Professores")]
    public class Professor
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string nome { get; set; }
        [Required]
        public string especializacao { get; set; }
        public int idade { get; set; }
        public string sexo { get; set; }
        [Required]
        public string endereco { get; set; }
        public string telefone { get; set; }

    }
}
