using System.Collections.Generic;

public class Form
{
    public int Id { get; set; }
    public string Description { get; set; }
    public List<Question> Questions { get; set; }
    
    public Form(int id, string description, List<Question> questions){
        Id = id;
        Description = description;
        Questions = questions;
    }
}