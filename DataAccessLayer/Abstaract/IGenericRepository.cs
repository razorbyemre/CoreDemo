﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstaract
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);  
        void Delete(T entity);
        T GetById(int id);

    }
}
