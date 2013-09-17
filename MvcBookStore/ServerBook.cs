using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcBookStore.Models;


namespace MvcBookStore
{
    public class ServerBook
    {
       
       public List<Book> GetBookList()
         {
            List <Book> list = new List<Book>();           
            list.Add(new Book
            {
                BookId = 1,
                BookName = "Harry Potter",
                GenreId=1,            
                WriterId=2,       
                Price=1999,
                ImagePath = "imagesH", 


            });
            list.Add(new Book
            {
                BookId = 2,
                BookName = "MyLove",
                GenreId=2,
                WriterId=1,
                Price=2500,
                ImagePath = "index1"
            });
              
             return list;
         }


    }
}