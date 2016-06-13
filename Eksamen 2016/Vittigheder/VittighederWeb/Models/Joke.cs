using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VittighederWeb.Models
{
    public class Joke
    {
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public string Author { get; set; }  
    }
}