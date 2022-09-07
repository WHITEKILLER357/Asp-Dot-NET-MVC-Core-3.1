using BookStoreMVC.Models;
using BookStoreMVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _BookRepository = null;
        
       
        public BookController()
        {
            _BookRepository = new BookRepository();
        }

       public List<BookModel> GetAllBooks()
        {
            return _BookRepository.GetAllBooks();
        }


        public BookModel GetBookById(int id)
        {
            return _BookRepository.GetBookById(id);
        }


        public List<BookModel> SearchBook(string book, string Author)
        {
            return _BookRepository.SearchBook(book,Author);
        }

    }
}
