using MediatRDemo.IDataAccessMediatR;
using MediatRDemo.Models;
using MediatRDemo.ModelDto;

namespace MediatRDemo.DataAccessRepo
{
    public class DataAccessRepo
    {
        /*private readonly IDataAccessMediatR _mediatR;
        public DataAccessRepo(IDataAccessMediatR mediatR)
        {
            this._mediatR = mediatR;
        }*/

        private readonly List<PersonModel> people = new();

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel person = new PersonModel
            {
                Identifier = new Guid(),
                FirstName = firstName,
                LastName = lastName
            };
            people.Add(person);
            return person;
        }
    }
}