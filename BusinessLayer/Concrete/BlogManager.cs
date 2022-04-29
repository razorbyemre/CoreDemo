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
    public class BlogManager : IBlogService
    {
        IBlogDal _blog;
        public BlogManager(IBlogDal blog)
        {
            _blog = blog;


        }
        public void BlogAdd(Blog blog)
        {
            _blog.Add(blog);
        }

        public void BlogDelete(Blog blog)
        {
            _blog.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            _blog.Update(blog); 
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blog.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
           return _blog.GetById(id);
        }

        public List<Blog> GetBlogByID(int id)
        {
            //Buradaki getlistall parametre alan fonk.
            //Sartli listeleme yapacagimiz icin kullandik.
            return _blog.GetListAll(x => x.BlogiD == id);
        }

        public List<Blog> GetList()
        {
            return _blog.GetListAll(); 
        }
    }
}
