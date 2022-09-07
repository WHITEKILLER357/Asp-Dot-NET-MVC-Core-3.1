using BookStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMVC.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.id == id).FirstOrDefault();
        }


        public List<BookModel> SearchBook(string Title,string Author)
        {
            return DataSource().Where(x => x.Title.Contains(Title) || x.Author.Contains(Author)).ToList();
        }


        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
               new BookModel(){id=1,Title="MVC",Author="white"},
               new BookModel(){id=2,Title="MVC Core",Author="vellai"},
               new BookModel(){id=3,Title="Dot Net",Author="killer" },
               new BookModel(){id=4,Title="WEB API",Author="white" },
               new BookModel(){id=5,Title="Nodejs",Author="vellai" }
            };
        }




    }
}
