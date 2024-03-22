namespace Mission11_AMitchell.Models.ViewModels;

public class BooksListViewModel
{
    public IQueryable<Book> Books { get; set; } = null!;

    public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
}