using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RentalSystem.Models;
using RentalSystem.ViewModel;

namespace RentalSystem.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Books
        public ActionResult Index()
        {
            var books = db.Books.Include(b => b.Genre);
            return View(books.ToList());
        }

        // GET: Books/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }

            var model = new BookViewModel
            {
                Book = book,
                Genres = db.Genres.ToList()
            };
            return View(model);
        }

        // GET: Books/Create
        public ActionResult Create()
        {

            var genre = db.Genres.ToList();
            var model = new BookViewModel
            {
                Genres = genre.ToList()
            };
            //ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name");
            return View(model);
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookViewModel bookVM)
        {

            var book = new Book
            {
                Author = bookVM.Book.Author,
                Avaibility = bookVM.Book.Avaibility,
                DateAdded = bookVM.Book.DateAdded,
                Description = bookVM.Book.Description,
                Genre = bookVM.Book.Genre,
                GenreId = bookVM.Book.GenreId,
                ImageUrl = bookVM.Book.ImageUrl,
                ISBN = bookVM.Book.ISBN,
                Pages = bookVM.Book.Pages,
                Price = bookVM.Book.Price,
                Publisher = bookVM.Book.Publisher,
                ProductDemensions = bookVM.Book.ProductDemensions,
                PublicationDate = bookVM.Book.PublicationDate,
                Title = bookVM.Book.Title
            };

            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //var model = new BookViewModel
            //{
            //    Book = book,
            //    Genres = db.Genres.ToList()
            //};
            // return View(model);
            //ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", book.GenreId);
            bookVM.Genres = db.Genres.ToList();
            return View(bookVM);
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }

            var model = new BookViewModel
            {
                Book = book,
                Genres = db.Genres.ToList()
            };
            return View(model);
            //ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", book.GenreId);
            //return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,ISBN,Title,Author,Description,ImageUrl,Avaibility,Price,DateAdded,GenreId,PublicationDate,Pages,ProductDemensions")] Book book)
        public ActionResult Edit(BookViewModel bookVM)
        {
            var book = new Book
            {
                Id = bookVM.Book.Id,
                Author = bookVM.Book.Author,
                Avaibility = bookVM.Book.Avaibility,
                DateAdded = bookVM.Book.DateAdded,
                Description = bookVM.Book.Description,
                Genre = bookVM.Book.Genre,
                GenreId = bookVM.Book.GenreId,
                ImageUrl = bookVM.Book.ImageUrl,
                ISBN = bookVM.Book.ISBN,
                Pages = bookVM.Book.Pages,
                Price = bookVM.Book.Price,
                Publisher = bookVM.Book.Publisher,
                ProductDemensions = bookVM.Book.ProductDemensions,
                PublicationDate = bookVM.Book.PublicationDate,
                Title = bookVM.Book.Title
            };

            if (ModelState.IsValid)
            {
                // entityState is ok for small tables but don't use on big ones
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", book.GenreId);
            //return View(book);
            bookVM.Genres = db.Genres.ToList();
            return View(book);
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            var model = new BookViewModel
            {
                Book = book,
                Genres = db.Genres.ToList()
            };
            return View(model);
            // to be used if BookViewModel is not in use
            //return View(book);
        }

        // POST: Books/Delete/5
        // ActionName tells the MVC that the action below is a Delete action
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
