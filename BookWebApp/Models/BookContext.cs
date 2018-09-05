using System;
using Microsoft.EntityFrameworkCore;


namespace BookWebApp.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }


        public DbSet<Book> Book { get; set; }
    }
}
