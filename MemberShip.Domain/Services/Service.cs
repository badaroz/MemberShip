using MemberShip.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using MemberShip.Domain.Interfaces.Repositories;
using MemberShip.Domain.Interfaces;

namespace MemberShip.Domain.Services
{
    public class Service<TEntity> : IServices<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _clienteRepository;
        protected IUnitOfWork uow;
        public Service(IRepository<TEntity> clienteRepository, IUnitOfWork uoW)
        {
            uow = uoW;
            _clienteRepository = clienteRepository;
        }

        public TEntity Add(TEntity entidade)
        {
            var obj = _clienteRepository.Adicionar(entidade);
            if (obj != null)
            {
                uow.Commit();
            }
            return obj;
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, bool>>[] predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll(int s, int t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll(int t, int s, params Expression<Func<TEntity, bool>>[] predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            return _clienteRepository.GetById(id);
        }

        public TEntity Remove(int id)
        {
            var obj = _clienteRepository.Remove(id);
            if (obj != null)
            {
                uow.Commit();
            }
            return obj;
        }

        public TEntity Update(TEntity cliente)
        {
            var obj = _clienteRepository.Update(cliente);
            if (obj != null)
            {
                uow.Commit();
            }
            return obj;
        }
    }
}
