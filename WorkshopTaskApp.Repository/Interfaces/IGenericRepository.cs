﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopTaskApp.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Add(T entity);
        void Update(T entity);
        Task<IQueryable<T>> FindByCondition(Expression<Func<T, bool>> expression = null);
    }
}
