using Microsoft.EntityFrameworkCore;
using VideoGameApi.Models;

namespace VideoGameApi.Data;

public class VideoGameDBContext(DbContextOptions<VideoGameDBContext> options): DbContext(options)
{
    public DbSet<VideoGame> VideoGames   => Set<VideoGame>();
    public DbSet<VideoGameDetails> VideoGameDetails => Set<VideoGameDetails>();
    public DbSet<Developer> Developers => Set<Developer>(); 
    public DbSet<Publisher> Publishers => Set<Publisher>();

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<VideoGame>().HasData(
             new VideoGame
    {
        Id = 1,
        Title = "Spider-Man 2",
        Platform = "PS5",
       
    },
    new VideoGame
    {
        Id = 2,
        Title = "The Legend of Zelda: Breath of the Wild",
        Platform = "Nintendo Switch",
        
    },
    new VideoGame
    {
        Id = 3,
        Title = "God of War Ragnarok",
        Platform = "PS5",
      
    },
    new VideoGame
    {
        Id = 4,
        Title = "Halo Infinite",
        Platform = "Xbox Series X",
       
    },
    new VideoGame
    {
        Id = 5,
        Title = "Cyberpunk 2077",
        Platform = "PC",
      
    },
    new VideoGame
    {
        Id = 6,
        Title = "Elden Ring",
        Platform = "PS5, Xbox Series X, PC",
       
    },
    new VideoGame
    {
        Id = 7,
        Title = "Red Dead Redemption 2",
        Platform = "PC, PS4, Xbox One",
       
    },
    new VideoGame
    {
        Id = 8,
        Title = "The Witcher 3: Wild Hunt",
        Platform = "PC, PS4, Xbox One, Switch",
       
    },
    new VideoGame
    {
        Id = 9,
        Title = "Final Fantasy VII Remake",
        Platform = "PS4, PS5, PC",
       
    },
    new VideoGame
    {
        Id = 10,
        Title = "Grand Theft Auto V",
        Platform = "PC, PS5, Xbox Series X, PS4, Xbox One",
       
    }           
        );
    }

}