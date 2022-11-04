using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Udemy.CQRS.CQRS.Commands;
using Udemy.CQRS.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Udemy.CQRS.CQRS.Handlers
{
    public class UpdateStudentCommandHandler:IRequestHandler<UpdateStudentCommand>
    {
        private readonly StudentContext _context;

        public UpdateStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }
        public void Handle(UpdateStudentCommand command)
        {
            var updatedEntity = _context.Students.Find(command.Id);
            
            updatedEntity.Surname = command.Surname;
            updatedEntity.Name = command.Name;
            updatedEntity.Age = command.Age;
            _context.Update(updatedEntity);
            _context.SaveChanges();

        }

        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var updatedEntity = await _context.Students.FindAsync(request.Id);

            updatedEntity.Surname = request.Surname;
            updatedEntity.Name = request.Name;
            updatedEntity.Age = request.Age;
            _context.Update(updatedEntity);
            _context.SaveChanges();
            return Unit.Value;
        }
    }
}
