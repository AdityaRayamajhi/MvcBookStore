using MvcBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MvcBookStore
{
    public class WebController : ApiController
    {
        // 
        public List<Book> GetBook()
        {
            BSEntity db = new BSEntity();
            List<Book> model = db.books.ToList();
            return model;

        }


        //public List<Book> GetBookList()
        //{
        //    List<Book> list = new List<Book>();
        //    list.Add(new Book
        //    {
        //        BookId = 1,
        //        BookName = "Harry Potter",
        //        GenreId = 1,
        //        WriterId = 2,
        //        Price = 1999,
        //        ImagePath = "imagesH",


        //    });
        //    list.Add(new Book
        //    {
        //        BookId = 2,
        //        BookName = "MyLove",
        //        GenreId = 2,
        //        WriterId = 1,
        //        Price = 2500,
        //        ImagePath = "index1"
        //    });

        //    return list;
        //}



        
    }
}