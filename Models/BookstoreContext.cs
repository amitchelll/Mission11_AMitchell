using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission11_AMitchell.Models;

public class BookstoreContext : DbContext
{
    public BookstoreContext()
    {
        
    }

    public BookstoreContext(DbContextOptions<BookstoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }
    
}
