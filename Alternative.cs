public class Alternative
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public Alternative(int id, string description, int points){
        Id = id;
        Description = description;
        Points = points;
    }
}