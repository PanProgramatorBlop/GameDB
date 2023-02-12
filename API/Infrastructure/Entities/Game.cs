namespace API.Infrastructure.Entities;

public class Game
{
    public string Id { get; set; }
    public string Name { get; set; }
    public Developer Developer { get; set; }
}
