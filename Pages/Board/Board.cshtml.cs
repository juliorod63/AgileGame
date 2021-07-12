using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using AgileGame.Models;
using AgileGame.Data;
namespace AgileGame.Pages.Board
{

    public class BoardModel : PageModel
    {

        private readonly ILogger<PrivacyModel> _logger;
        private readonly AgileGameContext db;

        public string Nombre;
        public int Id;

        public List<Column> Columnas { get; set; } = new List<Column>();

        private List<Card> Tarjetas = new List<Card>();
        public BoardModel(ILogger<PrivacyModel> logger, AgileGameContext db) 
        {
            this.db = db;
            _logger = logger;
        }

        public async Task OnGetAsync(string nombre, int id)
        {
            Nombre = nombre;
            Id=id;

            CrearColumnas();

            
            Tarjetas = await db.Tarjetas.ToListAsync();
            foreach(Card c in Tarjetas){
                Console.WriteLine(c.Titulo + "-" + c.ColumnaID);
                if(c.TableroID == Id){
                    Columnas[c.ColumnaID].Cards.Add(c);
                }
            }
            
        }
        private void CrearColumnas(){

            Column Backlog = new Column();
            Backlog.Title= "Backlog";
            Backlog.Id = 1;
            // CargarTarjetas(Backlog);
            Columnas.Add(Backlog);

            Column ToDo = new Column();
            ToDo.Title = "To Do";
            ToDo.Id = 2;
            ToDo.Limite =6;

            
            Columnas.Add(ToDo);

            Column InProgress = new Column();
            InProgress.Title = "En Progreso";
            InProgress.Id = 3;
            InProgress.Limite =3;

            
            Columnas.Add(InProgress);

            Column Blocked = new Column();
            Blocked.Title = "Bloqueada";
            Blocked.Id = 4;
            Blocked.Limite =3;

            Columnas.Add(Blocked);

            Column Done = new Column();
            Done.Title = "Finalizado";
            Done.Id=5;
            
            Columnas.Add(Done);
        }

        private void RecuperarTarjetas(){


        }
        private void CargarTarjetas(Column columna){
            Random rnd = new Random();
            int max= 1000;
            if(columna.Title == "Backlog"){
                
                for(int k=1; k<=7; k++){
                    
                    Card c= new Card();
                    c.Id = rnd.Next(1,max);
                    c.Titulo = "Tarea " + c.Id;
                    columna.Cards.Add(c);
                }
                 return;
            }

            Card c1= new Card();
            c1.Id = rnd.Next(1,max);
            c1.Titulo = "Tarea " + c1.Id;
            columna.Cards.Add(c1);
            
            Card c2= new Card();
            c2.Id = rnd.Next(1,max);
            c2.Titulo = "Tarea " + c2.Id;
            columna.Cards.Add(c2);

        }




    }




}