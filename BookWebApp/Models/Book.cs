using System;
namespace BookWebApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string PublishedDate { get; set; }
        public string Description { get; set; }
        public string Isbn10 { get; set; }
        public string Isbn13 { get; set; }
        public string PageCount { get; set; }
        public string Thumbnail { get; set; }
        public string InfoLink { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }

}
}
