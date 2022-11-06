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
                });


        }
    }
}
