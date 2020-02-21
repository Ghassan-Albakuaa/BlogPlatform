
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
 public   interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable Find(int id);

        //Post Find2(int id);

        void Add(int id,T product);

        void Update(T product);

        void Delete(int id);

       
    }
}
