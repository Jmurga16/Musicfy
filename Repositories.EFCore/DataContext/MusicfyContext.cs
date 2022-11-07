using Entities.POCOEntities;
using Microsoft.EntityFrameworkCore;
using System;


namespace Repositories.EFCore.DataContext
{
    public class MusicfyContext : DbContext
    {
        public MusicfyContext(DbContextOptions<MusicfyContext> options) : base(options) { }

        public DbSet<Album> Albums { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Id Autogenerado
            modelBuilder.Entity<Album>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Album>()
                .HasData(
                new Album
                {
                    Id = 1,
                    Name = "El Ultimo Tour del Mundo",
                    Artist = "Bad Bunny",
                    Year = 2020,
                    ImageURL = "https://i1.sndcdn.com/artworks-lJMUnZEnRcJBpzvx-DftmXA-t500x500.jpg",
                    Status = true
                },
                new Album
                {
                    Id = 2,
                    Name = "¿A Donde Vamos?",
                    Artist = "Morat",
                    Year = 2021,
                    ImageURL = "https://master.com.ar/wp-content/uploads/0157657001625861386.jpg",
                    Status = true
                },
                new Album
                {
                    Id = 3,
                    Name = "YHLQMDLG",
                    Artist = "Bad Bunny",
                    Year = 2020,
                    ImageURL = "https://highxtar.com/wp-content/uploads/2021/06/highxtar-bad-bunny-yonaguni.jpg",
                    Status = true
                }
                ,
                new Album
                {
                    Id = 4,
                    Name = "Prestige",
                    Artist = "Daddy Yankee",
                    Year = 2012,
                    ImageURL = "https://pbs.twimg.com/profile_images/2646813310/d9ac92c40ba9bda82f98b7af85c117f3_400x400.jpeg",
                    Status = true
                }
                ,
                new Album
                {
                    Id = 5,
                    Name = "Mundial",
                    Artist = "Daddy Yankee",
                    Year = 2010,
                    ImageURL = "https://i1.sndcdn.com/artworks-000000813894-4w6ygg-t500x500.jpg",
                    Status = true
                }
                ,
                new Album
                {
                    Id = 6,
                    Name = "El Disco Duro",
                    Artist = "Daddy Yankee",
                    Year = 2010,
                    ImageURL = "https://i.pinimg.com/550x/cc/a0/66/cca06683ccc2ecaee4c7a6dd0bcb5295.jpg",
                    Status = true
                }
                ,
                new Album
                {
                    Id = 7,
                    Name = "X 100pre",
                    Artist = "Bad Bunny",
                    Year = 2018,
                    ImageURL = "https://i.pinimg.com/550x/cc/a0/66/cca06683ccc2ecaee4c7a6dd0bcb5295.jpg",
                    Status = true
                }
                 ,
                new Album
                {
                    Id = 8,
                    Name = "Oasis",
                    Artist = "Bad Bunny",
                    Year = 2019,
                    ImageURL = "https://i.pinimg.com/550x/cc/a0/66/cca06683ccc2ecaee4c7a6dd0bcb5295.jpg",
                    Status = true
                }
                 ,
                new Album
                {
                    Id = 9,
                    Name = "El Conejo Malo",
                    Artist = "Bad Bunny",
                    Year = 2017,
                    ImageURL = "https://i.pinimg.com/550x/cc/a0/66/cca06683ccc2ecaee4c7a6dd0bcb5295.jpg",
                    Status = true
                }
                 ,
                new Album
                {
                    Id = 10,
                    Name = "Las que no iban a salir",
                    Artist = "Bad Bunny",
                    Year = 2020,
                    ImageURL = "https://i.pinimg.com/550x/cc/a0/66/cca06683ccc2ecaee4c7a6dd0bcb5295.jpg",
                    Status = true
                }
                 ,
                new Album
                {
                    Id = 11,
                    Name = "Up Next",
                    Artist = "Bad Bunny",
                    Year = 2019,
                    ImageURL = "https://i.pinimg.com/550x/cc/a0/66/cca06683ccc2ecaee4c7a6dd0bcb5295.jpg",
                    Status = true
                }
                 ,
                new Album
                {
                    Id = 12,
                    Name = "Ocean",
                    Artist = "Karol G",
                    Year = 2019,
                    ImageURL = "https://i.pinimg.com/550x/cc/a0/66/cca06683ccc2ecaee4c7a6dd0bcb5295.jpg",
                    Status = true
                }
                 ,
                new Album
                {
                    Id = 13,
                    Name = "KG0516",
                    Artist = "Karol G",
                    Year = 2021,
                    ImageURL = "https://i.pinimg.com/550x/cc/a0/66/cca06683ccc2ecaee4c7a6dd0bcb5295.jpg",
                    Status = true
                }
                ,
                new Album
                {
                    Id = 14,
                    Name = "Unstoppable",
                    Artist = "Karol G",
                    Year = 2017,
                    ImageURL = "https://i.pinimg.com/550x/cc/a0/66/cca06683ccc2ecaee4c7a6dd0bcb5295.jpg",
                    Status = true
                }
                ,
                new Album
                {
                    Id = 15,
                    Name = "Super Single",
                    Artist = "Karol G",
                    Year = 2013,
                    ImageURL = "https://i.pinimg.com/550x/cc/a0/66/cca06683ccc2ecaee4c7a6dd0bcb5295.jpg",
                    Status = true
                }
                );


        }
    }
}
