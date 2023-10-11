
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTreinosAcademia.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [StringLength(14)]
        [Required(ErrorMessage = "Campo CPF é obrigatório...")]
        [Display(Name = "CPF")]
        public int cpf { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório...")]
        [StringLength(50)]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Idade")]
        public int idade { get; set; }

        [StringLength(25)]
        [Display(Name = "Endereço")]
        public string endereco { get; set; }

        [Required(ErrorMessage = "Campo Cidade é obrigatório...")]
        [StringLength(25)]
        [Display(Name = "Cidade")]
        public int cidade { get; set; }

        [Required(ErrorMessage = "Campo Dada Nascimento é obrigatório...")]
        [Display(Name = "Data Nascimento")]
        public DateTime datanasc { get; set; }

        [Display(Name = "Objetivo do Treino")]
        [StringLength(25)]
        public string ojetivo { get; set; }

        [Required(ErrorMessage = "Campo Peso é obrigatório...")]
        [Display(Name = "Peso")]
        public float peso { get; set; }
    }
}
