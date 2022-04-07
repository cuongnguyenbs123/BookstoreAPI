using System.Collections.Generic;


namespace BookStore.Core
{
     public interface IAuthorServices
    {
        List<Author> GetAuthors();
    }
}
