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
    internal class CommentRepository : IGenericRepository<Comment>
    {
        private Context db;

        public CommentRepository(Context context)
        {
            this.db = context;

        }
        public void Add(Comment entity)
        {
            db.Comments.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Comment entity)
        {
            db.Comments.Remove(entity);
            db.SaveChanges();
        }

        public List<Comment> GetAll()
        {
            return db.Comments.ToList();
        }

        public Comment GetById(int id)
        {
            return db.Comments.Find(id);
            db.SaveChanges();
        }

        public void Update(Comment entity)
        {
            db.Comments.Update(entity);
        }
    }
}
