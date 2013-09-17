using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBookStore.Models
{
   // [Bind(Exclude="GenreId")]
    public class genreModel
    {
        [Key]
        [ScaffoldColumn(false)]              
        public int GenreId { get; set; }
        [Required(ErrorMessage="Genre Name Required")]
        public string Genre { get; set; }
    }
}