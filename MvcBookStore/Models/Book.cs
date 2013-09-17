using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBookStore.Models
{
   // [Bind(Exclude = "BookId")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Book Name Required")]
        public string BookName { get; set; }
        [Required]
        public int GenreId { get; set; }
        [Required]
        public int WriterId { get; set; }
        public string ImagePath { get; set; }
        [Required]
        public double Price { get; set; }
        public string ABOUT { get; set; }
        //public int remarks { get; set; }


        // lazy loading ..............(loads both GenreName & Genre Id in "Genre")....helps in Partial View
        public virtual genreModel Genre { get; set; }
        // lazy loading ..............(loads both WriterName & WriterId in "Writer")....helps in Partial View
        public virtual writer Writer { get; set; }

          }
}
   