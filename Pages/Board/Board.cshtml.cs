using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;



namespace AgileGame.Pages.Board
{

    public class BoardModel : PageModel
    {

        private readonly ILogger<PrivacyModel> _logger;

        public string Nombre;
        public int Id;

        public List<Column> Columns { get; set; } = new List<Column>();

        public BoardModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }
        public void OnGet(string nombre, int id){

            Nombre = nombre;
            Id=id;

            CrearColumnas();

        }

        private void CrearColumnas(){

            Column Backlog = new Column();
            Backlog.Title= "Backlog";
            Backlog.Id = 1;
            CargarTarjetas(Backlog);
            Columns.Add(Backlog);

            Column ToDo = new Column();
            ToDo.Title = "To Do";
            ToDo.Id = 2;
            CargarTarjetas(ToDo);
            Columns.Add(ToDo);

            Column InProgress = new Column();
            InProgress.Title = "En Progreso";
            InProgress.Id = 3;
            CargarTarjetas(InProgress);
            Columns.Add(InProgress);

            Column Blocked = new Column();
            Blocked.Title = "Bloqueada";
            Blocked.Id = 4;
            Columns.Add(Blocked);

            Column Done = new Column();
            Done.Title = "Finalizado";
            Done.Id=5;
            CargarTarjetas(Done);
            Columns.Add(Done);
        }

        private void CargarTarjetas(Column columna){
            Random rnd = new Random();
            int max= 1000;
            if(columna.Title == "Backlog"){
                
                for(int k=1; k<=7; k++){
                    
                    Card c= new Card();
                    c.Id = rnd.Next(1,max);
                    c.Content = "Tarea " + c.Id;
                    columna.Cards.Add(c);
                }
                 return;
            }

            Card c1= new Card();
            c1.Id = rnd.Next(1,max);
            c1.Content = "Tarea " + c1.Id;
            columna.Cards.Add(c1);
            
            Card c2= new Card();
            c2.Id = rnd.Next(1,max);
            c2.Content = "Tarea " + c2.Id;
            columna.Cards.Add(c2);

        }

    }


}