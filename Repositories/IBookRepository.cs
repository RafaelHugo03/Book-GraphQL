using GraphQL_Project.Entities;

namespace GraphQL_Project.Repositories
{
    public interface IBookRepository
    {
        void Save(Book book);
        List<Book> GetBooks();
        Book GetBook(int id);
    }
}