using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWeb.Model
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
              : base(options)
        { }

        public DbSet<Book> Book { get; set; }
        public DbSet<User> Users { get; set; }
    }
    
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Media { get; set; }
        public string Author { get; set; }
        public bool State { get; set; }

    }

    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNo { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string FavouritesCategories { get; set; }
        public bool IsAdmin { get; set; }
        
        public List<Book> RentedBooks { get; set; }
    }
}
