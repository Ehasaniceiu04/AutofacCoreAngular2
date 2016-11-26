using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.CoreApp.UnitOfWork
{
    interface IUnitOfWork
    {
        void Commit();
    }
}
