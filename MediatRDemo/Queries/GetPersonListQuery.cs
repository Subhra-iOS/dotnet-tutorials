
using MediatR;
using MediatRDemo.ModelDto;

namespace MediatRDemo.Quries
{
    public class GetPersonListQuery: IRequest<List<PersonDto>>
    {

    }
}