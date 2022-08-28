using MediatRDemo.ModelDto;
using MediatRDemo.Models;

namespace MediatRDemo.Extension
{
    public static class ModelExtensions 
    {
        public static PersonDto GetDto(this PersonModel person)
        {
            return new PersonDto 
            {
                Identifier = person.Identifier,
                FirstName = person.FirstName,
                LastName = person.LastName
            };
        }
    }
}