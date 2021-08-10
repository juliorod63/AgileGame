using System.Collections.Generic;

namespace AgileGame.Models{
    public class Tablero{


        public string Title {get;set;}
        public int Id {get;set;}

        public List<Column> Columnas {get; set;} = new List<Column>();
        public string Descripcion{get;set;}
    }
}