using System.Collections.Generic;
    
public class Column
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<Card> Cards { get; set; } = new List<Card>();
}