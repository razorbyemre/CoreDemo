using DataAccessLayer.Abstaract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IGenericRepository<Blog>
    {
        private Context db;
        public BlogRepository(Context context)
        {
            this.db = context;
        }

        public void Add(Blog entity)
        {
           db.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Blog entity)
        {
            db.Blogs.Find(entity);
            db.SaveChanges();
        }

        public List<Blog> GetAll()
        {
            return db.Blogs.ToList();
        }

        public Blog GetById(int id)
        {
            return  db.Blogs.Find(id);
        }

        public void Update(Blog entity)
        {
           db.Blogs.Update(entity);
            db.SaveChanges();
        }
    }
}
