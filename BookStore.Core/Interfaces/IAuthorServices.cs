using System.Collections.Generic;
using MongoDB.Bson;

namespace BookStore.Core
{
     public interface IAuthorServices
    {
        List<Author> GetAuthors();
    }
}
