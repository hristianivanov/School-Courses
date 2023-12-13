namespace BookStore.ViewModels.Book
{
    public class BookAllViewModel
    {
        public BookAllViewModel()
        {
            this.Books = new HashSet<BookViewModel>();
        }

        public ICollection<BookViewModel> Books { get; set; }
    }
}
