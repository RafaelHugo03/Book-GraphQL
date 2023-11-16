using GraphQL_Project.Api;
using GraphQL_Project.Data;
using GraphQL_Project.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BookContext>(opt => opt.UseInMemoryDatabase("graphQL-project"));
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

app.UseRouting().UseEndpoints(opt => opt.MapGraphQL());


app.Run();
