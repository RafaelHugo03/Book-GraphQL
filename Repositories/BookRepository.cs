using GraphQL_Project.Data;
using GraphQL_Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_Project.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext context;
        private readonly DbSet<Book> books;

        public BookRepository(BookContext context)
        {
            this.context = context;
            books = context.Set<Book>();
        }
        public  Book GetBook(int id)
        {
            return books.AsNoTracking().FirstOrDefault(q => q.Id == id);
        }

        public List<Book> GetBooks()
        {
            return  books.AsNoTracking().ToList();
        }

        public void Save(Book book)
        {
            var isNew = !book.Id.HasValue;

            if(isNew)
            {
                books.Add(book);
                context.SaveChanges();
                return;
            }

            books.Update(book);
            context.SaveChanges();
        }
    }
}