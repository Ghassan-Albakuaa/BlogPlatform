using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
       
        public virtual ICollection<Post> Product { get; set; }
        public Post()
        {

        }

        public Post(int id, string title, string author, DateTime publishDate)
        {
            Id = id;
            Title = title;
            Author = author;
            PublishDate = publishDate;
        }
        
        public Post Find(int id)
        {
            Post proModel = new Post();
            Id = id;
            return proModel;
        }

    }
}
