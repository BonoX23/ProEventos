using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
         Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool IncludePalestrantes);
         Task<Palestrante[]> GetAllPalestrantesAsync(bool IncludePalestrantes);
         Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool IncludePalestrantes);
    }
}