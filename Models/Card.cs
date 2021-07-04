using System;
using System.Collections.Generic;

namespace AgileGame.Models{
    public class Card
{
    public int Id { get; set; }
    public string Titulo { get; set; }

    public string Descripcion {get;set;}

    // public DateTime FechaInicio{get;set;}

    // public DateTime FechaFin{get;set;}

    //public Column Columna {get;set;}

    public int TableroID {get;set;}

    public int ColumnaID {get;set;}
    
    public int Valor {get;set;}

    public int Horas {get;set;}

    }


}