using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MemberShip.Domain.Interfaces.Repositories
{
   public interface IRepository<TEntity>: IDisposable where TEntity: class
    {
        TEntity Update(TEntity obj);
        TEntity GetById(int id);
        TEntity Remove(int id);
        IEnumerable<TEntity> GetAll();
        TEntity Adicionar(TEntity obj);
        //IEnumerable<TEntity> GetAll(int s, int t);
        //IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, bool>>[] predicate);
        //IEnumerable<TEntity> GetAll(int t, int s, params Expression<Func<TEntity, bool>>[] predicate);
        //IEnumerable<TEntity> GetAllAsNoTracking();
        //IEnumerable<TEntity> GetAllAsNoTracking(params Expression<Func<TEntity, bool>>[] predicate);
        int SaveChanges();

    }
}
