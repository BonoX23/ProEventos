using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence.Contextos;
using ProEventos.Persistence.Contratos;

namespace ProEventos.Persistence
{
    public class PalestrantePersist : IPalestrantePersist
    {
        private readonly ProEventosContext _context;
        
        public async Task<Palestrante[]> GetAllPalestrantesAsync(bool IncludeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                .Include(pe => pe.RedesSociais);

            if(IncludeEventos)
            {
                query = query
                    .Include(p => p.PalestrantesEventos)
                    .ThenInclude(pe => pe.Evento);
            }

            query = query.AsNoTracking().OrderBy(p => p.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool IncludeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                .Include(pe => pe.RedesSociais);

            if(IncludeEventos)
            {
                query = query
                    .Include(p => p.PalestrantesEventos)
                    .ThenInclude(pe => pe.Evento);
            }

            query = query.AsNoTracking().OrderBy(e => e.Id)
                    .Where(e => e.Nome.ToLower().Contains(nome.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool IncludeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                .Include(pe => pe.RedesSociais);

            if(IncludeEventos)
            {
                query = query
                    .Include(p => p.PalestrantesEventos)
                    .ThenInclude(pe => pe.Evento);
            }

            query = query.AsNoTracking().OrderBy(p => p.Id)
                    .Where(p => p.Id == palestranteId);

            return await query.FirstOrDefaultAsync();
        }
    }
}