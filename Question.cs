using System.Collections.Generic;

public class Question
{
    public int Id { get; set; }
    public string Description { get; set; }
    public List<Alternative> Alternatives { get; set; }
    
    public Question(int id, string description, List<Alternative> alternatives)
    {
        Id = id;
        Description = description;
        Alternatives = alternatives;
    }
}