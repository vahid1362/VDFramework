using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDFramework.Core.Data;
using VDFramework.Core.Person;

namespace VDFramework.Data
{
   public class UnitOfWork :IUnitOfWork,IDisposable
    {
        private  IRepository<Person> _personRepository;
        private  IRepository<User> _userRepository;

        private readonly VdObjectContext _vdObjectContext;

        public UnitOfWork()
        {
            _vdObjectContext=new VdObjectContext();
        }

        public IRepository<Person> PersonRepository => this._personRepository ?? new EFRepository<Person>(_vdObjectContext);

        public IRepository<User> UserRepository => this._userRepository ?? new EFRepository<User>(_vdObjectContext);


        public int SaveChanges()
        {
          return   _vdObjectContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _vdObjectContext.Dispose();
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
