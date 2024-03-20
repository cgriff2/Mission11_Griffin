namespace Mission11_Griffin.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
