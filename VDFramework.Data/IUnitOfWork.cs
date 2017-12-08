using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDFramework.Data
{
    public interface IUnitOfWork
    {
     
        int SaveChanges();
    }
}
