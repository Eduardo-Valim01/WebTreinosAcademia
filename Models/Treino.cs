using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTreinosAcademia.Models
{
    [Table("Treinos")]
    public class Treino
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string nometreino  { get; set; }
        public string descricaotreino { get; set; }
        public string duracao { get; set; }
        public string dificuldade { get; set; }
        public int professorResp { get; set; }

    }
}
