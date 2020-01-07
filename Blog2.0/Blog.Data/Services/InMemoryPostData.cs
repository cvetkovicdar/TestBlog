using Blog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Data.Services
{
    public class InMemoryPostData : IPostData
    {
        List<Post> posts;

        public InMemoryPostData()
        {
            posts = new List<Post>()
            {
                new Post { Id = 1, Title = "NBA Hightlights", Date = "2020-01-07", Authors = "DC", Category = CategoryType.Sport },
                new Post { Id = 2, Title = "AV Rules Again", Date = "2020-01-07", Authors = "IvanRDVC", Category = CategoryType.Politics },
                new Post { Id = 3, Title = "How to Earn more Money", Date = "2020-01-07", Authors = "Ivke", Category = CategoryType.Bussiness }
            };
        }
        public IEnumerable<Post> GetAll()
        {
            return posts.OrderBy(p => p.Title);
        }
    }
}
