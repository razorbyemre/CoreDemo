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
    public  class AboutRepository : IGenericRepository<About>
    {
        private Context db; 

        public AboutRepository(Context context)
        {
            db = context;
        }
        public void Add(About entity)
        {
            db.Abouts.Add(entity);
            db.SaveChanges();
        }

        public void Delete(About entity)
        {
           db.Abouts.Remove(entity);    
           db.SaveChanges();
        }

        public List<About> GetAll()
        {
           return db.Abouts.ToList();   
        }

        public About GetById(int id)
        {
            return db.Abouts.Find(id);
        }

        public void Update(About entity)
        {
            db.Abouts.Update(entity);
        }
    }
}
