namespace Mission11_AMitchell.Models;

public class EfBookRepository : IBookRepository
{
    private BookstoreContext _context;

    public EfBookRepository(BookstoreContext temp)
    {
        _context = temp;
    }

    public IQueryable<Book> Books => _context.Books;
}