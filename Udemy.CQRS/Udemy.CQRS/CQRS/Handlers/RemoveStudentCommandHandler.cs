using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Udemy.CQRS.CQRS.Commands;
using Udemy.CQRS.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Udemy.CQRS.CQRS.Handlers
{
    public class RemoveStudentCommandHandler:IRequestHandler<RemoveStudentCommand>
    {
        private readonly StudentContext _context;

        public RemoveStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }
        //public void Handle(RemoveStudentCommand command)
        //{
        //    var deletedEntity = _context.Students.Find(command.Id);
        //    _context.Students.Remove(deletedEntity);
        //    _context.SaveChanges();
        //}

        public async Task<Unit> Handle(RemoveStudentCommand request, CancellationToken cancellationToken)
        {
            var deletedEntity = await _context.Students.FindAsync(request.Id);
            _context.Students.Remove(deletedEntity);
           await  _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
