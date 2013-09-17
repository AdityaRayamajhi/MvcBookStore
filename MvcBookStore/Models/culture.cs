using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBookStore.Models
{
    public class culture
    {
        [Key]
        public int SN { get; set; }
        [Required]
        public string Culture { get; set; }
        [Required]
        public int GenreId { get; set; }
        public string Genre { get; set; }
        public string ABOUT { get; set; }
    }
}