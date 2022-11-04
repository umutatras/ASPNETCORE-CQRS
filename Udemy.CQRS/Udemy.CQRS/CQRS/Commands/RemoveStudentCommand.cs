using MediatR;

namespace Udemy.CQRS.CQRS.Commands
{
    public class RemoveStudentCommand:IRequest
    {
        public RemoveStudentCommand(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
