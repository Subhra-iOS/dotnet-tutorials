using MediatRDemo.ModelDto;

namespace MediatRDemo.DataAccess
{
     public interface IDataAccess
    {
        List<PersonDto> GetPeople();
        PersonDto InsertPerson(string firstName, string lastName);
    }

}