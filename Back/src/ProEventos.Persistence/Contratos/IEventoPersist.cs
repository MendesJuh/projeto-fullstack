using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ProEventos.Domain;


namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist
    {
        Task<Evento[]> GetAllEventosAsync(bool includePalestrates = false);
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrates = false);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrates = false);

    }
}