
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTreinosAcademia.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(14)]
        public int cpf { get; set; }
        [Required]
        [StringLength(50)]
        public string nome { get; set; }
        public int idade { get; set; }
        [Required]
        public string endereco { get; set; }
        public int cidade { get; set; }
        [Required]
        public DateTime datanasc { get; set; }
        public int ojetivo { get; set; }
        [Required]
        public float peso { get; set; }
    }
}
