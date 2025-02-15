﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VideoGameApi.Data;

#nullable disable

namespace VideoGameApi.Migrations
{
    [DbContext(typeof(VideoGameDBContext))]
    partial class VideoGameDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("VideoGameApi.Models.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Developer")
                        .HasColumnType("text");

                    b.Property<string>("Platform")
                        .HasColumnType("text");

                    b.Property<string>("Publisher")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Platform = "PS5",
                            Title = "Spider-Man 2"
                        },
                        new
                        {
                            Id = 2,
                            Platform = "Nintendo Switch",
                            Title = "The Legend of Zelda: Breath of the Wild"
                        },
                        new
                        {
                            Id = 3,
                            Platform = "PS5",
                            Title = "God of War Ragnarok"
                        },
                        new
                        {
                            Id = 4,
                            Platform = "Xbox Series X",
                            Title = "Halo Infinite"
                        },
                        new
                        {
                            Id = 5,
                            Platform = "PC",
                            Title = "Cyberpunk 2077"
                        },
                        new
                        {
                            Id = 6,
                            Platform = "PS5, Xbox Series X, PC",
                            Title = "Elden Ring"
                        },
                        new
                        {
                            Id = 7,
                            Platform = "PC, PS4, Xbox One",
                            Title = "Red Dead Redemption 2"
                        },
                        new
                        {
                            Id = 8,
                            Platform = "PC, PS4, Xbox One, Switch",
                            Title = "The Witcher 3: Wild Hunt"
                        },
                        new
                        {
                            Id = 9,
                            Platform = "PS4, PS5, PC",
                            Title = "Final Fantasy VII Remake"
                        },
                        new
                        {
                            Id = 10,
                            Platform = "PC, PS5, Xbox Series X, PS4, Xbox One",
                            Title = "Grand Theft Auto V"
                        });
                });

            modelBuilder.Entity("VideoGameApi.Models.VideoGameDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("VideoGameId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VideoGameId")
                        .IsUnique();

                    b.ToTable("VideoGameDetails");
                });

            modelBuilder.Entity("VideoGameApi.Models.VideoGameDetails", b =>
                {
                    b.HasOne("VideoGameApi.Models.VideoGame", "VideoGame")
                        .WithOne("VideoGameDetails")
                        .HasForeignKey("VideoGameApi.Models.VideoGameDetails", "VideoGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VideoGame");
                });

            modelBuilder.Entity("VideoGameApi.Models.VideoGame", b =>
                {
                    b.Navigation("VideoGameDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
