using GraphQL_Project.Entities;
using GraphQL_Project.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GraphQL_Project.Api
{
    public class Query
    {
        public List<Book> GetBooks([FromServices] IBookRepository bookRepository)
        {
            return bookRepository.GetBooks();
        }

        public Book GetBook([FromServices] IBookRepository bookRepository, int id)
        {
            return bookRepository.GetBook(id);
        }
    }
}