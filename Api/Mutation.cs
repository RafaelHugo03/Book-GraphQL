using GraphQL_Project.Entities;
using GraphQL_Project.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GraphQL_Project.Api
{
    public class Mutation
    {
        public Book UpsertBook([FromServices] IBookRepository bookRepository, Book book)
        {
            bookRepository.Save(book);
            return book;
        }
    }
}