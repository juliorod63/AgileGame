using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using AgileGame.Models;
using AgileGame.Data;
public class AddCardModel : PageModel{
    [BindProperty]
    public Card Tarjeta {get;set;}
    [BindProperty]
    public Tablero MiTablero {get;set;}

    private readonly AgileGameContext _db;
    public AddCardModel(AgileGameContext db){
        _db=db;
    }
    private void GuardarTarjeta(){
        _db.Tarjetas.Add(Tarjeta);
        _db.SaveChanges();
        //Console.WriteLine (Tarjeta.Titulo + Tarjeta.Descripcion + Tarjeta.Valor + " - " + Tarjeta.TableroID + " - " + Tarjeta.ColumnaID);

    }
    public void OnGet(int Id, string name){
        
        MiTablero = new Tablero();
        MiTablero.Title = name;
        MiTablero.Id = Id;
        //Console.WriteLine ("GET parametros: " + MiTablero.Title + "-" + MiTablero.Id);

    }

    public IActionResult OnPost(){

        //Console.WriteLine("Nombre Tablero: " + MiTablero.Title);
        Tarjeta.ColumnaID = 0;
        GuardarTarjeta();
        return  Redirect("/Board/Board?nombre=" + MiTablero.Title + "&Id=" + MiTablero.Id );

    }

    
}