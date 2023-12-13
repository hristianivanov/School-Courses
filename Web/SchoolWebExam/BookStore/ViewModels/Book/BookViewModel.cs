namespace BookStore.ViewModels.Book
{
    public class BookViewModel
    {
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Author { get; set; } = null!;

        public int PublicationYear { get; set; }

        public string Publisher { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
