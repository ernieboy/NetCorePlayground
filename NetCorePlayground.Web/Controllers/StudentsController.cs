using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NetCorePlayground.Application.MediatrNotifcations.Student;
using NetCorePlayground.Application.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCorePlayground.Web.Controllers
{
    public class StudentsController : Controller
    {
        private IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

		public async Task<IActionResult> Add([FromBody]AddNewStudent newStudent)
		{
            var addNewStudentNotification = new NewStudentAddedNotification();
			await _mediator.Publish(addNewStudentNotification);
			return Ok();
		}

		//AddNewStudent
	}
}
