using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameApi.Models
{
    public class VideoGameDetails
    {
        public int Id { get;set; }
        public string? Description { get;set;}
        public DateTime ReleaseDate { get; set; }
        public int VideoGameId { get; set; }
        [ForeignKey("VideoGameId")]
        public VideoGame? VideoGame { get; set; }
    }
}