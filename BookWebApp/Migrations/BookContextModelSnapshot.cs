﻿// <auto-generated />
using BookWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookWebApp.Migrations
{
    [DbContext(typeof(BookContext))]
    partial class BookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932");

            modelBuilder.Entity("BookWebApp.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Category");

                    b.Property<string>("Description");

                    b.Property<string>("InfoLink");

                    b.Property<string>("Isbn10");

                    b.Property<string>("Isbn13");

                    b.Property<string>("Language");

                    b.Property<string>("PageCount");

                    b.Property<string>("PublishedDate");

                    b.Property<string>("Publisher");

                    b.Property<string>("Slug");

                    b.Property<string>("Thumbnail");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Book");
                });
#pragma warning restore 612, 618
        }
    }
}
