using Microsoft.AspNetCore.Mvc;
using ProEventos.Domain;
using ProEventos.Persistence;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventosController : ControllerBase
{ 
    private readonly ProEventosContext  _context;
    public EventosController(ProEventosContext context )
    {
        _context = context;
    }
    
    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;
    }

[HttpGet("{id}")]
public ActionResult<Evento> GetById(int id)
{
    var evento = _context.Eventos.FirstOrDefault(
        evento => evento.Id == id
    );

    if (evento == null)
    {
        return NotFound();
    }

    return evento;
}

}
