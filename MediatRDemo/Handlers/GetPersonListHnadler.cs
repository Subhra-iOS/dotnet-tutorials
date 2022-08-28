using MediatR;
using MediatRDemo.Quries;
using MediatRDemo.ModelDto;
using MediatRDemo.DataAccess;

namespace MediatRDemo.Handlers
{
    public class GetPersonListHnadler : IRequestHandler<GetPersonListQuery, List<PersonDto>>
    {
        private readonly IDataAccess _data;

        public GetPersonListHnadler(IDataAccess data)
        {
            _data = data;
        }
        public Task<List<PersonDto>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetPeople());
        }
    }
}