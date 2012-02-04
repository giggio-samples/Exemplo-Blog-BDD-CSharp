using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.WebApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
    }
}