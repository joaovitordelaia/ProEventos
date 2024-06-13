using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

     /*public EventoController(ILogger<EventoController> logger)
     {          
     }*/

     public IEnumerable<Evento> _events = new Evento[]{ 
                    new Evento(){
                         EventoId = 1,
                         Local = "Linhares",
                         DataEvento = DateTime.Now.AddDays(2).ToString(),
                         Tema = "video aula",
                         qntPessoas = 2,
                         Lote = "1º lote"
                         },
                    new Evento(){
                         EventoId = 2,
                         Local = "LinsCity",
                         DataEvento = DateTime.Now.AddDays(3).ToString(),
                         Tema = "video aula parte 2",
                         qntPessoas = 3,
                         Lote = "3º lote"
                         }
             };
     

     [HttpGet]
     public IEnumerable<Evento> Get()
     {
          return _events;
     }

     [HttpGet("{id}")]
     public IEnumerable<Evento> GetbyId(int id)
     {
          return _events.Where(evento => evento.EventoId == id);
     }

     [HttpPost]
     public string Post()
     {
          return "Valor de Post";
     }   
     [HttpPut("{id}")]
     public string Put(int id)
     {
          return $"Valor de Put em id = {id}";
     }      
     [HttpDelete("{id}")]
     public string Delete(int id)
     {
          return $"Valor de Delete em id = {id}";
     } 


    }
}
