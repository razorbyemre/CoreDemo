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
    public class WriterRepository : IGenericRepository<Writer>
    {
        private Context db;
        public WriterRepository(Context context)
        {
            db = context;
        }

        public void Add(Writer entity)
        {
           db.Add(entity); 
           db.SaveChanges();
        }

        public void Delete(Writer entity)
        {
            db.Remove(entity);
            db.SaveChanges();
        }

        public List<Writer> GetAll()
        {
            return db.Writers.ToList();

        }

        public Writer GetById(int id)
        {
           return db.Writers.Find(id);
        }

        public void Update(Writer entity)
        {
            db.Writers.Update(entity);
            db.SaveChanges();
        }
    }
}
