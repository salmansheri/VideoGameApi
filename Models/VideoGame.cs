namespace VideoGameApi.Models;

public class VideoGame
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Platform { get; set; }
    // public int? DeveloperId { get; set; }
    public string? Developer { get; set; }
    // public int? PublisherId { get; set;}
    public string? Publisher { get; set; }
    public VideoGameDetails? VideoGameDetails { get; set; }
    
}