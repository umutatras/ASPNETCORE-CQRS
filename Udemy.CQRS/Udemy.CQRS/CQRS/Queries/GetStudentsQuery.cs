using MediatR;
using System.Collections;
using System.Collections.Generic;
using Udemy.CQRS.CQRS.Handlers;
using Udemy.CQRS.CQRS.Results;

namespace Udemy.CQRS.CQRS.Queries
{
    public class GetStudentsQuery:IRequest<IEnumerable<GetStudentsQueryResult>>
    {
    }
}
