using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDFramework.Core.Data;
using VDFramework.Core.Person;
using VDFramework.Data;

namespace VDFramework.Service
{
    public class PersonService
    {
        private readonly UnitOfWork _unitOfWork;
       

        public PersonService()
        {
         _unitOfWork=new UnitOfWork();
        }


        public Person GetPerson(long personId)
        {
            return _unitOfWork.PersonRepository.TableNoTracking.FirstOrDefault(x => x.Id == personId);
        }

        public User GetUser(long userId)
        {
            return _unitOfWork.UserRepository.TableNoTracking.FirstOrDefault(x => x.Id == userId);
        }



    }
}
