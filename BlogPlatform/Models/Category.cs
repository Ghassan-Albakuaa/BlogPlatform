using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
             
    //    public virtual Post ReviewPro { get; set; }

      //  public virtual int ReviewId { get; set; }

        public Category()
        {

        }

        public Category(int id, string name, string description)
        {
            Id = id;
            Name = name;
           
        }

        public Category(int id, string name, string description, string image, string review)
        {
            Id = id;
            Name = name;
           
        }
        public Category Find(int id)
        {
            Category proModel = new Category();
            Id = id;
            return proModel;
        }

        public static implicit operator DbSet<object>(Category v)
        {
            throw new NotImplementedException();
        }
    }
}