
using MediatR;
using MediatRDemo.ModelDto;
using System.Collections.Generic;

namespace MediatRDemo.Quries
{
    public class GetPersonListQuery: IRequest<IEnumerable<PersonDto>>
    {

    }
}