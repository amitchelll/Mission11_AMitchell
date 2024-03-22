namespace Mission11_AMitchell.Models;

public interface IBookRepository
{
    public IQueryable<Book> Books { get; }
}