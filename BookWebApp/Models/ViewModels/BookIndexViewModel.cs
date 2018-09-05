using System;
using System.Collections.Generic; 


namespace BookWebApp.Models.ViewModels
{
    public class BookIndexViewModel
    {
        public IEnumerable<BookWebApp.Models.Book> Books { get; set; } 
        public string SelectedCategory { get; set; }
        public string[] Categories { get; set; }
    }
}
