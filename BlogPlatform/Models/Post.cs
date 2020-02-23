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
        public string Description { get; set; }
        public string PublishDate { get; set; }
        public virtual Category Category { get; set; }
        public virtual int CategoryId { get; set; }
       

      
        public Post()
        {

        }

        public Post(int id, string title, string author, string publishDate , string description)
        {
            Id = id;
            Title = title;
            Author = author;
            PublishDate = publishDate;
            Description = description;
        }
        
        public Post Find(int id)
        {
            Post postModel = new Post();
            Id = id;
            return postModel;
        }

    }
}
