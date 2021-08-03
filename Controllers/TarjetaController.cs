using Microsoft.AspNetCore.Mvc;
using AgileGame.Data;
using System.Collections.Generic;
using System;
using AgileGame.ViewModels;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AgileGame.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {

        private readonly AgileGameContext _db;
        public TarjetaController(AgileGameContext agileGameContext){
            
            _db = agileGameContext;
            //Console.WriteLine ("paso por x el ctor TarjetaController");
        }

        [HttpPost("movertarjeta")]
        public IActionResult Index([FromBody] MoverTarjeta contenido)
        {

            //MoverTarjeta card = JsonSerializer.Deserialize<MoverTarjeta>(contenido.ToString());
            mueveTarjeta(contenido);
            return Content("Tarjeta " + contenido.cardId + " ha sido movida de columna " + contenido.columnaId);


            
        }

        private void mueveTarjeta(MoverTarjeta tarjeta){

            var card = _db.Tarjetas.SingleOrDefault(x => x.Id == tarjeta.cardId);
            //Console.WriteLine ("tarjeta recibida");
            card.ColumnaID = tarjeta.columnaId;
            _db.SaveChanges();
            //Console.WriteLine ("tarjeta actualizada" + tarjeta.columnaId);
        }

        private bool wipExcedido(MoverTarjeta tar){
            //finalmente esta funcion no se utiliza, pues lo he resuelto por jQuery.
            
            bool excedido =false;
            if(tar.columnaId == 0)
                excedido=false;
            else{
                _db.Tarjetas.All<AgileGame.Models.Card>(c => c.ColumnaID == tar.columnaId);
                Console.WriteLine("WipExcedido: Cantidad de Tarjetas: " + _db.Tarjetas.Count());
                if(_db.Tarjetas.Count()>= 3){
                    excedido=true;
                }
                else{
                    excedido= false;
                }
            }

            return excedido;
        }

    }
}
