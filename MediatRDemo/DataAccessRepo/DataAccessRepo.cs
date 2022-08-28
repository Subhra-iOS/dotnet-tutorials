using MediatRDemo.Models;
using MediatRDemo.ModelDto;
using MediatRDemo.Extension;
using MediatRDemo.DataAccess;

namespace MediatRDemo.DataAccessRepo
{
    public class DataAccessRepo : IDataAccess
    {
        private readonly List<PersonModel> people = new();

        public List<PersonDto> GetPeople()
        {
            var personList = people.Select(person => person.GetDto());

            if (personList == null)
            {
                return NotFound();
            }

            return (List<PersonDto>)personList;
        }

        public PersonDto InsertPerson(string firstName, string lastName)
        {
            PersonModel person = new PersonModel
            {
                Identifier = new Guid(),
                FirstName = firstName,
                LastName = lastName
            };
            people.Add(person);
            return person.GetDto();
        }
    }
}