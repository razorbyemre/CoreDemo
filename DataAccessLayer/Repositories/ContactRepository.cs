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
    public class ContactRepository : IGenericRepository<Contact>
    {
        private Context db;
        public ContactRepository(Context context)
        {
            db = context;
        }

        public void Add(Contact entity)
        {
            db.Contacts.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Contact entity)
        {
            db.Contacts.Remove(entity);
            db.SaveChanges();
        }

        public List<Contact> GetAll()
        {
            return db.Contacts.ToList();
        }

        public Contact GetById(int id)
        {
           return db.Contacts.Find(id);
        }

        public void Update(Contact entity)
        {
            db.Contacts.Update(entity);
            db.SaveChanges();
        }
    }
}
