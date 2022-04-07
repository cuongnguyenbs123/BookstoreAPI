using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BookStore.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Book> _books;
        private readonly IMongoCollection<Author> _authors;

        public DbClient(IOptions<BookstoreDbConfig> bookstoreDbConfig)
        {
            var client = new MongoClient(bookstoreDbConfig.Value.Connection_String);
            var database = client.GetDatabase(bookstoreDbConfig.Value.Database_Name);
            _books = database.GetCollection<Book>(bookstoreDbConfig.Value.Book_Collection_Name);
            _authors = database.GetCollection<Author>(bookstoreDbConfig.Value.Author_Collection_Name);
        }

        public IMongoCollection<Book> GetBooksCollection() => _books;
        public IMongoCollection<Author> GetAuthorsCollection() => _authors;
    }
}
