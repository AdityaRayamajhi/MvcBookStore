using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBookStore.Infrastructure
{   //creating a Class "Truncate" for the overall and wide use..................
    public static class Helper
    {
        public static string Truncate(this HtmlHelper helper, string input, int length)
        {


            try
            {
                if (input.Length > length)
                {
                    return input.Substring(0, length) + "...";
                }
                else
                {
                    return (input);
                }
            }
            catch
            {
                return "...";
            }
        }
       
    }
}