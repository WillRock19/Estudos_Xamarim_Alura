namespace AluraApp.Domain
{
    public class Book
    {
        public string AuthorName { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Book(string name, string author, decimal price)
        {
            AuthorName = author;
            Name = name;
            Price = price;
        }
    }
}
