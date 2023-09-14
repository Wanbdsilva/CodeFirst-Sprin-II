using Microsoft.EntityFrameworkCore;
using WebApi.Inlock.Codefirst_Manha.Domains;

namespace WebApi.Inlock.Codefirst_Manha.Context
{
    public class InlockContext : DbContext
    {
        //Define as entidades do banco de dados

        public DbSet<Estudio> Estudios { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        //Define as opcoes de construcao do banco(String Conexao)

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE18-S15; Database=inlock_games_codeFirst_Manha; User id = sa; pwd = Senai@134;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
