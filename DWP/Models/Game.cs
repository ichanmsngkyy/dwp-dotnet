namespace WebApplication.Models
{
    public class Game
    {
        public Game()
        {
            Artworks = [];
            Platforms = [];
            Genre = [];
        }

        public int Id { get; set; }
        public List<string> Artworks { get; set; }
        public required string GameType { get; set; }
        public required string Title { get; set; }
        public string? Slug { get; set; }
        public List<string> Platforms { get; set; }
        public List<string> Genre { get; set; }
        public string? Developer { get; set; }
        public int ReleaseYear { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}