using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventosController : ControllerBase
{ 
    private readonly DataContext _context;
    public EventosController(DataContext context )
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
        evento => evento.EventoId == id
    );

    if (evento == null)
    {
        return NotFound();
    }

    return evento;
}

}
