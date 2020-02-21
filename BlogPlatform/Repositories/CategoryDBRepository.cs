
using BlogPlatform.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class CategoryDBpository : IRepository<Category>
    {
        PostDbContext db;

        public CategoryDBpository(PostDbContext _db)
        {
            db = _db;
        }

        public void Add(int id, Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();

        }


        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Tag Find2(int id)
        {
            var tag = db.Tags.SingleOrDefault(b => b.Id == id);
            return tag;
        }

        public void Update(int id, Category category)
        {
            db.Update(category);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var category = Find(id);
            db.Remove(category);
            db.SaveChanges();
        }

        IEnumerable<Category> IRepository<Category>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Tag Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Tag tag)
        {
            throw new NotImplementedException();
        }

        IEnumerable IRepository<Category>.Find(int id)
        {
            throw new NotImplementedException();
        }
         
        public void Update(Category product)
        {
            throw new NotImplementedException();
        }

      
    }
}
