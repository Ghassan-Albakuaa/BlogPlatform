
using BlogPlatform.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class TagDBpository : IRepository<Tag>
    {
        PostDbContext db;

        public TagDBpository(PostDbContext _db)
        {
            db = _db;
        }

        public void Add(int id, Tag tag)
        {
            db.Tags.Add(tag);
            db.SaveChanges();

        }


        public IEnumerable<Tag> GetAll()
        {
            return db.Tags.ToList();
        }

        public Tag Find2(int id)
        {
            var tag = db.Tags.SingleOrDefault(b => b.Id == id);
            return tag;
        }

        public void Update(int id, Tag tag)
        {
            db.Update(tag);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var tag = Find(id);
            db.Remove(tag);
            db.SaveChanges();
        }
               
        
        public Tag Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Tag tag)
        {
            throw new NotImplementedException();
        }

       

        public void Add(int id, Post product)
        {
            throw new NotImplementedException();
        }

        public void Update(Post product)
        {
            throw new NotImplementedException();
        }

        IEnumerable IRepository<Tag>.Find(int id)
        {
            throw new NotImplementedException();
        }

        public Tag GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
