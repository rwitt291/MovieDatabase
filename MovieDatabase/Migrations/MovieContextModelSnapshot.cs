// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieDatabase.Models;

namespace MovieDatabase.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("MovieDatabase.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Micellaneous"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("MovieDatabase.Models.NewMovieResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 4,
                            Director = "Pierre Cofflin, Chris Renaud",
                            Edited = false,
                            Rating = "PG",
                            Title = "Despicable Me",
                            Year = (ushort)2010
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 1,
                            Director = "Christopher Nolan",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Inception",
                            Year = (ushort)2010
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 3,
                            Director = "Gil Junger",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "10 Things I Hate About You",
                            Year = (ushort)1999
                        });
                });

            modelBuilder.Entity("MovieDatabase.Models.NewMovieResponse", b =>
                {
                    b.HasOne("MovieDatabase.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
