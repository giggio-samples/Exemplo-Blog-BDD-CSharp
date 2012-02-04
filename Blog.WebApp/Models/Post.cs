using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.WebApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }

        public string Corpo { get; set; }

        public DateTime Data { get; set; }

        public string Autor { get; set; }
    }
}