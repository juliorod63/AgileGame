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

        public List<Column> Columnas  = new List<Column>();

        private List<AgileGame.Models.Card> Tarjetas = new List<AgileGame.Models.Card>();
        public BoardModel(ILogger<PrivacyModel> logger, AgileGameContext db) 
        {
            this.db = db;
            _logger = logger;
        }

        public async Task OnGetAsync(string nombre, int id)
        {
            Nombre = nombre;
            Id=id;

            CargarColumnas(id);

            //CrearColumnas();
            
            
            Tarjetas = await db.Tarjetas.ToListAsync();
            foreach(AgileGame.Models.Card c in Tarjetas){
                //Console.WriteLine(c.Titulo + "-" + c.ColumnaID);
                if(c.TableroID == Id){
                    Columnas[c.ColumnaID].Cards.Add(c);
                }
            }

            //Console.WriteLine("Nro Cards: " + Columnas[0].Cards.Count());
            
        }
    
        private void CargarColumnas(int tableroId){
            Columnas = db.Columnas.FromSqlRaw("select * from Columnas where Tableroid=" +  tableroId ).ToList();
            Console.WriteLine(Columnas.ToString());
        }
        public PartialViewResult OnGetCardDetail( int tableroId, int id){
            
            Tarjetas =  db.Tarjetas.ToList();
            //Console.WriteLine("pasamos por PartialViewResult. Card ID: " + id + " TableroId: " + tableroId);
            AgileGame.Models.Card miTarjeta = new AgileGame.Models.Card();
            miTarjeta = Tarjetas.First(s => s.Id == id);

            
            return Partial("_CardDetailPartial",miTarjeta);

        }

        public PartialViewResult OnGetBoardSettings(int tableroID, string nombre){

            CargarColumnas(tableroID);
            //Console.WriteLine("columnas: " + Columnas.Count());
            AgileGame.ViewModels.TableroColumnas tableroColumnas = new ViewModels.TableroColumnas();
            tableroColumnas.Columnas = Columnas;
            Tablero esteTablero = new Tablero();
            esteTablero.Id = tableroID;
            esteTablero.Title = nombre;

            tableroColumnas.MiTablero = esteTablero;


            Nombre = nombre;
            return Partial("_BoardSettingPartial", tableroColumnas );
        }
        private void CrearColumnas(){

            Column Backlog = new Column();
            Backlog.Title= "Backlog";
            Backlog.Id = 0;
            // CargarTarjetas(Backlog);
            Columnas.Add(Backlog);

            Column ToDo = new Column();
            ToDo.Title = "To Do";
            ToDo.Id = 1;
            ToDo.Limite =6;

            
            Columnas.Add(ToDo);

            Column InProgress = new Column();
            InProgress.Title = "En Progreso";
            InProgress.Id = 2;
            InProgress.Limite =3;

            
            Columnas.Add(InProgress);

            Column Blocked = new Column();
            Blocked.Title = "Bloqueada";
            Blocked.Id = 3;
            Blocked.Limite =3;

            Columnas.Add(Blocked);

            Column Done = new Column();
            Done.Title = "Finalizado";
            Done.Id=4;
            
            Columnas.Add(Done);
           
        }

        private void RecuperarTarjetas(){


        }
        private void CargarTarjetas(Column columna){
            Random rnd = new Random();
            int max= 1000;
            if(columna.Title == "Backlog"){
                
                for(int k=1; k<=7; k++){
                    
                    AgileGame.Models.Card c= new AgileGame.Models.Card();
                    c.Id = rnd.Next(1,max);
                    c.Titulo = "Tarea " + c.Id;
                    columna.Cards.Add(c);
                }
                 return;
            }



        }




    }




}