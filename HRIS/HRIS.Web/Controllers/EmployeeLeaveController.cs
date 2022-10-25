using Autofac;
using HRIS.Web.Models;
using HRIS.Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Web.Controllers
{
    public class EmployeeLeaveController : Controller
    {
        private readonly ILifetimeScope _scope;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeLeaveController(IUnitOfWork unitOfWork, ILifetimeScope scope)
        {
            _unitOfWork = unitOfWork;
            _scope = scope;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            EmployeeLeaveModel employeeLeaveModel = new();
            employeeLeaveModel.Id = Guid.NewGuid();

            return View(employeeLeaveModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeLeaveModel obj)
        {
            if (ModelState.IsValid)
            {
                obj.CreateEmployeeLeave(_unitOfWork);
                return RedirectToAction("Create");
            }

            return View(obj);
        }


        [HttpGet]
        public ActionResult GetAll()
        {
            EmployeeLeaveModel employeeLeaveModel = new();
            var objEmployeeLeaveList = employeeLeaveModel.GetAll(_unitOfWork);
            return Json(new { data = objEmployeeLeaveList });
        }
    }
}
