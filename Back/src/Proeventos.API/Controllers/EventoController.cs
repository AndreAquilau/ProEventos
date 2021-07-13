using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos.API.Models;

namespace Proeventos.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class EventoController : ControllerBase
  {
    public EventoController()
    {

    }
    public IEnumerable<Evento> _event = new Evento[] {
          new Evento() {
          EventoId = 1,
          Tema = "Angular 11 e .NET 5",
          Local = "Belo Horizonte",
          Lote = "1° Lote",
          QtdPessoas = 250,
          DataEvento = DateTime.Now.AddDays(2).ToString()
        },
                  new Evento() {
          EventoId = 2,
          Tema = "Angular 11 e .NET 5",
          Local = "Belo Horizonte",
          Lote = "1° Lote",
          QtdPessoas = 250,
          DataEvento = DateTime.Now.AddDays(2).ToString()
        },
    };
    [HttpGet]
    public IEnumerable<Evento> Get() {
      return this._event;
    }

  [HttpGet]
  public IEnumerable<Evento> GetById(int id) {
    return _event.Where(evento => evento.EventoId == id);
  }

  }
}
