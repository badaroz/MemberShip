using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MemberShip.Domain.Interfaces.Services
{
    public interface IServices<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity cliente);
        TEntity Update(TEntity cliente);
        TEntity GetById(int id);
        TEntity Remove(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(int s, int t);
        IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, bool>>[] predicate);
        IEnumerable<TEntity> GetAll(int t, int s, params Expression<Func<TEntity, bool>>[] predicate);
    }
}
