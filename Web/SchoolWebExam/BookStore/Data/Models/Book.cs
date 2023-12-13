namespace BookStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        public Book()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Author { get; set; } = null!;

        public int PublicationYear { get; set; }

        [Required]
        public string Publisher { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
