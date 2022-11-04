using MediatR;
using Udemy.CQRS.CQRS.Handlers;
using Udemy.CQRS.CQRS.Results;

namespace Udemy.CQRS.CQRS.Queries
{
    public class GetStudentByIdQuery:IRequest<GetStudentByIdQueryResult>
    {
        public GetStudentByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
