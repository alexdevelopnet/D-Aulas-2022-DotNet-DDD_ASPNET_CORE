﻿using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly SqlServerContext _sqlContext;

        public BaseRepository(SqlServerContext mySqlContext)
        {
            _sqlContext = mySqlContext;
        }

        public void Insert(TEntity obj)
        {
            _sqlContext.Set<TEntity>().Add(obj);
            _sqlContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _sqlContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _sqlContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _sqlContext.Set<TEntity>().Remove(Select(id));
            _sqlContext.SaveChanges();
        }

        public IList<TEntity> Select() =>
            _sqlContext.Set<TEntity>().ToList();

        public TEntity Select(int id) =>
            _sqlContext.Set<TEntity>().Find(id);

    }
}