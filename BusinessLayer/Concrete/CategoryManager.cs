using BusinessLayer.Abstracts;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;


namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        Context db = new Context();
        EFCategoryRepository eFCategory;

        public CategoryManager()
        {
           eFCategory = new EFCategoryRepository();   
        }
        public void CategoryAdd(Category category)
        {
            eFCategory.Add(category);
        }

        public void CategoryDelete(Category category)
        {
            eFCategory.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
           eFCategory.Update(category);
        }

        public Category GetById(int id)
        {
            return eFCategory.GetById(id);
        }

        public List<Category> GetList()
        {
            return eFCategory.GetAll();
        }
    }
}
