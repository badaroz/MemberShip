using MemberShip.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using MemberShip.Infra.Data.Context;
using System.Data.Entity;

namespace MemberShip.Infra.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected MemberContexto Db;
        protected DbSet<TEntity> DbSet;

        public Repository(MemberContexto context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }
        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        //public IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, bool>>[] predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<TEntity> GetAll(int s, int t)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<TEntity> GetAll(int t, int s, params Expression<Func<TEntity, bool>>[] predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<TEntity> GetAllAsNoTracking()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<TEntity> GetAllAsNoTracking(params Expression<Func<TEntity, bool>>[] predicate)
        //{
        //    throw new NotImplementedException();
        //}

        public TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public TEntity Remove(int id)
        {
            var entity = DbSet.Find(id);
            DbSet.Remove(entity);
            return entity;
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public TEntity Update(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            return obj;
        }

        public virtual TEntity Adicionar(TEntity obj)
        {
            //Db.Dispose = false;
            var returnObj = DbSet.Add(obj);
            return returnObj;
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
