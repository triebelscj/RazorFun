using Microsoft.AspNetCore.Mvc;
namespace razorFun.Controllers
{
    public class HelloController : Controller   // inheritance Hello Controller is inheriting data from Controller-- indexController.cs
    {
        //for each request add a route
        [HttpGet]       //http request
        [Route("")]     //where to go
        public ViewResult Index()
        {
            return View();
        }
    }
}