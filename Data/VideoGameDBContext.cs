using Microsoft.EntityFrameworkCore;
using VideoGameApi.Models;

namespace VideoGameApi.Data;

public class VideoGameDBContext(DbContextOptions<VideoGameDBContext> options): DbContext(options)
{
    public DbSet<VideoGame> VideoGames   => Set<VideoGame>();

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<VideoGame>().HasData(
             new VideoGame
    {
        Id = 1,
        Title = "Spider-Man 2",
        Platform = "PS5",
        Developer = "Insomniac Games",
        Publisher = "Sony Interactive Entertainment"
    },
    new VideoGame
    {
        Id = 2,
        Title = "The Legend of Zelda: Breath of the Wild",
        Platform = "Nintendo Switch",
        Developer = "Nintendo EPD",
        Publisher = "Nintendo"
    },
    new VideoGame
    {
        Id = 3,
        Title = "God of War Ragnarok",
        Platform = "PS5",
        Developer = "Santa Monica Studio",
        Publisher = "Sony Interactive Entertainment"
    },
    new VideoGame
    {
        Id = 4,
        Title = "Halo Infinite",
        Platform = "Xbox Series X",
        Developer = "343 Industries",
        Publisher = "Xbox Game Studios"
    },
    new VideoGame
    {
        Id = 5,
        Title = "Cyberpunk 2077",
        Platform = "PC",
        Developer = "CD Projekt Red",
        Publisher = "CD Projekt"
    },
    new VideoGame
    {
        Id = 6,
        Title = "Elden Ring",
        Platform = "PS5, Xbox Series X, PC",
        Developer = "FromSoftware",
        Publisher = "Bandai Namco Entertainment"
    },
    new VideoGame
    {
        Id = 7,
        Title = "Red Dead Redemption 2",
        Platform = "PC, PS4, Xbox One",
        Developer = "Rockstar Games",
        Publisher = "Rockstar Games"
    },
    new VideoGame
    {
        Id = 8,
        Title = "The Witcher 3: Wild Hunt",
        Platform = "PC, PS4, Xbox One, Switch",
        Developer = "CD Projekt Red",
        Publisher = "CD Projekt"
    },
    new VideoGame
    {
        Id = 9,
        Title = "Final Fantasy VII Remake",
        Platform = "PS4, PS5, PC",
        Developer = "Square Enix",
        Publisher = "Square Enix"
    },
    new VideoGame
    {
        Id = 10,
        Title = "Grand Theft Auto V",
        Platform = "PC, PS5, Xbox Series X, PS4, Xbox One",
        Developer = "Rockstar North",
        Publisher = "Rockstar Games"
    }           
        );
    }

}