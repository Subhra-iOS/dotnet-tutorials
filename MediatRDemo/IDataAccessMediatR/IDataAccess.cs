using MediatRDemo.Models;

namespace MediatRDemo.IDataAccessMediatR
{
     public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
    }

}