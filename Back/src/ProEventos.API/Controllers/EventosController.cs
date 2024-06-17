using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {

     /*public EventoController(ILogger<EventoController> logger)
     {          
     }*/
        private readonly DataContext context;
     
     public EventosController(DataContext context)
     {
            this.context = context;
     }


     [HttpGet]
     public IEnumerable<Evento> Get()
     {
          return context.Eventos;
     }

     [HttpGet("{id}")]
     public Evento GetbyId(int id)
     {
          return context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
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
          return "coonstruindoooo";
     } 


    }
}
