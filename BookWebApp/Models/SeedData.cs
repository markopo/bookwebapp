using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Threading; 
using System.Collections.Generic; 

namespace BookWebApp.Models
{
    public static class SeedData
    {


        public static void Initialize(IServiceProvider serviceProvider) {

            using (var context = new BookContext(serviceProvider.GetRequiredService<DbContextOptions<BookContext>>()))
            {

                if (context.Book.Any())
                {
                    return;
                }

                /**
                context.Book.Add(new Book
                {
                    Title = "React.js Essentials",
                    Slug = "reactjs-essentials",
                    Author = "Artemij Fedosejev"
                });

                context.SaveChanges(); 
                */

                var fetchBookService = new FetchBookService(context); 

                foreach(var category in Categories.Get) {
                    Task.Run(() => fetchBookService.FetchByCategory(category)).GetAwaiter().GetResult(); 
                }

            }
        }


      

    
    }
}
