using MemberShip.Domain.Interfaces;
using MemberShip.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberShip.Infra.Data.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MemberContexto _context;
        private bool _disposed;
       
        public UnitOfWork(MemberContexto context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.SaveChanges();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
