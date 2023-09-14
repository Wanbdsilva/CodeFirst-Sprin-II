using WebApi.Inlock_games_dbFirst_manha.Domains;

namespace WebApi.Inlock_games_dbFirst_manha.Interfaces
{
    public interface IEstudioRepository
    {
            List<Estudio> listar();

            Estudio BuscarPorId(Guid id);

            void Cadastrar(Estudio estudio);

            void Atualizar(Guid id, Estudio estudio);

            void Deletar(Guid Id);

            List<Estudio> ListarComJogos(Guid id);
      
    }
}
