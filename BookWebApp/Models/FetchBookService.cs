using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BookWebApp.Models
{
    public class FetchBookService
    {

        private readonly BookContext _context;


        public FetchBookService(BookContext context)
        {
            _context = context; 
        }


        public async Task FetchByCategory(string category)
        {

            if(string.IsNullOrEmpty(category)){
                return; 
            }

              var existingBook = _context.Book.Any(m => m.Category == category); 

              // Check that no existing books in that don't exist. 
              if (!existingBook)
              {
                    var books = await GetResponse(category);

                    foreach (var book in books)
                    {
                        book.Id = 0; 
                        book.Category = category;
                    }

                    await _context.Book.AddRangeAsync(books);
                    await _context.SaveChangesAsync();
               }
        }


        public async Task<IEnumerable<Book>> GetResponse(string category) {

            using (HttpClient client = new HttpClient())
            {
                var url = $"https://kylmakalja.eu/findbooks?title={category}&author=&isbn10=&isbn13=";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Book>>(responseBody);
            }
        }


    }
}
