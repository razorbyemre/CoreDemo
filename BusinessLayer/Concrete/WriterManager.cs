using BusinessLayer.Abstracts;
using DataAccessLayer.Abstaract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService

    {
        IWriterDal db; 
        public WriterManager(IWriterDal writerDal)
        {
            db = writerDal;

        }

        public void WriteAdd(Writer writer)
        {
            db.Add(writer);
        }
    }
}
