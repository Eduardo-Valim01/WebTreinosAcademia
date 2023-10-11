using Microsoft.EntityFrameworkCore;
using WebTreinosAcademia.Models;

namespace WebTreinosAcademia.Models
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Aluno> Alunos{ get; set; }
        public DbSet<Professor> Professores{ get; set; }
        public DbSet<Treino> Treinos { get; set; }

    }
}
