using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BookStore.Core
{
    public class AuthorServices : IAuthorServices
    {
        private readonly IMongoCollection<Author> _authors;
        public AuthorServices(IDbClient dbClient)
        {
            _authors = dbClient.GetAuthorsCollection();
        }
        public List<Author> GetAuthors() => _authors.Aggregate()
            .Lookup("Books", "Books", "_id", "Books")
            .As<Author>()
            .ToList();
    }
}
