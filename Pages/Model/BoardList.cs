using System.Collections.Generic;

public class BoardList{


    public List<Board> Boards { get; set; } = new List<Board>();
    public class Board{
        public string Title {get;set;}
        public int Id {get;set;}
    }
}
