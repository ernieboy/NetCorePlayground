using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCorePlayground.Web.Controllers
{
    public class CoursesController : Controller
    {
        private readonly IMediator _mediator;


        public CoursesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
