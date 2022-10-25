using Autofac;
using HRIS.Web.Models;
using HRIS.Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Web.Controllers
{
    public class EmployeeLeaveController : Controller
    {
        private readonly ILifetimeScope _scope;

        public EmployeeLeaveController(ILifetimeScope scope)
        {
            _scope = scope;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            EmployeeLeaveModel employeeLeaveModel = _scope.Resolve<EmployeeLeaveModel>();
            employeeLeaveModel.Id = employeeLeaveModel.GenerateNewId();

            return View(employeeLeaveModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeLeaveModel obj)
        {
            if (ModelState.IsValid)
            {
                obj.ResolveDependency(_scope);
                obj.CreateEmployeeLeave();
                return RedirectToAction("Create");
            }

            return View(obj);
        }


        [HttpGet]
        public ActionResult GetAll()
        {
            EmployeeLeaveModel employeeLeaveModel = _scope.Resolve<EmployeeLeaveModel>();
            employeeLeaveModel.ResolveDependency(_scope);

            var objEmployeeLeaveList = employeeLeaveModel.GetAll();
            return Json(new { data = objEmployeeLeaveList });
        }
    }
}
