using DataAccessLayer.Abstaract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;//include metodu icin gerekli olan library
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDal
    {

        public List<Blog> GetListWithCategory()
        {
            using (var c = new Context())
            {
                //include fonk kullanilirken hangi entitiy 
                //include edilecek belirtilmeli.
                return c.Blogs.Include(x=> x.Category).ToList();
                  
            }
        }
    }
}
