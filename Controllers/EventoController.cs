using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;


namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
                 new Evento()
                 {
                    EventoId = 1,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Belo Horizonte",
                    Lote = "Primeiro Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyy"),
                    ImagemUrl = "foto.png"
                 },
                 new Evento()
                 {
                    EventoId = 2,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Belory Hills",
                    Lote = "segundo Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(7).ToString("dd/MM/yyy"),
                    ImagemUrl = "foto.png"
                 },
                 new Evento()
                 {
                    EventoId = 3,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Neves",
                    Lote = "terceito Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(9).ToString("dd/MM/yyy"),
                    ImagemUrl = "foto.png"
                 }
        };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {       
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {       
            return _evento.Where(evento => evento.EventoId == id);
        }
    }
}
