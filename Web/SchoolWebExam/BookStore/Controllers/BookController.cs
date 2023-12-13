using BookStore.Data.Models;

namespace BookStore.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Data;
    using BookStore.ViewModels.Book;
    using Microsoft.EntityFrameworkCore;

    public class BookController : Controller
    {
        private readonly BookDbContext dbContext;

        public BookController(BookDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var allBooks = await this.dbContext
                .Books
                .Select(b => new BookViewModel
                {
                    Id = b.Id.ToString(),
                    Author = b.Author,
                    Price = b.Price,
                    PublicationYear = b.PublicationYear,
                    Publisher = b.Publisher,
                    Title = b.Title,
                })
                .ToListAsync();

            BookAllViewModel model = new BookAllViewModel()
            {
                Books = allBooks
            };


            return this.View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new BookFormModel();

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(BookFormModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return this.View(model);
            //}

            try
            {
                var bookDb = new Book()
                {
                    Author = model.Author,
                    Price = model.Price,
                    PublicationYear = model.PublicationYear,
                    Publisher = model.Publisher,
                    Title = model.Title,
                };

                await this.dbContext.Books.AddAsync(bookDb);
                await this.dbContext.SaveChangesAsync();

                model.Id = bookDb.Id.ToString();
                model.Title = bookDb.Title;
                model.Author = bookDb.Author;
                model.Price = bookDb.Price;
                model.PublicationYear = bookDb.PublicationYear;
                model.Publisher = bookDb.Publisher;

                return this.RedirectToAction("All");
            }
            catch (Exception)
            {
                return this.View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var book = await this.dbContext
                .Books
                .FirstOrDefaultAsync(b => b.Id.ToString() == id);

            if (book == null)
            {
                return this.RedirectToAction("All");
            }

            var model = new BookFormModel()
            {
                Id = book.Id.ToString(),
                Author = book.Author,
                Price = book.Price,
                PublicationYear = book.PublicationYear,
                Publisher = book.Publisher,
                Title = book.Title,
            };


            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BookFormModel model, string id)
        {
            //if (!ModelState.IsValid)
            //{
            //    return this.View(model);
            //}

            var book = await this.dbContext
                .Books
                .FirstOrDefaultAsync(b => b.Id.ToString() == id);

            if (book != null)
            {
                //book.Title = model.Title;
                //book.Author = model.Author;
                book.Publisher = model.Publisher;
                book.PublicationYear = model.PublicationYear;
                book.Price = model.Price;

                await this.dbContext.SaveChangesAsync();
            }

            return this.RedirectToAction("All");
        }


        [HttpGet]
        public async Task<IActionResult> SearchAll()
        {
	        var maxPriceBook = await this.dbContext
		        .Books
		        .OrderByDescending(b => b.Price)
		        .Select(b => new BookViewModel
		        {
                    Id = b.Id.ToString(),
                    Author = b.Author,
                    Price= b.Price,
                    Publisher = b.Publisher,
                    PublicationYear= b.PublicationYear,
                    Title = b.Title,
		        })
		        .FirstAsync();

	        var author = "Dan Brown";

            var authorBook = await this.dbContext
	            .Books
	            .Select(b => new BookViewModel
	            {
		            Id = b.Id.ToString(),
		            Author = b.Author,
		            Price = b.Price,
		            Publisher = b.Publisher,
		            PublicationYear = b.PublicationYear,
		            Title = b.Title,
	            })
				.FirstOrDefaultAsync(b => b.Author == author);

            //nqma vreme]


            var model = new SearchViewModel()
            {
	            AuthorBook = authorBook,
	            PriceBook = maxPriceBook
            };

            return this.View(model);
        }
    }
}
