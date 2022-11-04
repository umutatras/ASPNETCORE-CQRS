using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Udemy.CQRS.CQRS.Commands;
using Udemy.CQRS.CQRS.Handlers;
using Udemy.CQRS.CQRS.Queries;

namespace Udemy.CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //private readonly GetStudentByIdQueryHandler _getStudentByIdQueryHandler;
        //private readonly GetStudentsQueryHandler _getStudentQueryHandler;
        //private readonly CreateStudentCommandHandler _createStudentCommandHandler;
        //private readonly RemoveStudentCommandHandler _removeStudentCommandHandler;
        //private readonly UpdateStudentCommandHandler _updateStudentCommandHandler;
        private readonly IMediator _mediator;

        public StudentController(/*GetStudentByIdQueryHandler getStudentByIdQueryHandler, GetStudentsQueryHandler getStudentQueryHandler, CreateStudentCommandHandler createStudentCommandHandler, RemoveStudentCommandHandler removeStudentCommandHandler, UpdateStudentCommandHandler updateStudentCommandHandler*/IMediator mediator)
        {
            _mediator = mediator;
            //_getStudentByIdQueryHandler = getStudentByIdQueryHandler;
            //_getStudentQueryHandler = getStudentQueryHandler;
            //_createStudentCommandHandler = createStudentCommandHandler;
            //_removeStudentCommandHandler = removeStudentCommandHandler;
            //_updateStudentCommandHandler = updateStudentCommandHandler;
        }

        [HttpGet("{id}")]
        public async Task <IActionResult> GetStudent(int id)
        {
            var result=await _mediator.Send(new GetStudentByIdQuery(id));
            
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetStudentsQuery());

            return Ok(result);
        }
        [HttpPost]
        public async  Task<IActionResult> Create(CreateStudentCommand command)
        {
           await  _mediator.Send(command);
            return Created("", command.Name);

        }
        [HttpDelete("{id}")]
        public async Task< IActionResult> Remove(int id)
        {
            await _mediator.Send(new RemoveStudentCommand(id));

            return NoContent();
        }
        [HttpPut]
        public async Task< IActionResult> Update(UpdateStudentCommand command)
        {
           await  _mediator.Send(command);
            return NoContent();
        }
    }
}
