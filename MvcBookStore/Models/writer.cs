using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBookStore.Models
{
    public class writer
    {
        public int WriterId {get; set;}

        [Required(ErrorMessage="Writer Name Required")]
        public string Writer   {get; set;}
    }
}