using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
     //   public virtual ICollection<ProductModel> Product { get; set; }
        public Tag()
        {

        }
                      
        public Tag(int  id, string name)
        {
            Id = id;
            Name = name;
        }
        public Tag Find(int id)
        {
            Tag proModel = new Tag();
            Id = id;
            return proModel;
        }
        

    }
}
