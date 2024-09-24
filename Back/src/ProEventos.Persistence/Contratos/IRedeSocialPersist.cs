using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IRedeSocialPersist : IGeralPersist
    {
        //Retornando uma rede social de um evento
        Task<RedeSocial> GetRedeSocialEventoByIdsAsync(int eventoId, int id);
        //Retornando uma rede social de um palestrante
        Task<RedeSocial> GetRedeSocialPalestranteByIdsAsync(int palestranteId, int id);
        Task<RedeSocial[]> GetAllByEventoIdAsync(int eventoId);
        Task<RedeSocial[]> GetAllByPalestranteIdAsync(int palestranteId);
    }
}