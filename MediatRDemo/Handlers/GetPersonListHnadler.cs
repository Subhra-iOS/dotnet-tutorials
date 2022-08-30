using MediatR;
using MediatRDemo.Quries;
using MediatRDemo.ModelDto;
using MediatRDemo.DataAccess;
using System.Collections.Generic;

namespace MediatRDemo.Handlers
{
    public class GetPersonListHnadler : IRequestHandler<GetPersonListQuery, IEnumerable<PersonDto>>
    {
        private readonly IDataAccess _data;

        public GetPersonListHnadler(IDataAccess data)
        {
            _data = data;
        }
        public Task<IEnumerable<PersonDto>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetPeople());
        }
    }
}