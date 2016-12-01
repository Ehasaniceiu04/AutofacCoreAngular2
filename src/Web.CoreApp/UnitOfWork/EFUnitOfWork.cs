using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.CoreApp.Model;

namespace Web.CoreApp
{
    public class EFUnitOfWork : IUnitOfWork,IDisposable
    {
        private readonly EngineerContext _engineerContext;
        private bool disposed = false;
        public EFUnitOfWork(EngineerContext engineerContext)
        {
            _engineerContext = engineerContext;
        }

        void IUnitOfWork.Commit()
        {
            _engineerContext.SaveChanges();
        }
       

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _engineerContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
