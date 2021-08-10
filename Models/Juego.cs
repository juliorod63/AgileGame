using System.Collections.Generic;

namespace AgileGame.Models{  

    public class Juego{

        public List<Jugador> Equipo {get;set;}

        private List<Jugador> _Jugadores;

        public Juego(){
             _Jugadores = new List<Jugador>();
        }
        private int _semana=0;
        public  int Semana {get;set;}
        
        public int Dia {get;set;}
        
    }


}