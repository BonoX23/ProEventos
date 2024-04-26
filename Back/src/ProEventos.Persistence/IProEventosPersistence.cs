using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public interface IProEventosPersistence
    {
         void Add<T>(T entity) where T: class;
         void Update<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         void DeleteRange<T>(T[] entity) where T: class;

         Task<bool> SaveChangesAsync();

         //Eventos

         Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool IncludePalestrantes);
         Task<Evento[]> GetAllEventosAsync(bool IncludePalestrantes);
         Task<Evento> GetEventoByIdAsync(int eventoId, bool IncludePalestrantes);

         //Palestrantes

         Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool IncludePalestrantes);
         Task<Palestrante[]> GetAllPalestrantesAsync(bool IncludePalestrantes);
         Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool IncludePalestrantes);
    }
}