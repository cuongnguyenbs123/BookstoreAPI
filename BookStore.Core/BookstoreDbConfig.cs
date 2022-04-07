namespace BookStore.Core
{
    public class BookstoreDbConfig
    {
        public string Database_Name { get; set; } =String.Empty;    
        public string Book_Collection_Name { get; set; } = String.Empty;
        public string Connection_String { get; set; } =String.Empty;
        public string Author_Collection_Name { get; set; } = String.Empty;
    }
}
