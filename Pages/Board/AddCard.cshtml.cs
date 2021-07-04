using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using AgileGame.Models;
public class AddCardModel : PageModel{
    [BindProperty]
    public Card Tarjeta {get;set;}
    public AddCardModel(){

    }

    public void OnGet(){
        Console.WriteLine ("Aqui la pagina es llamada desde Tablero, el Objeto Tarjeta no esta creado aún!");

        


    }

    public void OnPost(){
        Tarjeta.ColumnaID = 1;
        Console.WriteLine("Llamada al Post");

        Console.WriteLine (Tarjeta.Titulo + Tarjeta.Descripcion + Tarjeta.Valor + Tarjeta.ColumnaID);

       

    }
}