namespace VideoGameApi.Models;

public class VideoGameDetails
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public DateTime ReleaseData { get; set; }
    public int VidoeGameId { get; set; }
}