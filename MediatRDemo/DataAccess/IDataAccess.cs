using MediatRDemo.ModelDto;
using System.Collections.Generic;

namespace MediatRDemo.DataAccess
{
     public interface IDataAccess
    {
        IEnumerable<PersonDto> GetPeople();
        PersonDto InsertPerson(string firstName, string lastName);
    }

}