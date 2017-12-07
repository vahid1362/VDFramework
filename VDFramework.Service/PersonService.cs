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
        private readonly IRepository<Person> _personRepository;
        private readonly IRepository<User> _useRepository;

        public PersonService()
        {
            _personRepository=new EFRepository<Person>();
            _useRepository=new EFRepository<User>();
        }


        public Person GetPerson(long personId)
        {
            return _personRepository.TableNoTracking.FirstOrDefault(x => x.Id == personId);
        }

        public User GetUser(long userId)
        {
            return _useRepository.TableNoTracking.FirstOrDefault(x => x.Id == userId);
        }



    }
}
