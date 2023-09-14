using Microsoft.EntityFrameworkCore;
using WebApi.Inlock_games_dbFirst_manha.Contexts;
using WebApi.Inlock_games_dbFirst_manha.Domains;
using WebApi.Inlock_games_dbFirst_manha.Interfaces;

namespace WebApi.Inlock_games_dbFirst_manha.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        InLockContext ctx = new InLockContext();
        public void Atualizar(Guid id, Estudio estudio)
        {
            Estudio estudioBuscado = ctx.Estudios.Find(id);

            if (estudioBuscado != null )
            {
                estudioBuscado.Nome = estudio.Nome;
            }

            ctx.Estudios.Update(estudioBuscado);

            ctx.SaveChanges();
        }

        public Estudio BuscarPorId(Guid id)
        {
            return ctx.Estudios.FirstOrDefault(e => e.IdEstudio == id);
        }

        public void Cadastrar(Estudio estudio)
        {
            

            ctx.Estudios.Add(estudio);

            ctx.SaveChanges();
        }

        public void Deletar(Guid Id)
        {
            Estudio estudioBuscado = ctx.Estudios.Find(Id);

            ctx.Estudios.Remove(estudioBuscado);

            ctx.SaveChanges();
        }

        public List<Estudio> listar()
        {
            return ctx.Estudios.ToList();
        }

        public List<Estudio> ListarComJogos(Guid id)
        {
            return ctx.Estudios.Include(e => e.Jogos).ToList();
        }
    }
}
