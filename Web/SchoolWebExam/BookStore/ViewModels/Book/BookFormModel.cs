namespace BookStore.ViewModels.Book
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    public class BookFormModel
    {
        public string Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Author { get; set; } = null!;

        public int PublicationYear { get; set; }

        [Required]
        public string Publisher { get; set; } = null!;

        [Precision(18,2)]
        public decimal Price { get; set; }
    }
}
