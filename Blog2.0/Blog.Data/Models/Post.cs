using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Authors { get; set; }
        public CategoryType Category { get; set; }
    }
}
